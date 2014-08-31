using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor
{
	partial class AddModDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private readonly System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			_label1 = new System.Windows.Forms.Label();
			_textBoxModName = new System.Windows.Forms.TextBox();
			_labelPartListInfo = new System.Windows.Forms.Label();
			_textBoxParts = new System.Windows.Forms.TextBox();
			_tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			_buttonSave = new System.Windows.Forms.Button();
			_buttonCancel = new System.Windows.Forms.Button();
			_labelUseWildcards = new System.Windows.Forms.Label();
			_labelModFolder = new System.Windows.Forms.Label();
			_buttonModFolder = new System.Windows.Forms.Button();
			_progressBar = new System.Windows.Forms.ProgressBar();
			_tableLayoutPanel1.SuspendLayout();
			_tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			//
			// tableLayoutPanel1
			//
			_tableLayoutPanel1.ColumnCount = 2;
			_tableLayoutPanel1.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Absolute,
				                                    50F));
			_tableLayoutPanel1.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    100F));
			_tableLayoutPanel1.Controls.Add(_label1, 0, 0);
			_tableLayoutPanel1.Controls.Add(_textBoxModName, 1, 0);
			_tableLayoutPanel1.Controls.Add(_labelPartListInfo, 0, 2);
			_tableLayoutPanel1.Controls.Add(_textBoxParts, 0, 4);
			_tableLayoutPanel1.Controls.Add(_tableLayoutPanel2, 0, 6);
			_tableLayoutPanel1.Controls.Add(_labelUseWildcards, 0, 3);
			_tableLayoutPanel1.Controls.Add(_labelModFolder, 0, 1);
			_tableLayoutPanel1.Controls.Add(_buttonModFolder, 1, 1);
			_tableLayoutPanel1.Controls.Add(_progressBar, 0, 5);
			_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			_tableLayoutPanel1.Name = "_tableLayoutPanel1";
			_tableLayoutPanel1.RowCount = 7;
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 25F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 30F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 21F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 19F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 100F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 25F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 35F));
			_tableLayoutPanel1.Size = new System.Drawing.Size(421, 339);
			_tableLayoutPanel1.TabIndex = 0;
			//
			// label1
			//
			_label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			_label1.AutoSize = true;
			_label1.Location = new System.Drawing.Point(9, 6);
			_label1.Name = "_label1";
			_label1.Size = new System.Drawing.Size(38, 13);
			_label1.TabIndex = 0;
			_label1.Text = Resources.AddModDialog_ModName_Label;
			_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// textBoxModName
			//
			_textBoxModName.Dock = System.Windows.Forms.DockStyle.Fill;
			_textBoxModName.Location = new System.Drawing.Point(53, 3);
			_textBoxModName.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			_textBoxModName.MaxLength = 1000;
			_textBoxModName.Name = "_textBoxModName";
			_textBoxModName.Size = new System.Drawing.Size(358, 20);
			_textBoxModName.TabIndex = 1;
			_textBoxModName.TextChanged += TextBoxModNameTextChanged;
			//
			// labelPartListInfo
			//
			_labelPartListInfo.AutoSize = true;
			_tableLayoutPanel1.SetColumnSpan(_labelPartListInfo, 2);
			_labelPartListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			_labelPartListInfo.Location = new System.Drawing.Point(13, 55);
			_labelPartListInfo.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
			_labelPartListInfo.Name = "_labelPartListInfo";
			_labelPartListInfo.Size = new System.Drawing.Size(405, 21);
			_labelPartListInfo.TabIndex = 2;
			_labelPartListInfo.Text = Resources.AddModDialog_PartsField_Label;
			_labelPartListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// textBoxParts
			//
			_tableLayoutPanel1.SetColumnSpan(_textBoxParts, 2);
			_textBoxParts.Dock = System.Windows.Forms.DockStyle.Fill;
			_textBoxParts.Location = new System.Drawing.Point(10, 98);
			_textBoxParts.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			_textBoxParts.Multiline = true;
			_textBoxParts.Name = "_textBoxParts";
			_textBoxParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			_textBoxParts.Size = new System.Drawing.Size(401, 178);
			_textBoxParts.TabIndex = 3;
			_textBoxParts.TextChanged += TextBoxPartsTextChanged;
			//
			// tableLayoutPanel2
			//
			_tableLayoutPanel2.ColumnCount = 2;
			_tableLayoutPanel1.SetColumnSpan(_tableLayoutPanel2, 2);
			_tableLayoutPanel2.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    49.64371F));
			_tableLayoutPanel2.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    50.35629F));
			_tableLayoutPanel2.Controls.Add(_buttonSave, 1, 0);
			_tableLayoutPanel2.Controls.Add(_buttonCancel, 0, 0);
			_tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel2.Location = new System.Drawing.Point(0, 304);
			_tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			_tableLayoutPanel2.Name = "_tableLayoutPanel2";
			_tableLayoutPanel2.RowCount = 1;
			_tableLayoutPanel2.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 50F));
			_tableLayoutPanel2.Size = new System.Drawing.Size(421, 35);
			_tableLayoutPanel2.TabIndex = 4;
			//
			// buttonSave
			//
			_buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
			_buttonSave.Location = new System.Drawing.Point(336, 3);
			_buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			_buttonSave.Name = "_buttonSave";
			_buttonSave.Size = new System.Drawing.Size(75, 29);
			_buttonSave.TabIndex = 0;
			_buttonSave.Text = Resources.AddModDialog_SaveButton_Text;
			_buttonSave.UseVisualStyleBackColor = true;
			_buttonSave.Click += ButtonSaveClick;
			//
			// buttonCancel
			//
			_buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			_buttonCancel.Dock = System.Windows.Forms.DockStyle.Left;
			_buttonCancel.Location = new System.Drawing.Point(10, 3);
			_buttonCancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			_buttonCancel.Name = "_buttonCancel";
			_buttonCancel.Size = new System.Drawing.Size(75, 29);
			_buttonCancel.TabIndex = 1;
			_buttonCancel.Text = Resources.AddModDialog_CancelButton_Text;
			_buttonCancel.UseVisualStyleBackColor = true;
			//
			// labelUseWildcards
			//
			_labelUseWildcards.Anchor = System.Windows.Forms.AnchorStyles.Left;
			_labelUseWildcards.AutoSize = true;
			_tableLayoutPanel1.SetColumnSpan(_labelUseWildcards, 2);
			_labelUseWildcards.Font = new System.Drawing.Font(
				"Microsoft Sans Serif",
				8.25F,
				System.Drawing.FontStyle.Bold,
				System.Drawing.GraphicsUnit.Point,
				0);
			_labelUseWildcards.Location = new System.Drawing.Point(15, 79);
			_labelUseWildcards.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
			_labelUseWildcards.Name = "_labelUseWildcards";
			_labelUseWildcards.Size = new System.Drawing.Size(190, 13);
			_labelUseWildcards.TabIndex = 5;
			_labelUseWildcards.Text = Resources.AddModDialog_WildcardsHint_Label;
			_labelUseWildcards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// labelModFolder
			//
			_labelModFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
			_labelModFolder.AutoSize = true;
			_labelModFolder.Location = new System.Drawing.Point(8, 33);
			_labelModFolder.Name = "_labelModFolder";
			_labelModFolder.Size = new System.Drawing.Size(39, 13);
			_labelModFolder.TabIndex = 6;
			_labelModFolder.Text = Resources.AddModDialog_ModFolder_Label;
			_labelModFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// buttonModFolder
			//
			_buttonModFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			_buttonModFolder.Location = new System.Drawing.Point(53, 28);
			_buttonModFolder.Name = "_buttonModFolder";
			_buttonModFolder.Size = new System.Drawing.Size(365, 24);
			_buttonModFolder.TabIndex = 7;
			_buttonModFolder.Text = Resources.AddModDialog_ModFolderButton_Text;
			_buttonModFolder.UseVisualStyleBackColor = true;
			_buttonModFolder.Click += ButtonModFolderClick;
			//
			// progressBar
			//
			_tableLayoutPanel1.SetColumnSpan(_progressBar, 2);
			_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			_progressBar.Location = new System.Drawing.Point(3, 282);
			_progressBar.Name = "_progressBar";
			_progressBar.Size = new System.Drawing.Size(415, 19);
			_progressBar.Step = 1;
			_progressBar.TabIndex = 8;
			//
			// AddModDialog
			//
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			CancelButton = _buttonCancel;
			ClientSize = new System.Drawing.Size(421, 339);
			Controls.Add(_tableLayoutPanel1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Name = "AddModDialog";
			Text = Resources.AddModDialog_Title_Text;
			Load += AddModDialogLoad;
			_tableLayoutPanel1.ResumeLayout(false);
			_tableLayoutPanel1.PerformLayout();
			_tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
		private System.Windows.Forms.Label _label1;
		private System.Windows.Forms.TextBox _textBoxModName;
		private System.Windows.Forms.Label _labelPartListInfo;
		private System.Windows.Forms.TextBox _textBoxParts;
		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
		private System.Windows.Forms.Button _buttonSave;
		private System.Windows.Forms.Button _buttonCancel;
		private System.Windows.Forms.Label _labelUseWildcards;
		private System.Windows.Forms.Label _labelModFolder;
		private System.Windows.Forms.Button _buttonModFolder;
		private System.Windows.Forms.ProgressBar _progressBar;
	}
}
