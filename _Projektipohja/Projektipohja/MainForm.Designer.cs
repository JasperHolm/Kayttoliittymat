namespace Projektipohja
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(284, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuNew,
            this.toolStripMenuOpen,
            this.toolStripSeparator2,
            this.toolStripMenuSave,
            this.toolStripMenuSaveAs,
            this.toolStripSeparator3,
            this.MenuFileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripMenuNew
            // 
            this.toolStripMenuNew.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.toolStripMenuNew.Name = "toolStripMenuNew";
            this.toolStripMenuNew.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuNew.Text = "New...";
            this.toolStripMenuNew.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuOpen
            // 
            this.toolStripMenuOpen.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.toolStripMenuOpen.Name = "toolStripMenuOpen";
            this.toolStripMenuOpen.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuOpen.Text = "Open...";
            this.toolStripMenuOpen.Click += new System.EventHandler(this.toolStripMenuOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuSave.Text = "Save";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // toolStripMenuSaveAs
            // 
            this.toolStripMenuSaveAs.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.toolStripMenuSaveAs.Name = "toolStripMenuSaveAs";
            this.toolStripMenuSaveAs.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuSaveAs.Text = "Save As...";
            this.toolStripMenuSaveAs.Click += new System.EventHandler(this.toolStripMenuSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(123, 22);
            this.MenuFileExit.Text = "&Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 237);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Pääformi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

