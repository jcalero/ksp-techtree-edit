using System;
using System.Windows.Forms;

namespace KSPTechTreeEditor.Views
{
    public partial class AddWindow : Form
    {
        public Node SelectedNode { get; private set; }
        public string NewPart { get; private set; }
        private readonly Tree _tree;

        public event EventHandler OnDataAvailable;

        //public AddWindow()
        //{
        //    InitializeComponent();
        //}

        public AddWindow(Tree tree)
        {
            InitializeComponent();
            _tree = tree;
        }

        public void PopulateNodesComboBox()
        {
            foreach (var node in _tree.Nodes)
            {
                _comboBoxNodes.Items.Add((string) node.Name);
            }

            if (_comboBoxNodes.Items.Count > 0) _comboBoxNodes.SelectedIndex = 0;
        }

        private void ButtonAddConfirmClick(object sender, EventArgs e)
        {
            NewPart = _textBoxNewPart.Text;
            foreach (var node in _tree.Nodes)
            {
                if (node.Name != (string) _comboBoxNodes.SelectedItem) continue;
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
