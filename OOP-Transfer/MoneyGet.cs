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
    public partial class MoneyGet : Form
    {
        public MoneyGet()
        {
            InitializeComponent();
        }

        private void getMoneyButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            if (textAccountId.Text.Length == 17 && textAmountButton.Text.Length > 0) { 
            account.AccountId = textAccountId.Text;
            account.price = decimal.Parse(textAmountButton.Text.Replace(".", ","));

                switch (account.GetMoney())
                {
                    case 1:
                        MessageBox.Show("YETERSİZ BAKİYE");
                        break;
                    case 2:
                        MessageBox.Show("PARA ÇEKME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
                        break ;
                    case 3:
                        MessageBox.Show("KAPALI HESAPTAN PARA ÇEKME İŞLEMİ GERÇEKLEŞTİRİLMEZ.");
                        break; 
                        
                    default:
                        break;    
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

        private void textAmountButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
