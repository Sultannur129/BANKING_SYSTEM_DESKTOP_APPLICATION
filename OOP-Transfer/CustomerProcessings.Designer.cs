namespace OOP_Transfer
{
    partial class CustomerProcessings
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
            this.ShowCustomerInfoButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowCustomerInfoButton
            // 
            this.ShowCustomerInfoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowCustomerInfoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowCustomerInfoButton.Location = new System.Drawing.Point(500, 193);
            this.ShowCustomerInfoButton.Name = "ShowCustomerInfoButton";
            this.ShowCustomerInfoButton.Size = new System.Drawing.Size(266, 193);
            this.ShowCustomerInfoButton.TabIndex = 1;
            this.ShowCustomerInfoButton.Text = "MÜŞTERİ BİLGİLERİNİ GÖRÜNTÜLE";
            this.ShowCustomerInfoButton.UseVisualStyleBackColor = false;
            this.ShowCustomerInfoButton.Click += new System.EventHandler(this.ShowCustomerInfoButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewCustomerButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewCustomerButton.Location = new System.Drawing.Point(105, 193);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(270, 193);
            this.NewCustomerButton.TabIndex = 0;
            this.NewCustomerButton.Text = "MÜŞTERİ OLUŞTUR";
            this.NewCustomerButton.UseVisualStyleBackColor = false;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // CustomerProcessings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(912, 570);
            this.Controls.Add(this.ShowCustomerInfoButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Name = "CustomerProcessings";
            this.Text = "CustomerProcessings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button ShowCustomerInfoButton;
    }
}