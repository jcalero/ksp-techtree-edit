using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class EditModDialog : Form
    {
        public ModCollection MC;
        private ModCollection _tmpMC;
        private Dictionary<string, string> _tmpModParts;
        private int _lastIndex;
        private FolderBrowserDialog _fb;

        public EditModDialog()
        {
            InitializeComponent();
        }

        private void EditModDialogLoad(object sender, EventArgs e)
        {
            if (MC == null) return;

            _fb = new FolderBrowserDialog();

            _tmpMC = MC.Clone();
            _tmpModParts = new Dictionary<string, string>();

            ReloadData();
        }

        private void ReloadData()
        {
            comboBox1.Items.Clear();
            _tmpModParts.Clear();
            foreach (var mod in _tmpMC.Mods)
            {
                comboBox1.Items.Add(mod.Name);
                if (!_tmpModParts.ContainsKey(mod.Name))
                    _tmpModParts.Add(mod.Name, mod.Parts.Keys.Aggregate("", (current, p) => current + (p + ", ")));
                _tmpModParts[mod.Name] += mod.Prefixes.Aggregate("", (current, p) => current + (p + ", "));
            }
            if (comboBox1.Items.Count < 1)
            {
                textBoxParts.Text = "";
                return;
            }
            var newIndex = _lastIndex - 1;
            if (newIndex < 0) newIndex = 0;
            comboBox1.SelectedIndex = newIndex;
        }

        private void TextBoxPartsTextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 1) return;
            _tmpModParts[_tmpMC.Mods[comboBox1.SelectedIndex].Name] = textBoxParts.Text;
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            _lastIndex = comboBox1.SelectedIndex;
            textBoxParts.Text = _tmpModParts[_tmpMC.Mods[_lastIndex].Name];
        }

        private void ButtonDeleteModClick(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 1) return;
            _tmpModParts.Remove(_tmpMC.Mods[comboBox1.SelectedIndex].Name);
            _tmpMC.Mods.Remove(_tmpMC.Mods[comboBox1.SelectedIndex]);
            ReloadData();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            _tmpMC = null;
            _tmpModParts = null;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            foreach (var partlist in _tmpModParts)
            {
                foreach (var mod in _tmpMC.Mods)
                {
                    if (mod.Name != partlist.Key) continue;
                    mod.Parts = ParsePartList(partlist.Value);
                    mod.Prefixes = ParsePrefixList(partlist.Value);
                    break;
                }
            }
            MC = _tmpMC;
        }

        private static Dictionary<string, string> ParsePartList(string parts)
        {
            return Regex.Split(parts, ",")
                   .Where(part => part.Trim().Length >= 1 && part.Trim().Last() != '*')
                   .ToDictionary(part => part.Trim(), part => "");
        }

        private static List<string> ParsePrefixList(string prefixes)
        {
            return (from part
                    in Regex.Split(prefixes, ",")
                    where part.Trim().Length >= 1 && part.Trim().Last() == '*'
                    select part.Trim()).ToList();
        }

        private void buttonAutoParts_Click(object sender, EventArgs e)
        {
            var result = _fb.ShowDialog();

            if (result != DialogResult.OK) return;

            var pf = new PartsFinder();
            textBoxParts.Text = pf.FindPartsString(_fb.SelectedPath);
        }
    }
}
