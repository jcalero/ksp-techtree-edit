using System;
using System.Windows.Forms;
using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor
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
			ModParts = "";
			ModTitle = "";
		}

		private void TextBoxPartsTextChanged(object sender, EventArgs e)
		{
			ModParts = _textBoxParts.Text;
		}

		private void TextBoxModNameTextChanged(object sender, EventArgs e)
		{
			ModTitle = _textBoxModName.Text;
		}

		private void ButtonModFolderClick(object sender, EventArgs e)
		{
			var result = _fb.ShowDialog();

			if (result != DialogResult.OK) return;

			var pf = new PartsFinder();

			ModFolder = _fb.SelectedPath;
			_progressBar.Value = 0;
			_progressBar.Maximum = pf.FilesCount(ModFolder);
			pf.Progress += FileProgress;

			ModParts = pf.FindPartsString(ModFolder);
			_textBoxParts.Text = ModParts;
		}

		private void FileProgress(object sender, EventArgs e)
		{
			_progressBar.Increment(1);
		}

		private void ButtonSaveClick(object sender, EventArgs e)
		{
			if (_textBoxModName.Text.Trim().Length > 0)
			{
				Close();
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show(
				                Resources.AddModDialog_MissingModName_Content,
				                Resources.AddModDialog_MissingModName_Title,
				                MessageBoxButtons.OK);
			}
		}
	}
}
