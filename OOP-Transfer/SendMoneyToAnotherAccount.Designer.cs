namespace OOP_Transfer
{
    partial class SendMoneyToAnotherAccount
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
            this.SendMoneyAnotherbutton = new System.Windows.Forms.Button();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSendAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSelectedAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.SendMoneyAnotherbutton);
            this.panel1.Controls.Add(this.textAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textSendAccount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSelectedAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 537);
            this.panel1.TabIndex = 0;
            // 
            // SendMoneyAnotherbutton
            // 
            this.SendMoneyAnotherbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendMoneyAnotherbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendMoneyAnotherbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendMoneyAnotherbutton.Location = new System.Drawing.Point(114, 384);
            this.SendMoneyAnotherbutton.Name = "SendMoneyAnotherbutton";
            this.SendMoneyAnotherbutton.Size = new System.Drawing.Size(148, 68);
            this.SendMoneyAnotherbutton.TabIndex = 6;
            this.SendMoneyAnotherbutton.Text = "HAVALE YAP";
            this.SendMoneyAnotherbutton.UseVisualStyleBackColor = false;
            this.SendMoneyAnotherbutton.Click += new System.EventHandler(this.SendMoneyAnotherbutton_Click);
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(447, 308);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(224, 22);
            this.textAmount.TabIndex = 5;
            this.textAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(237, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "TUTAR GİRİNİZ:";
            // 
            // textSendAccount
            // 
            this.textSendAccount.Location = new System.Drawing.Point(447, 211);
            this.textSendAccount.MaxLength = 17;
            this.textSendAccount.Name = "textSendAccount";
            this.textSendAccount.Size = new System.Drawing.Size(224, 22);
            this.textSendAccount.TabIndex = 3;
            this.textSendAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSendAccount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "GÖNDERİLECEK HESAP ID GİRİNİZ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textSelectedAccount
            // 
            this.textSelectedAccount.Location = new System.Drawing.Point(447, 107);
            this.textSelectedAccount.MaxLength = 17;
            this.textSelectedAccount.Name = "textSelectedAccount";
            this.textSelectedAccount.Size = new System.Drawing.Size(224, 22);
            this.textSelectedAccount.TabIndex = 1;
            this.textSelectedAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSelectedAccount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(157, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP ID NİZİ GİRİNİZ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SendMoneyToAnotherAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(960, 537);
            this.Controls.Add(this.panel1);
            this.Name = "SendMoneyToAnotherAccount";
            this.Text = "SendMoneyToAnotherAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SendMoneyAnotherbutton;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSendAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSelectedAccount;
        private System.Windows.Forms.Label label1;
    }
}