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
        private string treeFile;
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
            {
                treeFile = Settings.Default.TreeLocation;
                buttonTreeLoad.Text = treeFile;
            }

            // Initialise tree
            if (treeFile != null) InitialiseTree();

            // Initialise addWindow
            _addWindow = new AddWindow(tree);
            _addWindow.OnDataAvailable += AddPartDataAvailable;
        }

        private void InitialiseTree()
        {
            tp = new TreeParser(treeFile);
            tree = tp.Tree;
        }

        private void AddPartDataAvailable(object sender, EventArgs e)
        {
            _addWindow.SelectedNode.Parts.Add(new Attribute("name = " + _addWindow.NewPart));
            tp.Save();
        }

        private void ButtonTreeLoadClick(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            
            treeFile = openFileDialog1.FileName;
            buttonTreeLoad.Text = treeFile;
            Settings.Default.TreeLocation = treeFile;
            InitialiseTree();
            Settings.Default.Save();
        }
    }
}
