namespace OOP_Transfer
{
    partial class AccountClose
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountCloseButton = new System.Windows.Forms.Button();
            this.textAccountId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.AccountCloseButton);
            this.panel1.Controls.Add(this.textAccountId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 397);
            this.panel1.TabIndex = 0;
            // 
            // AccountCloseButton
            // 
            this.AccountCloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountCloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccountCloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountCloseButton.Location = new System.Drawing.Point(376, 99);
            this.AccountCloseButton.Name = "AccountCloseButton";
            this.AccountCloseButton.Size = new System.Drawing.Size(121, 63);
            this.AccountCloseButton.TabIndex = 2;
            this.AccountCloseButton.Text = "HESABI KAPAT";
            this.AccountCloseButton.UseVisualStyleBackColor = false;
            this.AccountCloseButton.Click += new System.EventHandler(this.AccountCloseButton_Click);
            // 
            // textAccountId
            // 
            this.textAccountId.Location = new System.Drawing.Point(78, 140);
            this.textAccountId.MaxLength = 17;
            this.textAccountId.Name = "textAccountId";
            this.textAccountId.Size = new System.Drawing.Size(236, 22);
            this.textAccountId.TabIndex = 1;
            this.textAccountId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAccountId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(73, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP ID GİRİNİZ:";
            // 
            // AccountClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(794, 397);
            this.Controls.Add(this.panel1);
            this.Name = "AccountClose";
            this.Text = "AccountClose";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AccountCloseButton;
        private System.Windows.Forms.TextBox textAccountId;
        private System.Windows.Forms.Label label1;
    }
}