using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            // Nothing here
        }

        private void Button1Click(object sender, EventArgs e)
        {
            dataList.Clear();
            if (!File.Exists("tree.cfg")) { dataList.Items.Add("Put tree.cfg in the same folder as this file and run again."); return; }

            Tree.Load(ReadCfg("tree.cfg"));
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
    }
}
