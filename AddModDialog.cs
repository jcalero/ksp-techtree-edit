using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class AddModDialog : Form
    {
        public string ModTitle { get; private set; }
        public string ModParts { get; private set; }

        public AddModDialog()
        {
            InitializeComponent();
        }

        private void AddModDialogLoad(object sender, EventArgs e)
        {

        }

        private void TextBoxPartsTextChanged(object sender, EventArgs e)
        {
            ModParts = textBoxParts.Text;
        }

        private void TextBoxModNameTextChanged(object sender, EventArgs e)
        {
            ModTitle = textBoxModName.Text;
        }

        private void labelPartListInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
