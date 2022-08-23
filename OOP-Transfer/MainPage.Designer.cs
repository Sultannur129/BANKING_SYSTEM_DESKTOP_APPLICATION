namespace OOP_Transfer
{
    partial class MainPage
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
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMusteriOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriniGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.hesapİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMusteriOlustur,
            this.müşteriBilgileriniGösterToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // mnMusteriOlustur
            // 
            this.mnMusteriOlustur.Name = "mnMusteriOlustur";
            this.mnMusteriOlustur.Size = new System.Drawing.Size(255, 26);
            this.mnMusteriOlustur.Text = "Müşteri Oluştur";
            this.mnMusteriOlustur.Click += new System.EventHandler(this.mnMusteriOlustur_Click_1);
            // 
            // müşteriBilgileriniGösterToolStripMenuItem
            // 
            this.müşteriBilgileriniGösterToolStripMenuItem.Name = "müşteriBilgileriniGösterToolStripMenuItem";
            this.müşteriBilgileriniGösterToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.müşteriBilgileriniGösterToolStripMenuItem.Text = "Müşteri Bilgilerini Göster";
            this.müşteriBilgileriniGösterToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriniGösterToolStripMenuItem_Click);
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem1});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap ";
            this.hesapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hesapİşlemleriToolStripMenuItem_Click);
            // 
            // hesapİşlemleriToolStripMenuItem1
            // 
            this.hesapİşlemleriToolStripMenuItem1.Name = "hesapİşlemleriToolStripMenuItem1";
            this.hesapİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.hesapİşlemleriToolStripMenuItem1.Text = "Hesap İşlemleri";
            this.hesapİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.hesapİşlemleriToolStripMenuItem1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(918, 548);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnMusteriOlustur;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriniGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem1;
    }
}

