using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class MainWindow : Form
    {
        readonly AddWindow _addWindow = new AddWindow();
        private string treeFile = "tree.cfg";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            _addWindow.OnDataAvailable += AddPartDataAvailable;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            dataList.Clear();
            if (!File.Exists(treeFile)) { dataList.Items.Add("Put tree.cfg in the same folder as this file and run again."); return; }

            Tree.Load(ReadCfg(treeFile));
            foreach (var part in Tree.Nodes.SelectMany(n => n.Parts))
            {
                dataList.Items.Add(part);
            }
        }

        private static string ReadCfg(string cfg)
        {
            var cfgout = "";
            using (var reader = new StreamReader(cfg))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    cfgout = cfgout + line + "\r\n";
                }
            }
            return cfgout;
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
            Tree.Save(treeFile);
        }
    }
}
