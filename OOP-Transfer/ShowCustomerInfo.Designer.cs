namespace OOP_Transfer
{
    partial class ShowCustomerInfo
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
            this.ShowCustomerInformations = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAccountId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTCKN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ShowCustomerInformations);
            this.panel1.Controls.Add(this.textDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBalance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textAccountId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textTCKN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textCustomerSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCustomerId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 610);
            this.panel1.TabIndex = 0;
            // 
            // ShowCustomerInformations
            // 
            this.ShowCustomerInformations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowCustomerInformations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowCustomerInformations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowCustomerInformations.ForeColor = System.Drawing.Color.Black;
            this.ShowCustomerInformations.Location = new System.Drawing.Point(545, 23);
            this.ShowCustomerInformations.Name = "ShowCustomerInformations";
            this.ShowCustomerInformations.Size = new System.Drawing.Size(159, 82);
            this.ShowCustomerInformations.TabIndex = 16;
            this.ShowCustomerInformations.Text = "HESAPLARI VE BİLGİLERİ GÖRÜNTÜLE";
            this.ShowCustomerInformations.UseVisualStyleBackColor = false;
            this.ShowCustomerInformations.Click += new System.EventHandler(this.ShowCustomerInformations_Click);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(237, 371);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(193, 22);
            this.textDate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(160, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "TARİH:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(237, 317);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(193, 22);
            this.textBalance.TabIndex = 13;
            this.textBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBalance_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(148, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "BAKİYE:";
            // 
            // textAccountId
            // 
            this.textAccountId.Location = new System.Drawing.Point(237, 257);
            this.textAccountId.MaxLength = 17;
            this.textAccountId.Name = "textAccountId";
            this.textAccountId.Size = new System.Drawing.Size(193, 22);
            this.textAccountId.TabIndex = 9;
            this.textAccountId.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textAccountId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAccountId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(129, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "HESAP ID:";
            // 
            // textTCKN
            // 
            this.textTCKN.Location = new System.Drawing.Point(237, 82);
            this.textTCKN.MaxLength = 11;
            this.textTCKN.Name = "textTCKN";
            this.textTCKN.Size = new System.Drawing.Size(193, 22);
            this.textTCKN.TabIndex = 7;
            this.textTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTCKN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC KİMLİK NUMARASI:";
            // 
            // textCustomerSurname
            // 
            this.textCustomerSurname.Location = new System.Drawing.Point(237, 199);
            this.textCustomerSurname.Name = "textCustomerSurname";
            this.textCustomerSurname.Size = new System.Drawing.Size(193, 22);
            this.textCustomerSurname.TabIndex = 5;
            this.textCustomerSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustomerSurname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "MÜŞTERİ SOYADI:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(237, 137);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(193, 22);
            this.textCustomerName.TabIndex = 3;
            this.textCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustomerName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(97, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÜŞTERİ ADI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜŞTERİ ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(237, 27);
            this.textCustomerId.MaxLength = 12;
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.Size = new System.Drawing.Size(193, 22);
            this.textCustomerId.TabIndex = 0;
            this.textCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustomerId_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 470);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ShowCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1013, 610);
            this.Controls.Add(this.panel1);
            this.Name = "ShowCustomerInfo";
            this.Text = "ShowCustomerInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAccountId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTCKN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCustomerSurname;
        private System.Windows.Forms.Button ShowCustomerInformations;
        private System.Windows.Forms.TextBox textDate;
    }
}