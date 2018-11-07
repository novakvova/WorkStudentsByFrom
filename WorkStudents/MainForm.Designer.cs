namespace WorkStudents
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
            this.components = new System.ComponentModel.Container();
            this.menuHeader = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serviceDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateDB = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHeader
            // 
            this.menuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.serviceDatabaseToolStripMenuItem});
            this.menuHeader.Location = new System.Drawing.Point(0, 0);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(606, 24);
            this.menuHeader.TabIndex = 0;
            this.menuHeader.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // serviceDatabaseToolStripMenuItem
            // 
            this.serviceDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateDB});
            this.serviceDatabaseToolStripMenuItem.Name = "serviceDatabaseToolStripMenuItem";
            this.serviceDatabaseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.serviceDatabaseToolStripMenuItem.Text = "Керування БД";
            // 
            // menuCreateDB
            // 
            this.menuCreateDB.Name = "menuCreateDB";
            this.menuCreateDB.Size = new System.Drawing.Size(180, 22);
            this.menuCreateDB.Text = "Створити БД";
            this.menuCreateDB.Click += new System.EventHandler(this.menuCreateDB_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGroups});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.adminToolStripMenuItem.Text = "Адміністрування";
            // 
            // menuGroups
            // 
            this.menuGroups.Name = "menuGroups";
            this.menuGroups.Size = new System.Drawing.Size(180, 22);
            this.menuGroups.Text = "Групи";
            this.menuGroups.Click += new System.EventHandler(this.menuGroups_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 336);
            this.Controls.Add(this.menuHeader);
            this.MainMenuStrip = this.menuHeader;
            this.Name = "MainForm";
            this.Text = "Робота із студентами";
            this.menuHeader.ResumeLayout(false);
            this.menuHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHeader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviceDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreateDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGroups;
    }
}

