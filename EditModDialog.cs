using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KSPTechTreeEditor
{
    public partial class EditModDialog : Form
    {
        public ModCollection Mc;
        private ModCollection _tmpMc;
        private Dictionary<string, string> _tmpModParts;
        private int _lastIndex;
        private FolderBrowserDialog _fb;

        public EditModDialog()
        {
            InitializeComponent();
        }

        private void EditModDialogLoad(object sender, EventArgs e)
        {
            if (Mc == null) return;

            _fb = new FolderBrowserDialog();

            _tmpMc = Mc.Clone();
            _tmpModParts = new Dictionary<string, string>();

            ReloadData();
        }

        private void ReloadData()
        {
            _comboBox1.Items.Clear();
            _tmpModParts.Clear();
            foreach (var mod in _tmpMc.Mods)
            {
                _comboBox1.Items.Add(mod.Name);
                if (!_tmpModParts.ContainsKey(mod.Name))
                    _tmpModParts.Add(mod.Name, mod.Parts.Keys.Aggregate("", (current, p) => current + (p + ", ")));
                _tmpModParts[mod.Name] += mod.Prefixes.Aggregate("", (current, p) => current + (p + ", "));
            }
            if (_comboBox1.Items.Count < 1)
            {
                _textBoxParts.Text = "";
                return;
            }
            var newIndex = _lastIndex - 1;
            if (newIndex < 0) newIndex = 0;
            _comboBox1.SelectedIndex = newIndex;
        }

        private void TextBoxPartsTextChanged(object sender, EventArgs e)
        {
            if (_comboBox1.Items.Count < 1) return;
            _tmpModParts[_tmpMc.Mods[_comboBox1.SelectedIndex].Name] = _textBoxParts.Text;
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            _lastIndex = _comboBox1.SelectedIndex;
            _textBoxParts.Text = _tmpModParts[_tmpMc.Mods[_lastIndex].Name];
        }

        private void ButtonDeleteModClick(object sender, EventArgs e)
        {
            if (_comboBox1.Items.Count < 1) return;
            _tmpModParts.Remove(_tmpMc.Mods[_comboBox1.SelectedIndex].Name);
            _tmpMc.Mods.Remove(_tmpMc.Mods[_comboBox1.SelectedIndex]);
            ReloadData();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            _tmpMc = null;
            _tmpModParts = null;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            foreach (var partlist in _tmpModParts)
            {
                foreach (var mod in _tmpMc.Mods)
                {
                    if (mod.Name != partlist.Key) continue;
                    mod.Parts = ParsePartList(partlist.Value);
                    mod.Prefixes = ParsePrefixList(partlist.Value);
                    break;
                }
            }
            Mc = _tmpMc;
        }

        private static Dictionary<string, string> ParsePartList(string parts)
        {
            return Regex.Split(parts, ",")
                        .Where(part => part.Trim().Length >= 1 && part.Trim().Last() != '*')
                        .ToDictionary(part => part.Trim(), part => "");
        }

        private static List<string> ParsePrefixList(string prefixes)
        {
            return (from part in Regex.Split(prefixes, ",")
                    where part.Trim().Length >= 1 && part.Trim().Last() == '*'
                    select part.Trim()).ToList();
        }

        private void buttonAutoParts_Click(object sender, EventArgs e)
        {
            var result = _fb.ShowDialog();

            if (result != DialogResult.OK) return;

            var pf = new PartsFinder();
            _textBoxParts.Text = pf.FindPartsString(_fb.SelectedPath);
        }
    }
}
