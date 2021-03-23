namespace ByteDev.FilmLister.WindowsUi
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daviLineMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFoldersButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(13, 77);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(661, 544);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.WordWrap = false;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(13, 37);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(503, 26);
            this.pathTextBox.TabIndex = 0;
            this.pathTextBox.Text = "C:\\";
            this.pathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pathTextBox_KeyPress);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.aboutMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(686, 35);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderMenuItem,
            this.refreshFolderMenuItem,
            this.clearFolderMenuItem,
            this.daviLineMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileMenuItem.Text = "File";
            // 
            // openFolderMenuItem
            // 
            this.openFolderMenuItem.Name = "openFolderMenuItem";
            this.openFolderMenuItem.Size = new System.Drawing.Size(213, 34);
            this.openFolderMenuItem.Text = "Open Folder";
            this.openFolderMenuItem.Click += new System.EventHandler(this.openFolderMenuItem_Click);
            // 
            // refreshFolderMenuItem
            // 
            this.refreshFolderMenuItem.Name = "refreshFolderMenuItem";
            this.refreshFolderMenuItem.Size = new System.Drawing.Size(213, 34);
            this.refreshFolderMenuItem.Text = "Refresh";
            this.refreshFolderMenuItem.Click += new System.EventHandler(this.refreshFolderMenuItem_Click);
            // 
            // clearFolderMenuItem
            // 
            this.clearFolderMenuItem.Name = "clearFolderMenuItem";
            this.clearFolderMenuItem.Size = new System.Drawing.Size(213, 34);
            this.clearFolderMenuItem.Text = "Clear";
            this.clearFolderMenuItem.Click += new System.EventHandler(this.clearFolderMenuItem_Click);
            // 
            // daviLineMenuItem
            // 
            this.daviLineMenuItem.Name = "daviLineMenuItem";
            this.daviLineMenuItem.Size = new System.Drawing.Size(210, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(213, 34);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editMenuItem.Text = "Edit";
            // 
            // copyAllMenuItem
            // 
            this.copyAllMenuItem.Name = "copyAllMenuItem";
            this.copyAllMenuItem.Size = new System.Drawing.Size(181, 34);
            this.copyAllMenuItem.Text = "Copy All";
            this.copyAllMenuItem.Click += new System.EventHandler(this.copyAllMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // createFoldersButton
            // 
            this.createFoldersButton.Location = new System.Drawing.Point(523, 35);
            this.createFoldersButton.Name = "createFoldersButton";
            this.createFoldersButton.Size = new System.Drawing.Size(151, 34);
            this.createFoldersButton.TabIndex = 4;
            this.createFoldersButton.Text = "Create Folders";
            this.createFoldersButton.UseVisualStyleBackColor = true;
            this.createFoldersButton.Click += new System.EventHandler(this.createFoldersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(686, 635);
            this.Controls.Add(this.createFoldersButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFolderMenuItem;
		private System.Windows.Forms.ToolStripSeparator daviLineMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllMenuItem;
        private System.Windows.Forms.Button createFoldersButton;
    }
}

