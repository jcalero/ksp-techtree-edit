using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor.Views
{
	partial class AddWindow
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
			_labelNode = new System.Windows.Forms.Label();
			_label1 = new System.Windows.Forms.Label();
			_labelPartName = new System.Windows.Forms.Label();
			_textBoxNewPart = new System.Windows.Forms.TextBox();
			_comboBoxNodes = new System.Windows.Forms.ComboBox();
			_buttonAddConfirm = new System.Windows.Forms.Button();
			_tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			//
			// tableLayoutPanel1
			//
			_tableLayoutPanel1.ColumnCount = 3;
			_tableLayoutPanel1.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    30F));
			_tableLayoutPanel1.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Percent,
				                                    70F));
			_tableLayoutPanel1.ColumnStyles.Add(
			                                    new System.Windows.Forms.ColumnStyle(
				                                    System.Windows.Forms.SizeType.Absolute,
				                                    14F));
			_tableLayoutPanel1.Controls.Add(_labelNode, 0, 3);
			_tableLayoutPanel1.Controls.Add(_label1, 0, 0);
			_tableLayoutPanel1.Controls.Add(_labelPartName, 0, 1);
			_tableLayoutPanel1.Controls.Add(_textBoxNewPart, 1, 1);
			_tableLayoutPanel1.Controls.Add(_comboBoxNodes, 1, 3);
			_tableLayoutPanel1.Controls.Add(_buttonAddConfirm, 0, 6);
			_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			_tableLayoutPanel1.Name = "_tableLayoutPanel1";
			_tableLayoutPanel1.RowCount = 7;
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 20F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 40F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 20F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 20F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 20F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Percent,
				                                 100F));
			_tableLayoutPanel1.RowStyles.Add(
			                                 new System.Windows.Forms.RowStyle(
				                                 System.Windows.Forms.SizeType.Absolute,
				                                 40F));
			_tableLayoutPanel1.Size = new System.Drawing.Size(284, 172);
			_tableLayoutPanel1.TabIndex = 0;
			//
			// labelNode
			//
			_labelNode.AutoSize = true;
			_labelNode.Dock = System.Windows.Forms.DockStyle.Fill;
			_labelNode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			_labelNode.Location = new System.Drawing.Point(3, 80);
			_labelNode.Name = "_labelNode";
			_labelNode.Size = new System.Drawing.Size(75, 20);
			_labelNode.TabIndex = 3;
			_labelNode.Text = Resources.AddWindow_Node_Label;
			_labelNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// label1
			//
			_label1.AutoSize = true;
			_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_tableLayoutPanel1.SetColumnSpan(_label1, 3);
			_label1.Dock = System.Windows.Forms.DockStyle.Fill;
			_label1.Font = new System.Drawing.Font(
				"Microsoft Sans Serif",
				8.25F,
				System.Drawing.FontStyle.Bold,
				System.Drawing.GraphicsUnit.Point,
				0);
			_label1.Location = new System.Drawing.Point(3, 0);
			_label1.Name = "_label1";
			_label1.Size = new System.Drawing.Size(278, 20);
			_label1.TabIndex = 0;
			_label1.Text = Resources.AddWindow_Node_AddPart;
			_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// labelPartName
			//
			_labelPartName.AutoSize = true;
			_labelPartName.Dock = System.Windows.Forms.DockStyle.Fill;
			_labelPartName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			_labelPartName.Location = new System.Drawing.Point(3, 20);
			_labelPartName.Name = "_labelPartName";
			_labelPartName.Size = new System.Drawing.Size(75, 40);
			_labelPartName.TabIndex = 1;
			_labelPartName.Text = Resources.AddWindow_Part_Name_Label;
			_labelPartName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// textBoxNewPart
			//
			_textBoxNewPart.Anchor =
				System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			_textBoxNewPart.Location = new System.Drawing.Point(84, 30);
			_textBoxNewPart.Name = "_textBoxNewPart";
			_textBoxNewPart.Size = new System.Drawing.Size(183, 20);
			_textBoxNewPart.TabIndex = 2;
			//
			// comboBoxNodes
			//
			_comboBoxNodes.Dock = System.Windows.Forms.DockStyle.Fill;
			_comboBoxNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			_comboBoxNodes.FormattingEnabled = true;
			_comboBoxNodes.Location = new System.Drawing.Point(84, 83);
			_comboBoxNodes.Name = "_comboBoxNodes";
			_comboBoxNodes.Size = new System.Drawing.Size(183, 21);
			_comboBoxNodes.TabIndex = 4;
			//
			// buttonAddConfirm
			//
			_buttonAddConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
			_tableLayoutPanel1.SetColumnSpan(_buttonAddConfirm, 3);
			_buttonAddConfirm.Location = new System.Drawing.Point(104, 140);
			_buttonAddConfirm.Name = "_buttonAddConfirm";
			_buttonAddConfirm.Size = new System.Drawing.Size(75, 23);
			_buttonAddConfirm.TabIndex = 5;
			_buttonAddConfirm.Text = Resources.AddWindow_Part_AddButton_Text;
			_buttonAddConfirm.UseVisualStyleBackColor = true;
			_buttonAddConfirm.Click += ButtonAddConfirmClick;
			//
			// AddWindow
			//
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(284, 172);
			Controls.Add(_tableLayoutPanel1);
			Name = "AddWindow";
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = Resources.AddWindow_Node_AddWindow_Title;
			FormClosing += AddWindowFormClosing;
			_tableLayoutPanel1.ResumeLayout(false);
			_tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
		private System.Windows.Forms.Label _label1;
		private System.Windows.Forms.Label _labelPartName;
		private System.Windows.Forms.TextBox _textBoxNewPart;
		private System.Windows.Forms.Label _labelNode;
		private System.Windows.Forms.ComboBox _comboBoxNodes;
		private System.Windows.Forms.Button _buttonAddConfirm;
	}
}
