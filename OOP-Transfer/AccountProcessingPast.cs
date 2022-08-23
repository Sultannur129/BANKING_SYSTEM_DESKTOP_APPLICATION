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
    public partial class AccountProcessingPast : Form
    {
        
        public AccountProcessingPast()
        {
            InitializeComponent();
        }
        public string CustomerId;
        public string date1;
        public string date2;

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.date1 = dateTimePicker1.Value;
            account.date2 = dateTimePicker2.Value;
            DataTable dt = new DataTable();
            account.ShowProcessings().Fill(dt);
            dataGridView1.DataSource = dt;
             


        }
    }
}
