using System;
using System.Windows.Forms;

namespace KSPTechTreeEditor
{
    public partial class AddWindow : Form
    {
        public Node SelectedNode { get; private set; }
        public string NewPart { get; private set; }
        private Tree tree;

        public event EventHandler OnDataAvailable;

        //public AddWindow()
        //{
        //    InitializeComponent();
        //}

        public AddWindow(Tree tree)
        {
            InitializeComponent();
            this.tree = tree;
        }

        public void PopulateNodesComboBox()
        {
            foreach (var node in tree.Nodes)
            {
                comboBoxNodes.Items.Add((string)node.Name);
            }

            if (comboBoxNodes.Items.Count > 0) comboBoxNodes.SelectedIndex = 0;
        }

        private void ButtonAddConfirmClick(object sender, EventArgs e)
        {
            NewPart = textBoxNewPart.Text;
            foreach (var node in tree.Nodes)
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
