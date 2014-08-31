using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor
{
	partial class EditModDialog
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
			_labelPartListInfo = new System.Windows.Forms.Label();
			_textBoxParts = new System.Windows.Forms.TextBox();
			_tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			_buttonSave = new System.Windows.Forms.Button();
			_buttonCancel = new System.Windows.Forms.Button();
			_comboBox1 = new System.Windows.Forms.ComboBox();
			_buttonDeleteMod = new System.Windows.Forms.Button();
			_tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			_buttonAutoParts = new System.Windows.Forms.Button();
			_tableLayoutPanel1.SuspendLayout();
			_tableLayoutPanel2.SuspendLayout();
			_tableLayoutPanel3.SuspendLayout();
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
			_tableLayoutPanel1.Controls.Add(_labelPartListInfo, 0, 2);
			_tableLayoutPanel1.Controls.Add(_textBoxParts, 0, 3);
			_tableLayoutPanel1.Controls.Add(_tableLayoutPanel2, 0, 4);
			_tableLayoutPanel1.Controls.Add(_comboBox1, 1, 0);
			_tableLayoutPanel1.Controls.Add(_tableLayoutPanel3, 0, 1);
			_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			_tableLayoutPanel1.Name = "_tableLayoutPanel1";
			_tableLayoutPanel1.RowCount = 5;
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 27F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 29F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 23F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 100F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 38F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 20F));
			_tableLayoutPanel1.Size = new System.Drawing.Size(421, 339);
			_tableLayoutPanel1.TabIndex = 0;
			//
			// label1
			//
			_label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			_label1.AutoSize = true;
			_label1.Location = new System.Drawing.Point(16, 7);
			_label1.Name = "_label1";
			_label1.Size = new System.Drawing.Size(31, 13);
			_label1.TabIndex = 0;
			_label1.Text = Resources.EditModDialog_Mod_Label;
			_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// labelPartListInfo
			//
			_labelPartListInfo.AutoSize = true;
			_tableLayoutPanel1.SetColumnSpan(_labelPartListInfo, 2);
			_labelPartListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			_labelPartListInfo.Location = new System.Drawing.Point(13, 56);
			_labelPartListInfo.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
			_labelPartListInfo.Name = "_labelPartListInfo";
			_labelPartListInfo.Size = new System.Drawing.Size(405, 23);
			_labelPartListInfo.TabIndex = 2;
			_labelPartListInfo.Text = Resources.EditModDialog_PartsField_Label;
			_labelPartListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// textBoxParts
			//
			_tableLayoutPanel1.SetColumnSpan(_textBoxParts, 2);
			_textBoxParts.Dock = System.Windows.Forms.DockStyle.Fill;
			_textBoxParts.Location = new System.Drawing.Point(10, 82);
			_textBoxParts.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			_textBoxParts.Multiline = true;
			_textBoxParts.Name = "_textBoxParts";
			_textBoxParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			_textBoxParts.Size = new System.Drawing.Size(401, 216);
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
				                                    50F));
			_tableLayoutPanel2.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    50F));
			_tableLayoutPanel2.Controls.Add(_buttonSave, 1, 0);
			_tableLayoutPanel2.Controls.Add(_buttonCancel, 0, 0);
			_tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel2.Location = new System.Drawing.Point(0, 301);
			_tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			_tableLayoutPanel2.Name = "_tableLayoutPanel2";
			_tableLayoutPanel2.RowCount = 1;
			_tableLayoutPanel2.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 50F));
			_tableLayoutPanel2.Size = new System.Drawing.Size(421, 38);
			_tableLayoutPanel2.TabIndex = 4;
			//
			// buttonSave
			//
			_buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			_buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
			_buttonSave.Location = new System.Drawing.Point(336, 3);
			_buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			_buttonSave.Name = "_buttonSave";
			_buttonSave.Size = new System.Drawing.Size(75, 32);
			_buttonSave.TabIndex = 0;
			_buttonSave.Text = Resources.EditModDialog_SaveButton_Text;
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
			_buttonCancel.Size = new System.Drawing.Size(75, 32);
			_buttonCancel.TabIndex = 1;
			_buttonCancel.Text = Resources.EditModDialog_CancelButton_Text;
			_buttonCancel.UseVisualStyleBackColor = true;
			_buttonCancel.Click += ButtonCancelClick;
			//
			// comboBox1
			//
			_comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			_comboBox1.FormattingEnabled = true;
			_comboBox1.Location = new System.Drawing.Point(53, 3);
			_comboBox1.Name = "_comboBox1";
			_comboBox1.Size = new System.Drawing.Size(365, 21);
			_comboBox1.TabIndex = 5;
			_comboBox1.SelectedIndexChanged += ComboBox1SelectedIndexChanged;
			//
			// buttonDeleteMod
			//
			_buttonDeleteMod.Anchor =
				System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			_buttonDeleteMod.Location = new System.Drawing.Point(343, 3);
			_buttonDeleteMod.Name = "_buttonDeleteMod";
			_buttonDeleteMod.Size = new System.Drawing.Size(75, 21);
			_buttonDeleteMod.TabIndex = 6;
			_buttonDeleteMod.Text = Resources.EditModDialog_DeleteButton_Text;
			_buttonDeleteMod.UseVisualStyleBackColor = true;
			_buttonDeleteMod.Click += ButtonDeleteModClick;
			//
			// tableLayoutPanel3
			//
			_tableLayoutPanel3.ColumnCount = 2;
			_tableLayoutPanel1.SetColumnSpan(_tableLayoutPanel3, 2);
			_tableLayoutPanel3.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    50F));
			_tableLayoutPanel3.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    50F));
			_tableLayoutPanel3.Controls.Add(_buttonDeleteMod, 1, 0);
			_tableLayoutPanel3.Controls.Add(_buttonAutoParts, 0, 0);
			_tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel3.Location = new System.Drawing.Point(0, 27);
			_tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			_tableLayoutPanel3.Name = "_tableLayoutPanel3";
			_tableLayoutPanel3.RowCount = 1;
			_tableLayoutPanel3.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 50F));
			_tableLayoutPanel3.Size = new System.Drawing.Size(421, 29);
			_tableLayoutPanel3.TabIndex = 7;
			//
			// buttonAutoParts
			//
			_buttonAutoParts.Location = new System.Drawing.Point(3, 3);
			_buttonAutoParts.Name = "_buttonAutoParts";
			_buttonAutoParts.Size = new System.Drawing.Size(120, 23);
			_buttonAutoParts.TabIndex = 7;
			_buttonAutoParts.Text = Resources.EditModDialog_AutoFindButton_Text;
			_buttonAutoParts.UseVisualStyleBackColor = true;
			_buttonAutoParts.Click += buttonAutoParts_Click;
			//
			// EditModDialog
			//
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			CancelButton = _buttonCancel;
			ClientSize = new System.Drawing.Size(421, 339);
			Controls.Add(_tableLayoutPanel1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Name = "EditModDialog";
			Text = Resources.EditModDialog_Title_Text;
			Load += EditModDialogLoad;
			_tableLayoutPanel1.ResumeLayout(false);
			_tableLayoutPanel1.PerformLayout();
			_tableLayoutPanel2.ResumeLayout(false);
			_tableLayoutPanel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
		private System.Windows.Forms.Label _label1;
		private System.Windows.Forms.Label _labelPartListInfo;
		private System.Windows.Forms.TextBox _textBoxParts;
		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
		private System.Windows.Forms.Button _buttonSave;
		private System.Windows.Forms.Button _buttonCancel;
		private System.Windows.Forms.ComboBox _comboBox1;
		private System.Windows.Forms.Button _buttonDeleteMod;
		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel3;
		private System.Windows.Forms.Button _buttonAutoParts;
	}
}
