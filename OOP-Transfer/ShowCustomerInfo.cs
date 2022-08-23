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
    public partial class ShowCustomerInfo : Form
    {
        public ShowCustomerInfo()
        {
            InitializeComponent();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTCK { get; set; }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ShowCustomerInformations_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            Customer customer = new Customer();
            customer.CustomerId = textCustomerId.Text;
            Account account = new Account();
            account.CustomerId=textCustomerId.Text;
            ShowCustomerInfo showCustomerInfo = new ShowCustomerInfo();
            customer.showCustomer(showCustomerInfo);
            

            textCustomerName.Text = showCustomerInfo.CustomerName;
            textCustomerSurname.Text = showCustomerInfo.CustomerSurname;
            textTCKN.Text = showCustomerInfo.CustomerTCK;
            account.ShowAccounts();

            account.ShowAccounts().Fill(dataTable);
            dataGridView1.DataSource= dataTable;
            MessageBox.Show("MÜŞTERİ BİLGİLERİ GÖSTERİLDİ.");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerProcessings customerProcessings = new CustomerProcessings();
            customerProcessings.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textAccountId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            textBalance.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textCustomerSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textAccountId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
