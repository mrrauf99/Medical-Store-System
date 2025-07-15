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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_new_medicine_Click(object sender, EventArgs e)
        {
            Add_Medicine add_Medicine = new Add_Medicine();
            this.Hide();
            add_Medicine.ShowDialog();
            this.Show();
        }

        private void btn_billing_page_Click(object sender, EventArgs e)
        {
            Admin_Billing_Page billing_Page = new Admin_Billing_Page();
            this.Hide();
            billing_Page.ShowDialog();
            this.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_medicine_Click(object sender, EventArgs e)
        {
            Update_Medicine update_Medicine = new Update_Medicine();
            this.Hide();
            update_Medicine.ShowDialog();
            this.Show();
        }

        private void btn_del_medicine_Click(object sender, EventArgs e)
        {
            Delete_Medicine delete_Medicine= new Delete_Medicine();
            this.Hide();
            delete_Medicine.ShowDialog();
            this.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
