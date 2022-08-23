using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Transfer
{
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        SqlTransaction trans;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTCK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTCK_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CustomerProcessings customerProcessings = new CustomerProcessings();
            this.Close();
            customerProcessings.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            Customer customer = new Customer();
            customer.TCKN = textBoxTCK.Text;
            customer.FirstName = textBoxNAME.Text;
            customer.LastName = textBoxLASTNAME.Text;
            customer.BirthOfYear = textBoxBİRTHYEAR.Text;

            if (textBoxTCK.Text.Length == 11 && textBoxBİRTHYEAR.Text.Length == 4 && textBoxNAME.Text.Length != 0 && textBoxLASTNAME.Text.Length != 0)
            {

                long TCK = long.Parse(textBoxTCK.Text);
                int year = int.Parse(textBoxBİRTHYEAR.Text);
                bool Control;



                try
                {
                    using (KimlikTC.KPSPublicSoapClient service = new KimlikTC.KPSPublicSoapClient())
                    {
                        Control = service.TCKimlikNoDogrula(TCK, textBoxNAME.Text, textBoxLASTNAME.Text, year);
                    }
                }
                catch (Exception)
                {
                    Control = false;

                }

                
                if (Control)
                {
                    MessageBox.Show("KİMLİK DOĞRULAMA BAŞARILI");

                    if (customer.SaveCustomer() == 1)
                    {
                        
                        MessageBox.Show("MÜŞTERİ BAŞARIYLA KAYDEDİLDİ.");
                        DataTable dt = new DataTable();
                        customer.ShowNewCustomer().Fill(dt);
                        dataGridView1.DataSource = dt;

                        
                    }
                    else if (customer.SaveCustomer() == 0)
                    {
                        MessageBox.Show("LÜTFEN BİLGİLERİN HEPSİNİ GİRİNİZ");
                       

                    }
                    else if (customer.SaveCustomer() == 2)
                    {
                        MessageBox.Show("BU MÜŞTERİ SİSTEMDE KAYITLIDIR.");
                        
                    }
                    else if(customer.SaveCustomer() == 3)
                    {
                        MessageBox.Show("LÜTFEN BİLGİLERİN HEPSİNİ GİRİNİZ");
                        
                    }
                    else
                    {
                        
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("KİMLİK DOĞRULAMA BAŞARISIZ.");
                    
                    return;
                }
                    

            }

            else
            {
                MessageBox.Show("LÜTFEN BİLGİLERİN HEPSİNİ GİRİNİZ.");
                return;
            }
        }

        private void textBoxTCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxLASTNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxBİRTHYEAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxLASTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
