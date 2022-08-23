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
    public partial class SendMoneyToAnotherAccount : Form
    {
        public SendMoneyToAnotherAccount()
        {
            InitializeComponent();
        }

        private void SendMoneyAnotherbutton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            if(textSelectedAccount.Text.Length==17 && textSendAccount.Text.Length==17 && textAmount.Text.Length > 0)
            {
                account.AccountId = textSelectedAccount.Text;
                account.SendAccountId= textSendAccount.Text;
                account.price=decimal.Parse(textAmount.Text.Replace(".", ","));

                switch (account.Transfer())
                {
                    case 1:
                        MessageBox.Show("YETERSİZ BAKİYE.LÜTFEN TEKRAR TUTAR GİRİŞİ YAPINIZ.");
                        break;
                    case 2:
                        MessageBox.Show("HAVALE İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
                        break;
                    default:
                        MessageBox.Show("KAPALI HESABA HAVALE İŞLEMİ GERÇEKLEŞTİRİLEMEZ.");
                        break;
                }


            }
            else
            {
                MessageBox.Show("LÜTFEN HESAP BİLGİLERİN HEPSİNİ GİRİNİZ.");
            }


        }

        private void textSelectedAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textSendAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
