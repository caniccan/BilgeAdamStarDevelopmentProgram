
namespace Intro02.WinApp
{
    partial class Form1
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonuclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.sonuclarToolStripMenuItem,
            this.verilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1566, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.acToolStripMenuItem.Text = "AÇ";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // sonuclarToolStripMenuItem
            // 
            this.sonuclarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem1});
            this.sonuclarToolStripMenuItem.Name = "sonuclarToolStripMenuItem";
            this.sonuclarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.sonuclarToolStripMenuItem.Text = "Sonuclar";
            this.sonuclarToolStripMenuItem.Click += new System.EventHandler(this.sonuclarToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem1
            // 
            this.acToolStripMenuItem1.Name = "acToolStripMenuItem1";
            this.acToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.acToolStripMenuItem1.Text = "Ac";
            // 
            // verilerToolStripMenuItem
            // 
            this.verilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem2});
            this.verilerToolStripMenuItem.Name = "verilerToolStripMenuItem";
            this.verilerToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.verilerToolStripMenuItem.Text = "Veriler";
            // 
            // acToolStripMenuItem2
            // 
            this.acToolStripMenuItem2.Name = "acToolStripMenuItem2";
            this.acToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.acToolStripMenuItem2.Text = "ac";
            this.acToolStripMenuItem2.Click += new System.EventHandler(this.acToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 767);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonuclarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem2;
    }
}

