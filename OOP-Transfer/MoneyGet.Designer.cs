namespace OOP_Transfer
{
    partial class MoneyGet
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
            this.getMoneyButton = new System.Windows.Forms.Button();
            this.textAmountButton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAccountId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.getMoneyButton);
            this.panel1.Controls.Add(this.textAmountButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textAccountId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 439);
            this.panel1.TabIndex = 0;
            // 
            // getMoneyButton
            // 
            this.getMoneyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getMoneyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getMoneyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getMoneyButton.Location = new System.Drawing.Point(92, 237);
            this.getMoneyButton.Name = "getMoneyButton";
            this.getMoneyButton.Size = new System.Drawing.Size(131, 54);
            this.getMoneyButton.TabIndex = 4;
            this.getMoneyButton.Text = "PARA ÇEK";
            this.getMoneyButton.UseVisualStyleBackColor = false;
            this.getMoneyButton.Click += new System.EventHandler(this.getMoneyButton_Click);
            // 
            // textAmountButton
            // 
            this.textAmountButton.Location = new System.Drawing.Point(284, 174);
            this.textAmountButton.Name = "textAmountButton";
            this.textAmountButton.Size = new System.Drawing.Size(250, 22);
            this.textAmountButton.TabIndex = 3;
            this.textAmountButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmountButton_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(101, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "TUTAR GİRİNİZ:";
            // 
            // textAccountId
            // 
            this.textAccountId.Location = new System.Drawing.Point(284, 104);
            this.textAccountId.MaxLength = 17;
            this.textAccountId.Name = "textAccountId";
            this.textAccountId.Size = new System.Drawing.Size(250, 22);
            this.textAccountId.TabIndex = 1;
            this.textAccountId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAccountId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP ID GİRİNİZ:";
            // 
            // MoneyGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.panel1);
            this.Name = "MoneyGet";
            this.Text = "MoneyGet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button getMoneyButton;
        private System.Windows.Forms.TextBox textAmountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAccountId;
        private System.Windows.Forms.Label label1;
    }
}