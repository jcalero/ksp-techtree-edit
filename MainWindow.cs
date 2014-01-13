using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AVTTLoaderStandalone.Properties;

namespace AVTTLoaderStandalone
{
    public partial class MainWindow : Form
    {
        private string _treeFile;
        private Tree _tree;
        private TreeParser _tp;
        private ModCollection _mc;
        private ModCollectionParser _mcp;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            // Load Settings
            if (Settings.Default.TreeLocation != null && File.Exists(Settings.Default.TreeLocation))
            {
                _treeFile = Settings.Default.TreeLocation;
                buttonTreeLoad.Text = _treeFile;
            }

            // Initialise tree
            if (_treeFile != null) InitialiseTree();
            // Initialise mod collection
            _mcp = new ModCollectionParser(_mc);
            _mcp.Load();
            _mc = _mcp.Collection;

            ReloadCheckList();
        }

        private void InitialiseTree()
        {
            _tp = new TreeParser(_treeFile);
            _tree = _tp.Tree;
        }

        private void ButtonTreeLoadClick(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            _treeFile = openFileDialog1.FileName;
            buttonTreeLoad.Text = _treeFile;
            Settings.Default.TreeLocation = _treeFile;
            InitialiseTree();
            Settings.Default.Save();
        }

        private void AddModToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var dialog = new AddModDialog())
            {
                var result = dialog.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:
                        _mc.AddMod(dialog.ModTitle, ParsePartList(dialog.ModParts));
                        ReloadCheckList();
                        _mcp.Save();
                        break;
                }
            }
        }

        private void ReloadCheckList()
        {
            checkedListMods.Items.Clear();
            foreach (var mod in _mc.Mods)
            {
                checkedListMods.Items.Add(mod.Name);
            }
        }

        private static List<string> ParsePartList(string parts)
        {
            return (from part in Regex.Split(parts, ",") where part.Length >= 1 select part.Trim()).ToList();
        }

        private void EditModToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var dialog = new EditModDialog())
            {
                dialog.MC = _mc;

                var result = dialog.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:
                        _mc = dialog.MC;
                        _mcp.Collection = dialog.MC;
                        ReloadCheckList();
                        _mcp.Save();
                        break;
                }
            }
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
