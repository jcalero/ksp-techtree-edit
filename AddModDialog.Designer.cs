namespace AVTTLoaderStandalone
{
    partial class AddModDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModName = new System.Windows.Forms.TextBox();
            this.labelPartListInfo = new System.Windows.Forms.Label();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUseWildcards = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxModName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPartListInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxParts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelUseWildcards, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.523511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.47649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxModName
            // 
            this.textBoxModName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxModName.Location = new System.Drawing.Point(53, 3);
            this.textBoxModName.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBoxModName.MaxLength = 1000;
            this.textBoxModName.Name = "textBoxModName";
            this.textBoxModName.Size = new System.Drawing.Size(358, 20);
            this.textBoxModName.TabIndex = 1;
            this.textBoxModName.TextChanged += new System.EventHandler(this.TextBoxModNameTextChanged);
            // 
            // labelPartListInfo
            // 
            this.labelPartListInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelPartListInfo, 2);
            this.labelPartListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPartListInfo.Location = new System.Drawing.Point(13, 38);
            this.labelPartListInfo.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.labelPartListInfo.Name = "labelPartListInfo";
            this.labelPartListInfo.Size = new System.Drawing.Size(405, 20);
            this.labelPartListInfo.TabIndex = 2;
            this.labelPartListInfo.Text = "Parts that correspond to mod: (Separate by comma)";
            this.labelPartListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPartListInfo.Click += new System.EventHandler(this.labelPartListInfo_Click);
            // 
            // textBoxParts
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxParts, 2);
            this.textBoxParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxParts.Location = new System.Drawing.Point(10, 81);
            this.textBoxParts.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxParts.Multiline = true;
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(401, 216);
            this.textBoxParts.TabIndex = 3;
            this.textBoxParts.TextChanged += new System.EventHandler(this.TextBoxPartsTextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 39);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.Location = new System.Drawing.Point(336, 3);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCancel.Location = new System.Drawing.Point(10, 3);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelUseWildcards
            // 
            this.labelUseWildcards.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUseWildcards.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelUseWildcards, 2);
            this.labelUseWildcards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseWildcards.Location = new System.Drawing.Point(15, 61);
            this.labelUseWildcards.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.labelUseWildcards.Name = "labelUseWildcards";
            this.labelUseWildcards.Size = new System.Drawing.Size(190, 13);
            this.labelUseWildcards.TabIndex = 5;
            this.labelUseWildcards.Text = "Use wildcards! (E.g.: B9.*, KW*)";
            this.labelUseWildcards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddModDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(421, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddModDialog";
            this.Text = "Add a new mod";
            this.Load += new System.EventHandler(this.AddModDialogLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModName;
        private System.Windows.Forms.Label labelPartListInfo;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUseWildcards;
    }
}