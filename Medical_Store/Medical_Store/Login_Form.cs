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
using static System.Net.Mime.MediaTypeNames;
namespace Medical_Store
{
    public partial class Login_Form : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_From_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void pic_loginlogo_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Click 'Yes' for Admin or 'No' for Customer",
                                                       "Select Role", MessageBoxButtons.YesNo);
            // First is Message, second is Title of Msg-Box, Third is Msg-Buttons
            if (Result == DialogResult.Yes)
            {
                this.Hide();  // use to hide previous form and this represent current instance of form
                Admin_Sign_Up signup = new Admin_Sign_Up();
                signup.ShowDialog();
                txt_pass.Text = "";
                txt_username.Text = "";
                this.Show();
            }
            else if (Result == DialogResult.No)
            {
                this.Hide();  // use to hide previous form and this represent current instance of form
                Customer_Sign_Up signup = new Customer_Sign_Up();
                signup.ShowDialog();
                txt_pass.Text = "";
                txt_username.Text = "";
                this.Show();
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            bool isFound = CheckAdminLogin();
            if (!isFound)
            {
                CheckCustomerLogin();
            }
        }
        private bool CheckAdminLogin()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    // We create con obj in head of using so that it automatically
                    // dispose of con obj when the block finishes 
                    con.Open();
                    string Query = "Select count(*) from admin where username = :username and password = :password";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = txt_username.Text;
                        cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = txt_pass.Text;
                        // Sequence of parameters should be same as in query
                        // Like first username so cmd.Parameters.Add("username", Username); should be first
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // cmd.ExecuteScaler() method return a single value like Sum, Count(*),Avg...etc
                        // It can also retrieve a single value from query
                        if (UserCount > 0)
                        {
                            MessageBox.Show("Login Successfully...!");
                            txt_pass.Text = "";
                            txt_username.Text = "";
                            this.Hide();
                            Admin_Dashboard dashboard = new Admin_Dashboard();
                            dashboard.ShowDialog();
                            this.Show();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
            return false;
        }
        private void CheckCustomerLogin()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    // We create con obj in head of using so that it automatically
                    // dispose of con obj when the block finishes 
                    con.Open();
                    string Query = "Select count(*) from customer where username =:username and password =:password";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = txt_username.Text;
                        cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = txt_pass.Text;
                        // Sequence of parameters should be same as in query
                        // Like first username so cmd.Parameters.Add("username", Username); should be first
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // cmd.ExecuteScaler() method return a single value like Sum, Count(*),Avg...etc
                        // It can also retrieve a single value from query
                        if (UserCount > 0)
                        {
                            MessageBox.Show("Login Successfully...!");
                            this.Hide();
                            Customer_Dashboard customer_Dashboard = new Customer_Dashboard(txt_username.Text);
                            customer_Dashboard.ShowDialog();
                            txt_pass.Text = "";
                            txt_username.Text = "";
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username/password...!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
        }

        private void pic_loginlogo_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forget_Password find_Password = new Forget_Password();
            this.Hide();
            find_Password.ShowDialog();
            txt_pass.Text = "";
            txt_username.Text = "";
            this.Show();
        }
    }
}
