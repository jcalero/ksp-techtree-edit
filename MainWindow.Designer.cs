using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor
{
    partial class MainWindow
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
            var resources =
                new System.ComponentModel.ComponentResourceManager(typeof (MainWindow));
            _labelStatusBar = new System.Windows.Forms.Label();
            _tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            _tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            _labelTreeLoc = new System.Windows.Forms.Label();
            _buttonTreeLoad = new System.Windows.Forms.Button();
            _checkedListMods = new System.Windows.Forms.CheckedListBox();
            _buttonSaveTree = new System.Windows.Forms.Button();
            _flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            _buttonCheckAll = new System.Windows.Forms.Button();
            _buttonUncheckAll = new System.Windows.Forms.Button();
            _buttonRestoreBackup = new System.Windows.Forms.Button();
            _openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            _menuStrip1 = new System.Windows.Forms.MenuStrip();
            _fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _developerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _editModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _tableLayoutPanel.SuspendLayout();
            _tableLayoutPanel1.SuspendLayout();
            _flowLayoutPanel1.SuspendLayout();
            _menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelStatusBar
            // 
            _labelStatusBar.AutoSize = true;
            _labelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _tableLayoutPanel.SetColumnSpan(_labelStatusBar, 2);
            _labelStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            _labelStatusBar.Location = new System.Drawing.Point(3, 337);
            _labelStatusBar.Name = "_labelStatusBar";
            _labelStatusBar.Size = new System.Drawing.Size(568, 20);
            _labelStatusBar.TabIndex = 2;
            _labelStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            _tableLayoutPanel.ColumnCount = 2;
            _tableLayoutPanel.ColumnStyles.Add(
                                              new System.Windows.Forms.ColumnStyle(
                                                  System.Windows.Forms.SizeType.Percent,
                                                  50F));
            _tableLayoutPanel.ColumnStyles.Add(
                                              new System.Windows.Forms.ColumnStyle(
                                                  System.Windows.Forms.SizeType.Percent,
                                                  50F));
            _tableLayoutPanel.Controls.Add(_labelStatusBar, 0, 5);
            _tableLayoutPanel.Controls.Add(_tableLayoutPanel1, 0, 1);
            _tableLayoutPanel.Controls.Add(_checkedListMods, 0, 3);
            _tableLayoutPanel.Controls.Add(_buttonSaveTree, 1, 4);
            _tableLayoutPanel.Controls.Add(_flowLayoutPanel1, 0, 2);
            _tableLayoutPanel.Controls.Add(_buttonRestoreBackup, 0, 4);
            _tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            _tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            _tableLayoutPanel.Name = "_tableLayoutPanel";
            _tableLayoutPanel.RowCount = 6;
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Absolute,
                                               14F));
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Absolute,
                                               30F));
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Absolute,
                                               35F));
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Percent,
                                               100F));
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Absolute,
                                               38F));
            _tableLayoutPanel.RowStyles.Add(
                                           new System.Windows.Forms.RowStyle(
                                               System.Windows.Forms.SizeType.Absolute,
                                               20F));
            _tableLayoutPanel.Size = new System.Drawing.Size(574, 357);
            _tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            _tableLayoutPanel1.ColumnCount = 2;
            _tableLayoutPanel.SetColumnSpan(_tableLayoutPanel1, 2);
            _tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            _tableLayoutPanel1.ColumnStyles.Add(
                                               new System.Windows.Forms.ColumnStyle(
                                                   System.Windows.Forms.SizeType.Percent,
                                                   100F));
            _tableLayoutPanel1.Controls.Add(_labelTreeLoc, 0, 0);
            _tableLayoutPanel1.Controls.Add(_buttonTreeLoad, 1, 0);
            _tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _tableLayoutPanel1.Location = new System.Drawing.Point(0, 14);
            _tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            _tableLayoutPanel1.Name = "_tableLayoutPanel1";
            _tableLayoutPanel1.RowCount = 1;
            _tableLayoutPanel1.RowStyles.Add(
                                            new System.Windows.Forms.RowStyle(
                                                System.Windows.Forms.SizeType.Percent,
                                                100F));
            _tableLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            _tableLayoutPanel1.TabIndex = 3;
            _tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // labelTreeLoc
            // 
            _labelTreeLoc.AutoSize = true;
            _labelTreeLoc.Dock = System.Windows.Forms.DockStyle.Right;
            _labelTreeLoc.Location = new System.Drawing.Point(3, 0);
            _labelTreeLoc.Name = "_labelTreeLoc";
            _labelTreeLoc.Size = new System.Drawing.Size(99, 30);
            _labelTreeLoc.TabIndex = 0;
            _labelTreeLoc.Text = Resources.MainWindow_TreeLocation_Label;
            _labelTreeLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonTreeLoad
            // 
            _buttonTreeLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            _buttonTreeLoad.Location = new System.Drawing.Point(108, 3);
            _buttonTreeLoad.Name = "_buttonTreeLoad";
            _buttonTreeLoad.Size = new System.Drawing.Size(463, 24);
            _buttonTreeLoad.TabIndex = 1;
            _buttonTreeLoad.Text = Resources.MainWindow_TreeLocationBrowseButton_Text;
            _buttonTreeLoad.UseVisualStyleBackColor = true;
            _buttonTreeLoad.Click += ButtonTreeLoadClick;
            // 
            // checkedListMods
            // 
            _checkedListMods.CheckOnClick = true;
            _tableLayoutPanel.SetColumnSpan(_checkedListMods, 2);
            _checkedListMods.Dock = System.Windows.Forms.DockStyle.Fill;
            _checkedListMods.FormattingEnabled = true;
            _checkedListMods.Items.AddRange(
                                           new object[]
                                           {
                                               "item1",
                                               "item2"
                                           });
            _checkedListMods.Location = new System.Drawing.Point(10, 82);
            _checkedListMods.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            _checkedListMods.MultiColumn = true;
            _checkedListMods.Name = "_checkedListMods";
            _checkedListMods.Size = new System.Drawing.Size(554, 214);
            _checkedListMods.TabIndex = 4;
            // 
            // buttonSaveTree
            // 
            _buttonSaveTree.Dock = System.Windows.Forms.DockStyle.Right;
            _buttonSaveTree.Location = new System.Drawing.Point(409, 302);
            _buttonSaveTree.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            _buttonSaveTree.Name = "_buttonSaveTree";
            _buttonSaveTree.Size = new System.Drawing.Size(155, 32);
            _buttonSaveTree.TabIndex = 5;
            _buttonSaveTree.Text = Resources.MainWindow_UpdateTreeButton_Text;
            _buttonSaveTree.UseVisualStyleBackColor = true;
            _buttonSaveTree.Click += ButtonSaveTreeClick;
            // 
            // flowLayoutPanel1
            // 
            _flowLayoutPanel1.Controls.Add(_buttonCheckAll);
            _flowLayoutPanel1.Controls.Add(_buttonUncheckAll);
            _flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            _flowLayoutPanel1.Location = new System.Drawing.Point(10, 44);
            _flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            _flowLayoutPanel1.Name = "_flowLayoutPanel1";
            _flowLayoutPanel1.Size = new System.Drawing.Size(277, 35);
            _flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonCheckAll
            // 
            _buttonCheckAll.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _buttonCheckAll.Location = new System.Drawing.Point(3, 9);
            _buttonCheckAll.Name = "_buttonCheckAll";
            _buttonCheckAll.Size = new System.Drawing.Size(75, 23);
            _buttonCheckAll.TabIndex = 0;
            _buttonCheckAll.Text = Resources.MainWindow_CheckAllButton_Text;
            _buttonCheckAll.UseVisualStyleBackColor = true;
            _buttonCheckAll.Click += ButtonCheckAllClick;
            // 
            // buttonUncheckAll
            // 
            _buttonUncheckAll.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _buttonUncheckAll.Location = new System.Drawing.Point(84, 9);
            _buttonUncheckAll.Name = "_buttonUncheckAll";
            _buttonUncheckAll.Size = new System.Drawing.Size(75, 23);
            _buttonUncheckAll.TabIndex = 1;
            _buttonUncheckAll.Text = Resources.MainWindow_UncheckButtonAll_Text;
            _buttonUncheckAll.UseVisualStyleBackColor = true;
            _buttonUncheckAll.Click += ButtonUncheckAllClick;
            // 
            // buttonRestoreBackup
            // 
            _buttonRestoreBackup.Dock = System.Windows.Forms.DockStyle.Left;
            _buttonRestoreBackup.Location = new System.Drawing.Point(10, 302);
            _buttonRestoreBackup.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            _buttonRestoreBackup.Name = "_buttonRestoreBackup";
            _buttonRestoreBackup.Size = new System.Drawing.Size(151, 32);
            _buttonRestoreBackup.TabIndex = 7;
            _buttonRestoreBackup.Text = Resources.MainWindow_RestoreTreeButton_Text;
            _buttonRestoreBackup.UseVisualStyleBackColor = true;
            _buttonRestoreBackup.Click += ButtonRestoreBackupClick;
            // 
            // openFileDialog1
            // 
            _openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            _menuStrip1.Items.AddRange(
                                      new System.Windows.Forms.ToolStripItem[]
                                      {
                                          _fileToolStripMenuItem,
                                          _developerOptionsToolStripMenuItem,
                                          _helpToolStripMenuItem
                                      });
            _menuStrip1.Location = new System.Drawing.Point(0, 0);
            _menuStrip1.Name = "_menuStrip1";
            _menuStrip1.Size = new System.Drawing.Size(574, 24);
            _menuStrip1.TabIndex = 1;
            _menuStrip1.Text = Resources.MainWindow_MenuStrip_Text;
            // 
            // fileToolStripMenuItem
            // 
            _fileToolStripMenuItem.DropDownItems.AddRange(
                                                         new System.Windows.Forms.ToolStripItem[]
                                                         {
                                                             _closeToolStripMenuItem
                                                         });
            _fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            _fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            _fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            _fileToolStripMenuItem.Text = Resources.MainWindow_MenuItemFile_Text;
            // 
            // closeToolStripMenuItem
            // 
            _closeToolStripMenuItem.Name = "_closeToolStripMenuItem";
            _closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            _closeToolStripMenuItem.Text = Resources.MainWindow_MenuItemClose_Text;
            _closeToolStripMenuItem.Click += CloseToolStripMenuItemClick;
            // 
            // developerOptionsToolStripMenuItem
            // 
            _developerOptionsToolStripMenuItem.DropDownItems.AddRange(
                                                                     new System.Windows.Forms.ToolStripItem[]
                                                                     {
                                                                         _addModToolStripMenuItem,
                                                                         _editModToolStripMenuItem
                                                                     });
            _developerOptionsToolStripMenuItem.Name = "_developerOptionsToolStripMenuItem";
            _developerOptionsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            _developerOptionsToolStripMenuItem.Text = Resources.MainWindow_MenuItemDevOp_Text;
            // 
            // addModToolStripMenuItem
            // 
            _addModToolStripMenuItem.Name = "_addModToolStripMenuItem";
            _addModToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            _addModToolStripMenuItem.Text = Resources.MainWindow_MenuItemAddMod_Text;
            _addModToolStripMenuItem.Click += AddModToolStripMenuItemClick;
            // 
            // editModToolStripMenuItem
            // 
            _editModToolStripMenuItem.Name = "_editModToolStripMenuItem";
            _editModToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            _editModToolStripMenuItem.Text = Resources.MainWindow_MenuItemEditMod_Text;
            _editModToolStripMenuItem.Click += EditModToolStripMenuItemClick;
            // 
            // helpToolStripMenuItem
            // 
            _helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            _helpToolStripMenuItem.DropDownItems.AddRange(
                                                         new System.Windows.Forms.ToolStripItem[]
                                                         {
                                                             _aboutToolStripMenuItem
                                                         });
            _helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            _helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            _helpToolStripMenuItem.Text = Resources.MainWindow_MenuItemHelp_Text;
            // 
            // aboutToolStripMenuItem
            // 
            _aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            _aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            _aboutToolStripMenuItem.Text = Resources.MainWindow_MenuItemAbout_Text;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(574, 381);
            Controls.Add(_tableLayoutPanel);
            Controls.Add(_menuStrip1);
            Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            MainMenuStrip = _menuStrip1;
            Name = "MainWindow";
            Text = Resources.MainWindow_Title_Text;
            Load += MainWindowLoad;
            _tableLayoutPanel.ResumeLayout(false);
            _tableLayoutPanel.PerformLayout();
            _tableLayoutPanel1.ResumeLayout(false);
            _tableLayoutPanel1.PerformLayout();
            _flowLayoutPanel1.ResumeLayout(false);
            _menuStrip1.ResumeLayout(false);
            _menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label _labelStatusBar;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Label _labelTreeLoc;
        private System.Windows.Forms.Button _buttonTreeLoad;
        private System.Windows.Forms.CheckedListBox _checkedListMods;
        private System.Windows.Forms.OpenFileDialog _openFileDialog1;
        private System.Windows.Forms.Button _buttonSaveTree;
        private System.Windows.Forms.MenuStrip _menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _developerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _addModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _editModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel1;
        private System.Windows.Forms.Button _buttonCheckAll;
        private System.Windows.Forms.Button _buttonUncheckAll;
        private System.Windows.Forms.Button _buttonRestoreBackup;
    }
}
