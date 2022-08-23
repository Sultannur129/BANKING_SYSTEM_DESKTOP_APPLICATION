using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Transfer
{
    public partial class AddMoney : Form
    {
        public AddMoney()
        {
            InitializeComponent();
        }

        public string CustomerId { get; set; }

        private void SendMoneyButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            if (textAccountId.Text.Length == 17 && textAmount.Text.Length > 0)
            {
                account.AccountId = textAccountId.Text;
                account.price = decimal.Parse(textAmount.Text.Replace(".", ","));

                if (account.AddMoney(account))
                {
                    MessageBox.Show("PARA YATIRMA İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");


                }
                else
                {
                    MessageBox.Show("KAPALI BİR HESABA PARA YATIRMA İŞLEMİ GERÇEKLEŞTİREMEZSİNİZ.");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN HESAP ID VEYA TUTARI GİRDİĞİNİZİ KONTROL EDİNİZ.");
            }

        }

        private void textAccountId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
