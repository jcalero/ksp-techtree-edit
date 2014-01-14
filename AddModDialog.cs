using System;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
{
    public partial class AddModDialog : Form
    {
        public string ModTitle { get; private set; }
        public string ModParts { get; private set; }
        public string ModFolder { get; private set; }

        private FolderBrowserDialog _fb;

        public AddModDialog()
        {
            InitializeComponent();
        }

        private void AddModDialogLoad(object sender, EventArgs e)
        {
            _fb = new FolderBrowserDialog();
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
            var result = _fb.ShowDialog();

            if (result != DialogResult.OK) return;

            var pf = new PartsFinder();

            ModFolder = _fb.SelectedPath;
            progressBar.Value = 0;
            progressBar.Maximum = pf.FilesCount(ModFolder);
            pf.Progress += FileProgress;

            ModParts = pf.FindPartsString(ModFolder);
            textBoxParts.Text = ModParts;
        }

        private void FileProgress(object sender, EventArgs e)
        {
            progressBar.Increment(1);
        }
    }
}
