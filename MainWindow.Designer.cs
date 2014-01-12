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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveTree = new System.Windows.Forms.Button();
            this.buttonDevMode = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.AutoSize = true;
            this.labelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel.SetColumnSpan(this.labelStatusBar, 2);
            this.labelStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusBar.Location = new System.Drawing.Point(3, 361);
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(568, 20);
            this.labelStatusBar.TabIndex = 2;
            this.labelStatusBar.Text = "Status Bar";
            this.labelStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelStatusBar, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.checkedListBox1, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonSaveTree, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.buttonDevMode, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(574, 381);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            this.tableLayoutPanel1.TabIndex = 3;
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
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.tableLayoutPanel.SetColumnSpan(this.checkedListBox1, 2);
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "item1",
            "item2",
            "asdf",
            "item1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1item1asdfitem1item1asdfitem1item1",
            "item2",
            "asdfasdfitem1item1asdfitem1item1asdfitem1item1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1asdfitem1",
            "item2",
            "asdfitem1",
            "item2",
            "asdfitem1",
            "asdf"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 93);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(554, 212);
            this.checkedListBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSaveTree
            // 
            this.buttonSaveTree.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveTree.Location = new System.Drawing.Point(409, 311);
            this.buttonSaveTree.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonSaveTree.Name = "buttonSaveTree";
            this.buttonSaveTree.Size = new System.Drawing.Size(155, 32);
            this.buttonSaveTree.TabIndex = 5;
            this.buttonSaveTree.Text = "Update Tree";
            this.buttonSaveTree.UseVisualStyleBackColor = true;
            // 
            // buttonDevMode
            // 
            this.buttonDevMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDevMode.Location = new System.Drawing.Point(496, 3);
            this.buttonDevMode.Name = "buttonDevMode";
            this.buttonDevMode.Size = new System.Drawing.Size(75, 20);
            this.buttonDevMode.TabIndex = 6;
            this.buttonDevMode.Text = "DevMode";
            this.buttonDevMode.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Tech Tree Config Tool v0.1";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStatusBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTreeLoc;
        private System.Windows.Forms.Button buttonTreeLoad;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveTree;
        private System.Windows.Forms.Button buttonDevMode;

    }
}

