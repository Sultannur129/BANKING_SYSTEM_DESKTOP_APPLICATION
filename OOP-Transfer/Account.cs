using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOP_Transfer
{
    public class Account
    {
        public string CustomerId { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public DateTime Date { get; set; }
        public string AccountControl { get; set; }
        public decimal price { get; set; }
        public string SendAccountId { get; set; }
        public DateTime date1 { get; set; }
        public DateTime date2 { get; set; }


        SqlConnection conn=new SqlConnection("Data Source=DESKTOP-N9O05R0;Initial Catalog=Transfer;Integrated Security=True");
        SqlTransaction trans;
        public SqlDataAdapter ShowAccounts()
        {
            try
            {
                conn.Open();
                trans=conn.BeginTransaction();
                string findAccounts = "select * from ACCOUNT where CUSTOMER_ID=@customer_id";
                SqlCommand cmd = new SqlCommand(findAccounts, conn);
                cmd.Transaction= trans;
                cmd.Parameters.AddWithValue("@customer_id", CustomerId);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                trans.Commit();
                conn.Close();
                return sqlDataAdapter;
            }
            catch(Exception ex)
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

        public void NewAccountSet()
        {
            try { 
            conn.Open();
            trans=conn.BeginTransaction();
            string set = "insert into ACCOUNT (CUSTOMER_ID,ACCOUNT_ID,BALANCE,DATE,ACCOUNT_CONTROL) values (@customer_id,format(next value for [dbo].[Account_seq],'00000000000000000'),@balance,@date,@account_control)";
            SqlCommand sqlCommand = new SqlCommand(set, conn);
            sqlCommand.Transaction = trans;
            sqlCommand.Parameters.AddWithValue("@customer_id", CustomerId);
            sqlCommand.Parameters.AddWithValue("@balance", 0.0);
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@account_control", "A");
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            string get = "SELECT top 1 ACCOUNT_ID FROM ACCOUNT order by ACCOUNT_ID desc ";
            sqlCommand.CommandText = get;
            string Account_id=(string)sqlCommand.ExecuteScalar();
            sqlCommand.Parameters.Clear();     
            string save = "insert into ACCOUNT_MANAGE (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";
            sqlCommand.CommandText = save;
            sqlCommand.Parameters.AddWithValue("@account_id",Account_id);
            sqlCommand.Parameters.AddWithValue("@account_process", "YENİ HESAP AÇMA");
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@amount",0.0);
            sqlCommand.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
            catch(Exception ex)
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

        public bool AddMoney(Account account)
        {
            try { 

            conn.Open();
            trans= conn.BeginTransaction(); 
            string find = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";
            string getBalance = "select BALANCE from ACCOUNT where ACCOUNT_ID=@account_id";
            string insert = "Update ACCOUNT set BALANCE=@balance where ACCOUNT_ID=@account_id";
            string add = "insert into ACCOUNT_MANAGE  (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";

            SqlCommand sqlCommand = new SqlCommand(find, conn);
            sqlCommand.Transaction = trans;
            sqlCommand.Parameters.AddWithValue("@account_id", account.AccountId);

            string AControl = (string)sqlCommand.ExecuteScalar();
            if (AControl.Equals("A"))
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = getBalance;
                sqlCommand.Parameters.AddWithValue("@account_id", account.AccountId);
                decimal balance = (decimal)sqlCommand.ExecuteScalar();
                balance += account.price;
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = insert;
                sqlCommand.Parameters.AddWithValue("@account_id", account.AccountId);
                sqlCommand.Parameters.AddWithValue("@balance", balance);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = add;
                sqlCommand.Parameters.AddWithValue("@account_id", account.AccountId);
                sqlCommand.Parameters.AddWithValue("@account_process", "PARA YATIRMA");
                sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@amount", "+" + account.price);
                sqlCommand.ExecuteNonQuery();
                trans.Commit();   
                conn.Close();
                return true;
            }

            else
            {
                trans.Commit();
                return false;
            }
        }
            catch(Exception ex)
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


        public int GetMoney()
        {
            try { 
            conn.Open();
            trans = conn.BeginTransaction(); 
            string control = "Select BALANCE from ACCOUNT where ACCOUNT_ID=@account_id";

            SqlCommand cmd = new SqlCommand(control, conn);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@account_id", AccountId);
            decimal balance = (decimal)cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            decimal total = balance - price;

            if (price > balance)
            {
                trans.Commit();
                conn.Close();
                return 1;
            }

            else
            {


                string update = "update ACCOUNT set BALANCE=@balance WHERE ACCOUNT_ID=@account_id";

                string accountControl = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";

                cmd.CommandText = accountControl;

                cmd.Parameters.AddWithValue("@account_id", AccountId);
                string Control = (string)cmd.ExecuteScalar();

                if (Control.Equals("A"))
                {
                    cmd.Parameters.Clear();

                    cmd.CommandText = update;

                    cmd.Parameters.AddWithValue("@balance", total);
                    cmd.Parameters.AddWithValue("@account_id", AccountId);
                    cmd.ExecuteNonQuery(); 
                    cmd.Parameters.Clear(); 
                    string line = "insert into ACCOUNT_MANAGE (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";
                    cmd.CommandText = line;

                        cmd.Parameters.AddWithValue("@account_id", AccountId);
                        cmd.Parameters.AddWithValue("@account_process", "PARA ÇEKME");
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@amount", price);
                        cmd.ExecuteNonQuery();

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

            catch(Exception ex)
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

        public int Transfer()
        {
            try { 
            conn.Open();
            trans=conn.BeginTransaction();
            string getbalance1 = "select BALANCE from ACCOUNT where ACCOUNT_ID=@account_id";
            string getControl1 = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";
            string getbalance2 = "select BALANCE from ACCOUNT where ACCOUNT_ID=@account_id";
            string getControl2 = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";

            SqlCommand sqlCommand = new SqlCommand(getbalance1, conn);
            sqlCommand.Transaction = trans;
            sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
            decimal balance1 = (decimal)sqlCommand.ExecuteScalar();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = getbalance2;
            sqlCommand.Parameters.AddWithValue("@account_id", SendAccountId);
            decimal balance2 = (decimal)sqlCommand.ExecuteScalar();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = getControl1;
            sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
            string control1 = (string)sqlCommand.ExecuteScalar();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = getControl2;
            sqlCommand.Parameters.AddWithValue("@account_id", SendAccountId);
            string control2 = (string)sqlCommand.ExecuteScalar();

            if (control1.Equals("A") && control2.Equals("A"))
            {
                if (price > balance1)
                {
                    trans.Commit();    
                    conn.Close();
                    return 1;
                }
                else
                {
                    balance1 -= price;
                    balance2 += price;
                    string update1 = "update ACCOUNT set BALANCE=@balance where ACCOUNT_ID=@account_id";
                    string update2 = " update ACCOUNT set BALANCE=@balance where ACCOUNT_ID=@account_id";
                    string insert = "insert into ACCOUNT_MANAGE (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = update1;
                    sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
                    sqlCommand.Parameters.AddWithValue("@balance", balance1);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = update2;
                    sqlCommand.Parameters.AddWithValue("@account_id", SendAccountId);
                    sqlCommand.Parameters.AddWithValue("@balance", balance2);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = insert;
                    sqlCommand.Parameters.AddWithValue("@account_id", SendAccountId);
                    sqlCommand.Parameters.AddWithValue("@account_process", "HAVALE");
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
                    sqlCommand.Parameters.AddWithValue("@amount", "+" + price);
                    sqlCommand.ExecuteNonQuery();
                    trans.Commit();
                    conn.Close();
                    return 2;


                }

            }
            else
            {
                trans.Commit();
                conn.Close();
                return 0;
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


        public bool AccountOpen()
        {
            try { 
            conn.Open();
            trans = conn.BeginTransaction();
            string getControl = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";
            SqlCommand cmd = new SqlCommand(getControl, conn);
            cmd.Transaction = trans;
            cmd.Parameters.AddWithValue("@account_id", AccountId);
            string getControl1 = (string)cmd.ExecuteScalar();
            if (getControl1.Equals("K"))
            {
                cmd.Parameters.Clear();
                string update = "update ACCOUNT set ACCOUNT_CONTROL=@account_control where ACCOUNT_ID=@account_id";
                cmd.CommandText = update;
                cmd.Parameters.AddWithValue("@account_id", AccountId);
                cmd.Parameters.AddWithValue("@account_control", "A");
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                string AccountOpen = "insert into ACCOUNT_MANAGE (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";
                cmd.CommandText=AccountOpen;
                cmd.Parameters.AddWithValue("@account_id",AccountId);
                cmd.Parameters.AddWithValue("@account_process", "HESAP AÇMA");
                cmd.Parameters.AddWithValue("@date",DateTime.Now);
                cmd.Parameters.AddWithValue("@amount",0.0);
                cmd.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                return true;

            }
            else
            {
                trans.Commit();
                conn.Close();
                return false;
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

        public int AccountClose()
        {
            try { 
            conn.Open();
            trans = conn.BeginTransaction();
            string getbalance = "select BALANCE from ACCOUNT where ACCOUNT_ID=@account_id";
            string getControl = "select ACCOUNT_CONTROL from ACCOUNT where ACCOUNT_ID=@account_id";
            SqlCommand sqlCommand = new SqlCommand(getbalance, conn);
            sqlCommand.Transaction = trans;
            sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
            decimal balance = (decimal)sqlCommand.ExecuteScalar();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = getControl;
            sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
            string control = (string)sqlCommand.ExecuteScalar();

            if (control.Equals("A"))
            {
                if (balance == 0)
                {
                    sqlCommand.Parameters.Clear();
                    string update = "update ACCOUNT set ACCOUNT_CONTROL=@account_control where ACCOUNT_ID=@account_id";
                    sqlCommand.CommandText = update;
                    sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
                    sqlCommand.Parameters.AddWithValue("@account_control", "K");
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    string insert = "insert into ACCOUNT_MANAGE (ACCOUNT_ID,ACCOUNT_PROCESS,DATE,AMOUNT) values (@account_id,@account_process,@date,@amount)";
                    sqlCommand.CommandText = insert;
                    sqlCommand.Parameters.AddWithValue("@account_id", AccountId);
                    sqlCommand.Parameters.AddWithValue("@account_process", "HESAP KAPATMA");
                    sqlCommand.Parameters.AddWithValue("@date",DateTime.Now);
                    sqlCommand.Parameters.AddWithValue("@amount",0.0);
                    sqlCommand.ExecuteNonQuery();
                    trans.Commit();
                    conn.Close();
                    return 1;

                }
                else
                {
                    trans.Commit();
                    conn.Close();
                    return 2;

                }
            }
            else
            {
                    trans.Commit();
                    conn.Close();
                    return 3;
            }
        }
            catch(Exception ex)
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


        public SqlDataAdapter ShowProcessings()
        {
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string show = "select * from ACCOUNT_MANAGE where DATE between @date1 and @date2";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(show, conn);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date1", date1);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date2", date2);
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

        

    }
}
