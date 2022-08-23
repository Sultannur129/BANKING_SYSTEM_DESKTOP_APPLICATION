namespace OOP_Transfer
{
    partial class AccountProcessings
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
            this.ShowAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NewAccountOpen = new System.Windows.Forms.Button();
            this.AddMoneyButton = new System.Windows.Forms.Button();
            this.GetMoneyButton = new System.Windows.Forms.Button();
            this.AccountOpenButton = new System.Windows.Forms.Button();
            this.SendMoneyAnotherAccountButton = new System.Windows.Forms.Button();
            this.CloseAccountButton = new System.Windows.Forms.Button();
            this.ShowPastAccounts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ShowAccountButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCustomerId);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 119);
            this.panel1.TabIndex = 0;
            // 
            // ShowAccountButton
            // 
            this.ShowAccountButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowAccountButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowAccountButton.Location = new System.Drawing.Point(364, 12);
            this.ShowAccountButton.Name = "ShowAccountButton";
            this.ShowAccountButton.Size = new System.Drawing.Size(177, 55);
            this.ShowAccountButton.TabIndex = 2;
            this.ShowAccountButton.Text = "HESAPLARI GÖSTER";
            this.ShowAccountButton.UseVisualStyleBackColor = false;
            this.ShowAccountButton.Click += new System.EventHandler(this.ShowAccountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ ID:";
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(133, 27);
            this.textCustomerId.MaxLength = 12;
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.Size = new System.Drawing.Size(212, 22);
            this.textCustomerId.TabIndex = 1;
            this.textCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustomerId_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 316);
            this.dataGridView1.TabIndex = 2;
            // 
            // NewAccountOpen
            // 
            this.NewAccountOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewAccountOpen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewAccountOpen.Location = new System.Drawing.Point(10, 406);
            this.NewAccountOpen.Name = "NewAccountOpen";
            this.NewAccountOpen.Size = new System.Drawing.Size(155, 63);
            this.NewAccountOpen.TabIndex = 3;
            this.NewAccountOpen.Text = "YENİ HESAP AÇ";
            this.NewAccountOpen.UseVisualStyleBackColor = false;
            this.NewAccountOpen.Click += new System.EventHandler(this.NewAccountOpen_Click);
            // 
            // AddMoneyButton
            // 
            this.AddMoneyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMoneyButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddMoneyButton.Location = new System.Drawing.Point(191, 406);
            this.AddMoneyButton.Name = "AddMoneyButton";
            this.AddMoneyButton.Size = new System.Drawing.Size(149, 63);
            this.AddMoneyButton.TabIndex = 4;
            this.AddMoneyButton.Text = "PARA YATIR";
            this.AddMoneyButton.UseVisualStyleBackColor = false;
            this.AddMoneyButton.Click += new System.EventHandler(this.AddMoneyButton_Click);
            // 
            // GetMoneyButton
            // 
            this.GetMoneyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetMoneyButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GetMoneyButton.Location = new System.Drawing.Point(364, 406);
            this.GetMoneyButton.Name = "GetMoneyButton";
            this.GetMoneyButton.Size = new System.Drawing.Size(151, 63);
            this.GetMoneyButton.TabIndex = 5;
            this.GetMoneyButton.Text = "PARA ÇEKME";
            this.GetMoneyButton.UseVisualStyleBackColor = false;
            this.GetMoneyButton.Click += new System.EventHandler(this.GetMoneyButton_Click);
            // 
            // AccountOpenButton
            // 
            this.AccountOpenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountOpenButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccountOpenButton.Location = new System.Drawing.Point(713, 406);
            this.AccountOpenButton.Name = "AccountOpenButton";
            this.AccountOpenButton.Size = new System.Drawing.Size(148, 63);
            this.AccountOpenButton.TabIndex = 6;
            this.AccountOpenButton.Text = "HESAP AÇMA";
            this.AccountOpenButton.UseVisualStyleBackColor = false;
            this.AccountOpenButton.Click += new System.EventHandler(this.AccountOpenButton_Click);
            // 
            // SendMoneyAnotherAccountButton
            // 
            this.SendMoneyAnotherAccountButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendMoneyAnotherAccountButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendMoneyAnotherAccountButton.Location = new System.Drawing.Point(541, 406);
            this.SendMoneyAnotherAccountButton.Name = "SendMoneyAnotherAccountButton";
            this.SendMoneyAnotherAccountButton.Size = new System.Drawing.Size(146, 63);
            this.SendMoneyAnotherAccountButton.TabIndex = 7;
            this.SendMoneyAnotherAccountButton.Text = "HAVALE";
            this.SendMoneyAnotherAccountButton.UseVisualStyleBackColor = false;
            this.SendMoneyAnotherAccountButton.Click += new System.EventHandler(this.SendMoneyAnotherAccountButton_Click);
            // 
            // CloseAccountButton
            // 
            this.CloseAccountButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseAccountButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseAccountButton.Location = new System.Drawing.Point(885, 406);
            this.CloseAccountButton.Name = "CloseAccountButton";
            this.CloseAccountButton.Size = new System.Drawing.Size(145, 63);
            this.CloseAccountButton.TabIndex = 8;
            this.CloseAccountButton.Text = "HESAP KAPATMA";
            this.CloseAccountButton.UseVisualStyleBackColor = false;
            this.CloseAccountButton.Click += new System.EventHandler(this.CloseAccountButton_Click);
            // 
            // ShowPastAccounts
            // 
            this.ShowPastAccounts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowPastAccounts.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowPastAccounts.Location = new System.Drawing.Point(1052, 406);
            this.ShowPastAccounts.Name = "ShowPastAccounts";
            this.ShowPastAccounts.Size = new System.Drawing.Size(133, 63);
            this.ShowPastAccounts.TabIndex = 9;
            this.ShowPastAccounts.Text = "HESAP ÖZETLERİ";
            this.ShowPastAccounts.UseVisualStyleBackColor = false;
            this.ShowPastAccounts.Click += new System.EventHandler(this.ShowPastAccounts_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 99);
            this.panel2.TabIndex = 10;
            // 
            // AccountProcessings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1194, 495);
            this.Controls.Add(this.ShowPastAccounts);
            this.Controls.Add(this.CloseAccountButton);
            this.Controls.Add(this.SendMoneyAnotherAccountButton);
            this.Controls.Add(this.AccountOpenButton);
            this.Controls.Add(this.GetMoneyButton);
            this.Controls.Add(this.AddMoneyButton);
            this.Controls.Add(this.NewAccountOpen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AccountProcessings";
            this.Text = "AccountProcessings";
            this.Load += new System.EventHandler(this.AccountProcessings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowAccountButton;
        private System.Windows.Forms.TextBox textCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NewAccountOpen;
        private System.Windows.Forms.Button AddMoneyButton;
        private System.Windows.Forms.Button GetMoneyButton;
        private System.Windows.Forms.Button AccountOpenButton;
        private System.Windows.Forms.Button SendMoneyAnotherAccountButton;
        private System.Windows.Forms.Button CloseAccountButton;
        private System.Windows.Forms.Button ShowPastAccounts;
        private System.Windows.Forms.Panel panel2;
    }
}