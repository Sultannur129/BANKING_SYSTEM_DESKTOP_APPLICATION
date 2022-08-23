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
    public partial class AccountProcessings : Form
    {
        public AccountProcessings()
        {
            InitializeComponent();
        }

        private void NewAccountOpenButton_Click(object sender, EventArgs e)
        {

        }

        private void AccountProcessings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage  mainPage = new MainPage();
            mainPage.Show();
        }

        private void AccountOpenButton_Click(object sender, EventArgs e)
        {
            AccountOpen accountOpen = new AccountOpen();
            accountOpen.Show();

        }

        private void ShowAccountButton_Click(object sender, EventArgs e)
        {
            
            Account account = new Account();
            if (textCustomerId.Text.Length == 12)
            {
                account.CustomerId = textCustomerId.Text;
                DataTable dt = new DataTable();
                account.ShowAccounts().Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("LÜTFEN MÜŞTERİ ID GİRİNİZ.");
            }

        }

        private void NewAccountOpen_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            if (textCustomerId.Text.Length > 0) { 
            account.CustomerId = textCustomerId.Text;
            account.NewAccountSet();
            MessageBox.Show("YENİ HESAP AÇILMIŞTIR VE LİSTE GÜNCELLENMİŞTİR.");
            DataTable dt = new DataTable();
            account.ShowAccounts().Fill(dt);
            dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("LÜTFEN MÜŞTERİ ID GİRİNİZ.");
            }

        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            AddMoney addMoney = new AddMoney();
            //addMoney.MdiParent= this;
            addMoney.Show();
            
        }

        private void GetMoneyButton_Click(object sender, EventArgs e)
        {
            MoneyGet moneyGet = new MoneyGet();
            moneyGet.Show();
        }

        private void SendMoneyAnotherAccountButton_Click(object sender, EventArgs e)
        {
            SendMoneyToAnotherAccount sendMoneyToAnotherAccount = new SendMoneyToAnotherAccount();
            sendMoneyToAnotherAccount.Show();
        }

        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            AccountClose accountClose = new AccountClose();
            accountClose.Show();
        }

        private void ShowPastAccounts_Click(object sender, EventArgs e)
        {
            AccountProcessingPast accountProcessingPast = new AccountProcessingPast();
            accountProcessingPast.Show();
            




        }

        private void textCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yENİHESAPAÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            if (textCustomerId.Text.Length > 0)
            {
                account.CustomerId = textCustomerId.Text;
                account.NewAccountSet();
                MessageBox.Show("YENİ HESAP AÇILMIŞTIR VE LİSTE GÜNCELLENMİŞTİR.");
                DataTable dt = new DataTable();
                account.ShowAccounts().Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("LÜTFEN MÜŞTERİ ID GİRİNİZ.");
            }
        }

        private void pARAYATIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoney addMoney = new AddMoney();
            addMoney.MdiParent = this;
            addMoney.Show();
        }

        private void pARAÇEKMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyGet moneyGet = new MoneyGet();
            moneyGet.MdiParent = this;
            moneyGet.Show();
        }

        private void hAVALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMoneyToAnotherAccount sendMoneyToAnotherAccount = new SendMoneyToAnotherAccount();
            sendMoneyToAnotherAccount.MdiParent = this;
            sendMoneyToAnotherAccount.Show();
        }

        private void hESAPAÇMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountOpen accountOpen = new AccountOpen();
            accountOpen.MdiParent = this;
            accountOpen.Show();

        }

        private void hESAPKAPATMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountClose accountClose = new AccountClose();
            accountClose.MdiParent = this;
            accountClose.Show();
        }

        private void hESAPÖZETLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProcessingPast accountProcessingPast = new AccountProcessingPast();
            accountProcessingPast.MdiParent = this;
            accountProcessingPast.Show();
        }
    }
}
