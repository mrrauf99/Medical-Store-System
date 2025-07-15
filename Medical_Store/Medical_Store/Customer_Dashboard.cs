using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class Customer_Dashboard : Form
    {
        public static string Username = "";
        public Customer_Dashboard(string username)
        {
            InitializeComponent();
            Username = username;
        }

        public static void SetUsername(string u)
        {
            Username = u;
        }
        private void btn_transaction_Click(object sender, EventArgs e)
        {
            Customer_Transaction customer_Transaction = new Customer_Transaction(Username);
            this.Hide();
            customer_Transaction.ShowDialog();
            this.Show();
        }

        private void btn_billing_page_Click(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_Profile = new Customer_Profile(Username);
            this.Hide();
            customer_Profile.ShowDialog();
            this.Show();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
