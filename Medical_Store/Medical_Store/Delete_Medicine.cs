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
    public partial class Delete_Medicine : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                          "(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";
        public Delete_Medicine()
        {
            InitializeComponent();
            LoadMedicines();
        }

        private void Delete_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void LoadMedicines()
        {
            try
            {
                string query = "Select Medicine_Name from Medicine";
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader Reader = cmd.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                combobox_medicine.Items.Add(Reader["Medicine_Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void btn_del_medicine_Click(object sender, EventArgs e)
        {
            if (combobox_medicine.SelectedItem == null)
            {
                MessageBox.Show("Please select the medicine");
                return;
            }
            string Med_Name = combobox_medicine.SelectedItem.ToString();
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Delete From Medicine where Medicine_Name = :Med_Name";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("Med_Name", Med_Name);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine deleted successfully...!");
                        combobox_medicine.SelectedItem = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
