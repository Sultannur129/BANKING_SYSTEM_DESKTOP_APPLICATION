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
    public partial class AccountOpen : Form
    {
        public AccountOpen()
        {
            InitializeComponent();
        }

        private void AccountOpenButton_Click(object sender, EventArgs e)
        { 
            Account account = new Account();
            if (textAccountId.Text.Length == 17)
            {
                account.AccountId = textAccountId.Text;
                if (account.AccountOpen())
                {
                    MessageBox.Show("HESAP BAŞARIYLA AÇILMIŞTIR.");
                }
                else
                {
                    MessageBox.Show("AÇIK OLAN BİR HESABI TEKRAR AÇAMAZSINIZ.");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN MÜŞTERİ NUMARASINI GİRİNİZ.");
            }

        }

        private void textAccountId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
