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
            var tmp = ReadCfg("tree.cfg");
            Tree.Load(tmp);
            foreach (var part in Tree.Nodes.SelectMany(n => n.Parts))
            {
                dataList.Items.Add(part);
            }
        }

        private static string ReadCfg(string cfg)
        {
            //
            // Read in a file line-by-line, and store it all in a List.
            //
            var list = new List<string>();
            var cfgout = "";
            using (var reader = new StreamReader(cfg))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    cfgout = cfgout + line + "\r\n";
                    list.Add(line); // Add to list.
                }
            }
            return cfgout;
        }
    }
}
