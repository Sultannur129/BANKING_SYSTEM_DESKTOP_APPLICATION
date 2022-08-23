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
    public partial class CustomerProcessings : Form
    {
        public CustomerProcessings()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();

        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            this.Close();
            addNewCustomer.Show();
        }

        private void ShowCustomerInfoButton_Click(object sender, EventArgs e)
        {
            ShowCustomerInfo showCustomerInfo = new ShowCustomerInfo();
            this.Close();
            showCustomerInfo.Show();
        }
    }
}
