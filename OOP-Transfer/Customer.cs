using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OOP_Transfer
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string TCKN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthOfYear { get; set; }


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N9O05R0;Initial Catalog=Transfer;Integrated Security=True");

        SqlTransaction trans = null;


        public SqlDataAdapter ShowNewCustomer()
        {
            try { 
            conn.Open();
            trans = conn.BeginTransaction(); 
            string find = "Select TOP 1  * from CUSTOMER ORDER BY CUSTOMER_ID DESC";
            SqlCommand sqlCommand = new SqlCommand(find, conn);
            sqlCommand.Transaction = trans;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            trans.Commit(); 
            conn.Close();
            return sqlDataAdapter;
        }
            catch (Exception ex)
            {
                trans.Rollback();
                conn.Close();
                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }


        public void showCustomer(ShowCustomerInfo showCustomerInfo)
        {
            
            conn.Open();
            trans=conn.BeginTransaction();

            string show1 = "select * from CUSTOMER where CUSTOMER_ID=@customer_id";

            SqlCommand sqlCommand = new SqlCommand(show1, conn);
            sqlCommand.Transaction = trans;
            sqlCommand.Parameters.AddWithValue("@customer_id", CustomerId);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                showCustomerInfo.CustomerId = reader["CUSTOMER_ID"].ToString();
                showCustomerInfo.CustomerName = reader["CUSTOMER_FIRSTNAME"].ToString();
                showCustomerInfo.CustomerSurname = reader["CUSTOMER_LASTNAME"].ToString();
                showCustomerInfo.CustomerTCK = reader["CUSTOMER_TCK"].ToString();

            }
            reader.Close();
            trans.Commit();
            conn.Close();
  
        }






        public int SaveCustomer()
        {
            try { 
            conn.Open();
            trans = conn.BeginTransaction(); 

            string control = "select COUNT(CUSTOMER_TCK) from CUSTOMER where CUSTOMER_TCK=@customer_tck";

            SqlCommand cmd = new SqlCommand(control, conn);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@customer_tck", TCKN);
            int count = (int)cmd.ExecuteScalar();


            if (count <= 0)
            {
                if (TCKN.Length == 11 && BirthOfYear.Length == 4 && FirstName.Length > 0 && LastName.Length > 0)
                {

                    cmd.Parameters.Clear();

                    cmd.CommandText = "insert into CUSTOMER (CUSTOMER_ID,CUSTOMER_FIRSTNAME,CUSTOMER_LASTNAME,CUSTOMER_TCK,CUSTOMER_BIRTHYEAR) values (format(next value for [dbo].[Customer_seq],'000000000000'),@customer_firstname,@customer_lastname,@customer_tck,@customer_birthyear)";
                    cmd.Parameters.AddWithValue("@customer_firstname", FirstName);
                    cmd.Parameters.AddWithValue("@customer_lastname", LastName);
                    cmd.Parameters.AddWithValue("@customer_tck", TCKN);
                    cmd.Parameters.AddWithValue("@customer_birthyear", BirthOfYear);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    trans.Commit(); 
                    conn.Close();


                    return 1;

                }
                else
                {
                        trans.Commit();
                        conn.Close();

                    return 0;
                }

            }

            else
            {
                if (TCKN.Length == 11 && BirthOfYear.Length == 4 && FirstName.Length > 0 && LastName.Length > 0)
                {
                    trans.Commit();
                    conn.Close();

                    return 2;
                }
                else
                {
                    trans.Commit();
                    conn.Close();

                    return 3;
                }

            }
        }

            catch (Exception ex)
            {
                trans.Rollback();
                conn.Close();
                throw ex;
            }

            finally
            {
                conn.Close();
            }


        }

    

        




    }
}
