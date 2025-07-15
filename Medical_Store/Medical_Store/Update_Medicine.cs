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
    public partial class Update_Medicine : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                  "(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        bool isUpdating = false;
        public Update_Medicine()
        {
            InitializeComponent();
            LoadMedicines();
            expiry_date.Value = DateTime.Now;
        }

        private void Update_Medicine_Load(object sender, EventArgs e)
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

        private void btn_update_medicine_Click(object sender, EventArgs e)
        {
            if (combobox_medicine.SelectedIndex == -1 || txt_name.Text == "" || txt_price.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    isUpdating = true;
                    string old_name = combobox_medicine.SelectedItem.ToString();
                    string Query = "Update Medicine set Medicine_Name = :new_name, Quantity = :quantity," +
                                   " Price = :price, Expiry_Date = :expiry_date where Medicine_Name = : old_name";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("new_name", OracleDbType.Varchar2).Value = txt_name.Text;
                        cmd.Parameters.Add("quantity", OracleDbType.Int64).Value = Convert.ToInt64(txt_quantity.Text);
                        cmd.Parameters.Add("price", OracleDbType.Double).Value = Convert.ToDouble(txt_price.Text);
                        cmd.Parameters.Add("expiry_date", OracleDbType.Date).Value = expiry_date.Value;
                        cmd.Parameters.Add("old_name", OracleDbType.Varchar2).Value = old_name;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine updated successfully...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_name.Text = "";
                        txt_price.Text = "";
                        txt_quantity.Text = "";
                        combobox_medicine.SelectedItem = null;  // when we change something in Combo-Box it trigger it's event handler
                        isUpdating = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void combobox_medicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMedicineDetails();
            /* You need to call the LoadMedicineDetails method inside the Combobox Event.
               This ensures that whenever the user selects an item, the
               corresponding medicine details are automatically displayed. */
        }
        private void LoadMedicineDetails()
        {
            if (isUpdating)
            {
                return;
            }
            if (combobox_medicine.SelectedItem == null)
            {
                MessageBox.Show("Please select a medicine");
                return;

            }
            string MedicineName = combobox_medicine.SelectedItem.ToString();
            try
            {
                string query = "Select Price, Quantity, Expiry_Date from Medicine where Medicine_Name = :MedName";
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":MedName", MedicineName);
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_name.Text = MedicineName;
                                txt_price.Text = reader["Price"].ToString();
                                txt_quantity.Text = reader["Quantity"].ToString();
                                expiry_date.Value = Convert.ToDateTime(reader["Expiry_Date"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_expiry_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
