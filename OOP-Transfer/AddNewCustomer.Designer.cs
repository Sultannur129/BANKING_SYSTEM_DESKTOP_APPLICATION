namespace OOP_Transfer
{
    partial class AddNewCustomer
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBoxBİRTHYEAR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLASTNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTCK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.textBoxBİRTHYEAR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLASTNAME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxTCK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 615);
            this.panel1.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(541, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(148, 47);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "KAYDET";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBoxBİRTHYEAR
            // 
            this.textBoxBİRTHYEAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBİRTHYEAR.Location = new System.Drawing.Point(247, 184);
            this.textBoxBİRTHYEAR.MaxLength = 4;
            this.textBoxBİRTHYEAR.Name = "textBoxBİRTHYEAR";
            this.textBoxBİRTHYEAR.Size = new System.Drawing.Size(247, 22);
            this.textBoxBİRTHYEAR.TabIndex = 11;
            this.textBoxBİRTHYEAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBİRTHYEAR_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(107, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "DOĞUM YILI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxLASTNAME
            // 
            this.textBoxLASTNAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLASTNAME.Location = new System.Drawing.Point(247, 137);
            this.textBoxLASTNAME.Name = "textBoxLASTNAME";
            this.textBoxLASTNAME.Size = new System.Drawing.Size(247, 22);
            this.textBoxLASTNAME.TabIndex = 9;
            this.textBoxLASTNAME.TextChanged += new System.EventHandler(this.textBoxLASTNAME_TextChanged);
            this.textBoxLASTNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLASTNAME_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(73, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "SOYADI GİRİNİZ:";
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNAME.Location = new System.Drawing.Point(247, 96);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(247, 22);
            this.textBoxNAME.TabIndex = 7;
            this.textBoxNAME.TextChanged += new System.EventHandler(this.textBoxNAME_TextChanged);
            this.textBoxNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNAME_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(112, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "ADI GİRİNİZ:";
            // 
            // textBoxTCK
            // 
            this.textBoxTCK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTCK.Location = new System.Drawing.Point(247, 44);
            this.textBoxTCK.MaxLength = 11;
            this.textBoxTCK.Name = "textBoxTCK";
            this.textBoxTCK.Size = new System.Drawing.Size(247, 22);
            this.textBoxTCK.TabIndex = 5;
            this.textBoxTCK.TextChanged += new System.EventHandler(this.textBoxTCK_TextChanged_1);
            this.textBoxTCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTCK_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "TC KİMLİK NUMARASI:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 304);
            this.dataGridView1.TabIndex = 10;
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(930, 567);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBoxBİRTHYEAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLASTNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}