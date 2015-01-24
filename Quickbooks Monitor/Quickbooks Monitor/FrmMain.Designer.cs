namespace Quickbooks_Monitor
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbQBFiles = new System.Windows.Forms.RichTextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenOKToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redDoNotUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQBFiles
            // 
            this.tbQBFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQBFiles.DetectUrls = false;
            this.tbQBFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQBFiles.Location = new System.Drawing.Point(12, 45);
            this.tbQBFiles.Name = "tbQBFiles";
            this.tbQBFiles.ReadOnly = true;
            this.tbQBFiles.Size = new System.Drawing.Size(465, 280);
            this.tbQBFiles.TabIndex = 0;
            this.tbQBFiles.TabStop = false;
            this.tbQBFiles.Text = "";
            this.tbQBFiles.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.tbQBFiles_LinkClicked);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "It will continue to run in the background";
            this.trayIcon.BalloonTipTitle = "QuickBooks Monitor";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "QuickBooks Monitor";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Enabled = false;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem6.Text = "© 2015 Forrest Jones";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenOKToUseToolStripMenuItem,
            this.redDoNotUseToolStripMenuItem,
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // greenOKToUseToolStripMenuItem
            // 
            this.greenOKToUseToolStripMenuItem.Enabled = false;
            this.greenOKToUseToolStripMenuItem.Name = "greenOKToUseToolStripMenuItem";
            this.greenOKToUseToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.greenOKToUseToolStripMenuItem.Text = "Green - OK to use";
            // 
            // redDoNotUseToolStripMenuItem
            // 
            this.redDoNotUseToolStripMenuItem.Enabled = false;
            this.redDoNotUseToolStripMenuItem.Name = "redDoNotUseToolStripMenuItem";
            this.redDoNotUseToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.redDoNotUseToolStripMenuItem.Text = "Red - Do not use";
            // 
            // blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem
            // 
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem.Enabled = false;
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem.Name = "blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem";
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem.Text = "Black - No QuickBooks files found in that folder";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(12, 342);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(74, 13);
            this.lblUpdated.TabIndex = 2;
            this.lblUpdated.Text = "Last Updated:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(389, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Now";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 375);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.tbQBFiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBooks Monitor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbQBFiles;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenOKToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redDoNotUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackNoQuickBooksFilesFoundInThatFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}