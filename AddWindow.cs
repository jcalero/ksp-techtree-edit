using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class AddWindow : Form
    {
        public Node SelectedNode { get; private set; }
        public string NewPart { get; private set; }

        public event EventHandler OnDataAvailable;

        public AddWindow()
        {
            InitializeComponent();
            PopulateNodesComboBox();
        }

        public void PopulateNodesComboBox()
        {
            foreach (var node in Tree.Nodes)
            {
                comboBoxNodes.Items.Add((string)node.Name);
            }

            if (comboBoxNodes.Items.Count > 0) comboBoxNodes.SelectedIndex = 0;
        }

        private void ButtonAddConfirmClick(object sender, EventArgs e)
        {
            NewPart = textBoxNewPart.Text;
            foreach (var node in Tree.Nodes)
            {
                if (node.Name != (string)comboBoxNodes.SelectedItem) continue;
                SelectedNode = node;
                if (OnDataAvailable != null)
                    OnDataAvailable(this, EventArgs.Empty);
                return;
            }
        }

        private void AddWindowFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Hide();
            e.Cancel = true;
        }
    }
}
