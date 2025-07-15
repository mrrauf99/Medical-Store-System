using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Medical_Store
{
    public partial class Forget_Password : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
                                 "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
                                 "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool isAdmin = AdminLogin();
                if (!isAdmin)
                {
                    CustomerLogin();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool AdminLogin()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    // Step 1: Check if email exists in Admin table
                    string query = "Select count(*) from Admin where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            // Step 2: Update password
                            query = "Update Admin set Password = :pass where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(query, con))
                            {
                                cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error:" + ex.Message);
            }
            return false;
        }

        private void CustomerLogin()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    // Step 1: Check if email exists in Customer table
                    string query = "Select count(*) from Customer where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            // Step 2: Update password
                            query = "Update Customer set password = :pass where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(query, con))
                            {
                                cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email...!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_email.Text = "";
                            txt_pass.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error:" + ex.Message);
            }
        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
