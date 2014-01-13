using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class AddModDialog : Form
    {
        public string ModTitle { get; private set; }
        public string ModParts { get; private set; }
        public string ModFolder { get; private set; }

        private FolderBrowserDialog fb;

        public AddModDialog()
        {
            InitializeComponent();
        }

        private void AddModDialogLoad(object sender, EventArgs e)
        {
            fb = new FolderBrowserDialog();
        }

        private void TextBoxPartsTextChanged(object sender, EventArgs e)
        {
            ModParts = textBoxParts.Text;
        }

        private void TextBoxModNameTextChanged(object sender, EventArgs e)
        {
            ModTitle = textBoxModName.Text;
        }

        private void ButtonModFolderClick(object sender, EventArgs e)
        {
            var result = fb.ShowDialog();

            if (result != DialogResult.OK) return;
            
            ModFolder = fb.SelectedPath;

            var pf = new PartsFinder();
            ModParts = pf.FindPartsString(ModFolder);
            textBoxParts.Text = ModParts;
        }
    }
}
