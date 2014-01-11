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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.ListView();
            this.labelStatusBar = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.buttonRun, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataList);
            this.tableLayoutPanel.Controls.Add(this.labelStatusBar, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(573, 378);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRun.Location = new System.Drawing.Point(3, 328);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(567, 27);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.Button1Click);
            // 
            // dataList
            // 
            this.dataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dataList.Location = new System.Drawing.Point(3, 3);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(567, 319);
            this.dataList.TabIndex = 1;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.View = System.Windows.Forms.View.List;
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.AutoSize = true;
            this.labelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusBar.Location = new System.Drawing.Point(3, 358);
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(567, 20);
            this.labelStatusBar.TabIndex = 2;
            this.labelStatusBar.Text = "Status Bar";
            this.labelStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Tech Tree Config Tool v0.1";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.Label labelStatusBar;
    }
}

