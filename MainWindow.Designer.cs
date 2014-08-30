namespace AVTTLoaderStandalone
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelStatusBar = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTreeLoc = new System.Windows.Forms.Label();
            this.buttonTreeLoad = new System.Windows.Forms.Button();
            this.checkedListMods = new System.Windows.Forms.CheckedListBox();
            this.buttonSaveTree = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.buttonRestoreBackup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.AutoSize = true;
            this.labelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel.SetColumnSpan(this.labelStatusBar, 2);
            this.labelStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusBar.Location = new System.Drawing.Point(3, 337);
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(568, 20);
            this.labelStatusBar.TabIndex = 2;
            this.labelStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelStatusBar, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.checkedListMods, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonSaveTree, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonRestoreBackup, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(574, 357);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTreeLoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTreeLoad, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelTreeLoc
            // 
            this.labelTreeLoc.AutoSize = true;
            this.labelTreeLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTreeLoc.Location = new System.Drawing.Point(3, 0);
            this.labelTreeLoc.Name = "labelTreeLoc";
            this.labelTreeLoc.Size = new System.Drawing.Size(99, 30);
            this.labelTreeLoc.TabIndex = 0;
            this.labelTreeLoc.Text = "Location of tree.cfg";
            this.labelTreeLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonTreeLoad
            // 
            this.buttonTreeLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTreeLoad.Location = new System.Drawing.Point(108, 3);
            this.buttonTreeLoad.Name = "buttonTreeLoad";
            this.buttonTreeLoad.Size = new System.Drawing.Size(463, 24);
            this.buttonTreeLoad.TabIndex = 1;
            this.buttonTreeLoad.Text = "Browse...";
            this.buttonTreeLoad.UseVisualStyleBackColor = true;
            this.buttonTreeLoad.Click += new System.EventHandler(this.ButtonTreeLoadClick);
            // 
            // checkedListMods
            // 
            this.checkedListMods.CheckOnClick = true;
            this.tableLayoutPanel.SetColumnSpan(this.checkedListMods, 2);
            this.checkedListMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListMods.FormattingEnabled = true;
            this.checkedListMods.Items.AddRange(new object[] {
            "item1",
            "item2"});
            this.checkedListMods.Location = new System.Drawing.Point(10, 82);
            this.checkedListMods.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.checkedListMods.MultiColumn = true;
            this.checkedListMods.Name = "checkedListMods";
            this.checkedListMods.Size = new System.Drawing.Size(554, 214);
            this.checkedListMods.TabIndex = 4;
            // 
            // buttonSaveTree
            // 
            this.buttonSaveTree.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveTree.Location = new System.Drawing.Point(409, 302);
            this.buttonSaveTree.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonSaveTree.Name = "buttonSaveTree";
            this.buttonSaveTree.Size = new System.Drawing.Size(155, 32);
            this.buttonSaveTree.TabIndex = 5;
            this.buttonSaveTree.Text = "Update Tree";
            this.buttonSaveTree.UseVisualStyleBackColor = true;
            this.buttonSaveTree.Click += new System.EventHandler(this.ButtonSaveTreeClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCheckAll);
            this.flowLayoutPanel1.Controls.Add(this.buttonUncheckAll);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 35);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCheckAll.Location = new System.Drawing.Point(3, 9);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckAll.TabIndex = 0;
            this.buttonCheckAll.Text = "Check All";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.ButtonCheckAllClick);
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUncheckAll.Location = new System.Drawing.Point(84, 9);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheckAll.TabIndex = 1;
            this.buttonUncheckAll.Text = "Uncheck All";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.ButtonUncheckAllClick);
            // 
            // buttonRestoreBackup
            // 
            this.buttonRestoreBackup.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRestoreBackup.Location = new System.Drawing.Point(10, 302);
            this.buttonRestoreBackup.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.buttonRestoreBackup.Name = "buttonRestoreBackup";
            this.buttonRestoreBackup.Size = new System.Drawing.Size(151, 32);
            this.buttonRestoreBackup.TabIndex = 7;
            this.buttonRestoreBackup.Text = "Restore tree";
            this.buttonRestoreBackup.UseVisualStyleBackColor = true;
            this.buttonRestoreBackup.Click += new System.EventHandler(this.ButtonRestoreBackupClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.developerOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // developerOptionsToolStripMenuItem
            // 
            this.developerOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModToolStripMenuItem,
            this.editModToolStripMenuItem});
            this.developerOptionsToolStripMenuItem.Name = "developerOptionsToolStripMenuItem";
            this.developerOptionsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.developerOptionsToolStripMenuItem.Text = "Developer Options";
            // 
            // addModToolStripMenuItem
            // 
            this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            this.addModToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addModToolStripMenuItem.Text = "Add Mod...";
            this.addModToolStripMenuItem.Click += new System.EventHandler(this.AddModToolStripMenuItemClick);
            // 
            // editModToolStripMenuItem
            // 
            this.editModToolStripMenuItem.Name = "editModToolStripMenuItem";
            this.editModToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editModToolStripMenuItem.Text = "Edit Mod...";
            this.editModToolStripMenuItem.Click += new System.EventHandler(this.EditModToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Ackander\'s Vertical Tech Tree Config Tool v0.2.2";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatusBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTreeLoc;
        private System.Windows.Forms.Button buttonTreeLoad;
        private System.Windows.Forms.CheckedListBox checkedListMods;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.Button buttonRestoreBackup;

    }
}

