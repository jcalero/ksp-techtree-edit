using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AVTTLoaderStandalone.Properties;

namespace AVTTLoaderStandalone
{
    public partial class MainWindow : Form
    {
        private AddWindow _addWindow;
        private string treeFile = "tree.cfg";
        private Tree tree;
        private TreeParser tp;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            // Load Settings
            if (Settings.Default.TreeLocation != null)
                treeFile = Settings.Default.TreeLocation;

            // Initialise tree
            tp = new TreeParser(treeFile);
            tree = tp.Tree;

            // Initialise addWindow
            _addWindow = new AddWindow(tree);
            _addWindow.OnDataAvailable += AddPartDataAvailable;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            dataList.Clear();
            if (!File.Exists(treeFile)) { dataList.Items.Add("Put tree.cfg in the same folder as this file and run again."); return; }

            foreach (var part in tree.Nodes.SelectMany(n => n.Parts))
            {
                dataList.Items.Add(part);
            }
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (_addWindow.Visible)
            {
                _addWindow.Hide();
                return;
            }
            _addWindow.SetDesktopLocation(Location.X + Width + 5, Location.Y);
            _addWindow.PopulateNodesComboBox();
            _addWindow.Show();
        }

        private void AddPartDataAvailable(object sender, EventArgs e)
        {
            dataList.Clear();
            dataList.Items.Add(_addWindow.NewPart);
            dataList.Items.Add(_addWindow.SelectedNode.Name);
            _addWindow.SelectedNode.Parts.Add(new Attribute("name = " + _addWindow.NewPart));
            tp.Save();
        }
    }
}
