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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerInfoButton_Click_1(object sender, EventArgs e)
        {
           // CustomerProcessings customerProcessings = new CustomerProcessings();
          
            //this.Hide();
            //customerProcessings.Show();

        }

        private void AccountInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountProcessings accountProcessings = new AccountProcessings();
            accountProcessings.Show();

        }

      

        private void mnMusteriOlustur_Click_1(object sender, EventArgs e)
        {
            AddNewCustomer customerProcessings = new AddNewCustomer();
            customerProcessings.MdiParent = this;
            customerProcessings.Show();
        }

        private void müşteriBilgileriniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCustomerInfo showCustomerInfo = new ShowCustomerInfo();
            showCustomerInfo.MdiParent = this;
            showCustomerInfo.Show();

        }

        private void hesapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*AccountProcessings accountProcessings=new AccountProcessings();
            accountProcessings.MdiParent = this;
            accountProcessings.Show();*/
        }

        private void hesaplarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProcessings accountProcessings = new AccountProcessings();
            accountProcessings.MdiParent = this;
            accountProcessings.Show();

        }

        private void yeniHesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesapİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountProcessings accountProcessings = new AccountProcessings();
            accountProcessings.MdiParent = this;
            accountProcessings.Show();

        }
    }
}
