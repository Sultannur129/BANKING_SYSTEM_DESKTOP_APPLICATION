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
    public partial class AccountClose : Form
    {
        public AccountClose()
        {
            InitializeComponent();
        }

        private void AccountCloseButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            if (textAccountId.Text.Length == 17)
            {
                account.AccountId = textAccountId.Text;
                switch (account.AccountClose())
                {
                    case 1:
                        MessageBox.Show("HESAP KAPATMA İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
                        break;
                    case 2:
                        MessageBox.Show("HESABI KAPATMAK İÇİN BAKİYENİZDEKİ TÜM PARANIZI ÇEKİNİZ.");
                        break ;
                    case 3:
                        MessageBox.Show("KAPALI BİR HESABI TEKRAR KAPATAMAZSINIZ.");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN HESAP NUMARASI GİRİNİZ.");
            }
        }

        private void textAccountId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
