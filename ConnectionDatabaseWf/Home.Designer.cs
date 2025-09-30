namespace ConnectionDatabaseWf
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLySachMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDocGiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTacGiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySachMenuItem,
            this.quanLyDocGiaMenuItem,
            this.quanLyTacGiaMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLySachMenuItem
            // 
            this.quanLySachMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLySachMenuItem.Name = "quanLySachMenuItem";
            this.quanLySachMenuItem.Size = new System.Drawing.Size(100, 23);
            this.quanLySachMenuItem.Text = "Quản lý sách";
            this.quanLySachMenuItem.Click += new System.EventHandler(this.quanLySachMenuItem_Click);
            // 
            // quanLyDocGiaMenuItem
            // 
            this.quanLyDocGiaMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLyDocGiaMenuItem.Name = "quanLyDocGiaMenuItem";
            this.quanLyDocGiaMenuItem.Size = new System.Drawing.Size(117, 23);
            this.quanLyDocGiaMenuItem.Text = "Quản lý độc giả";
            this.quanLyDocGiaMenuItem.Click += new System.EventHandler(this.quanLyDocGiaMenuItem_Click);
            // 
            // quanLyTacGiaMenuItem
            // 
            this.quanLyTacGiaMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLyTacGiaMenuItem.Name = "quanLyTacGiaMenuItem";
            this.quanLyTacGiaMenuItem.Size = new System.Drawing.Size(113, 23);
            this.quanLyTacGiaMenuItem.Text = "Quản lý tác giả";
            this.quanLyTacGiaMenuItem.Click += new System.EventHandler(this.quanLyTacGiaMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(0, 27);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 450);
            this.panelContent.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLySachMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDocGiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTacGiaMenuItem;
        private System.Windows.Forms.Panel panelContent;
    }
}

