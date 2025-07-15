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
    public partial class Admin_Billing_Page : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        // Properties
        int Header = 0;
        double TotalBill = 0;
        int SrNo = 1;
        public Admin_Billing_Page()
        {
            InitializeComponent();
            LoadMedicines();
        }
        private void LoadMedicines()
        {
            try
            {
                string query = "Select Medicine_Name from Medicine";
                // OraclaDataReader fetch rows returned by the query
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
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_select_medicine_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_quantitty_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            string MedName;
            if (combobox_medicine.SelectedItem == null)
            {
                MessageBox.Show("Please select a medicine.");
                return;
            }
            else
            {
                MedName = combobox_medicine.SelectedItem.ToString();
            }
            if (txt_quantity.Text == "")
            {
                MessageBox.Show("Please enter quantity...!", "Information");
                return;
            }
            if (txt_customer_id.Text == "")
            {
                MessageBox.Show("Please enter Customer-ID...!", "Information");
                return;
            }
            try
            {
                int Quantity = Convert.ToInt32(txt_quantity.Text);
                string query = "select price from medicine where Medicine_Name = :name";
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = MedName;
                        double Rate = Convert.ToDouble(cmd.ExecuteScalar());
                        TotalBill = TotalBill + (Rate * Quantity);
                        if (UpdateQuantity(MedName, Quantity))
                        {
                            string output;
                            if (Header == 0)  // For displaying Header
                            {
                                txt_bill_box.Text = "";
                                output = $"{"Sr.No.",-8}\t{"Medicine",-20}\t{"Qty",-6}\t{"Rate",-8}\t{"Amount",-10}" + Environment.NewLine;
                                txt_bill_box.Text += output;
                                txt_bill_box.Text += new string('-', 75) + Environment.NewLine; // Adds a separator line
                                Header = 1;
                            }
                            double Amount = Quantity * Rate;
                            output = $"{SrNo,-8}\t{MedName,-20}\t{Quantity,-6}\t{Rate,-8}\t{Amount,-10}" + Environment.NewLine;
                            // Environment.NewLine use to shift cursor in next line 
                            txt_bill_box.Text += output;
                            SrNo++;
                            // Transaction Record
                            query = "INSERT INTO Transaction (Customer_Id, Medicine_Name, Quantity, Rate, Amount, Purchased_date) " +
                                    "VALUES (:customer_id, :med_name, :quantity, :rate, :amount, :purchased_date)";

                            using (OracleCommand cmd2 = new OracleCommand(query, con))
                            {
                                cmd2.Parameters.Add(":customer_id", OracleDbType.Varchar2).Value = txt_customer_id.Text;
                                cmd2.Parameters.Add(":med_name", OracleDbType.Varchar2).Value = MedName;
                                cmd2.Parameters.Add(":quantity", OracleDbType.Int32).Value = Quantity;
                                cmd2.Parameters.Add(":rate", OracleDbType.Double).Value = Rate;
                                cmd2.Parameters.Add(":amount", OracleDbType.Double).Value = Amount;
                                cmd2.Parameters.Add(":purchased_date", OracleDbType.Date).Value = DateTime.Now;

                                cmd2.ExecuteNonQuery();
                            }

                            // Clear controls after insertion
                            combobox_medicine.SelectedItem = null;
                            txt_quantity.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
        private bool UpdateQuantity(string MedName, int Amount)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    // We create con obj in head of using so that it automatically
                    // dispose of con obj when the block finishes 
                    con.Open();
                    string query = "select quantity from medicine where Medicine_Name = :name";
                    using (OracleCommand cmd = new OracleCommand(query, con))  // it automatically dispose cmd obj
                    {
                        cmd.Parameters.Add("name", MedName);
                        int Quantity = Convert.ToInt32(cmd.ExecuteScalar());
                        if (Quantity - Amount >= 0)
                        {
                            query = "Update Medicine set Quantity = Quantity - :amount where Medicine_Name = :name";
                            using (OracleCommand cmd1 = new OracleCommand(query, con))
                            {
                                cmd1.Parameters.Add("amount", Amount);
                                cmd1.Parameters.Add("name", MedName);
                                cmd1.ExecuteNonQuery();
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Insufficient Quantity\nAvailable Quantity: {Quantity}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
            return false;
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            txt_bill_box.Text += Environment.NewLine + new string('-', 75) + Environment.NewLine;
            // new string('-', 75) use to give -----------------------------------
            string output = string.Format($"{"\nTotal Bill",-70} Rs. {TotalBill}");
            txt_bill_box.Text += output;
            // Clear controls after insertion
            combobox_medicine.SelectedItem = null;
            txt_quantity.Text = "";
            txt_customer_id.Text = "";
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_clearbill_Click(object sender, EventArgs e)
        {
            Header = 0;
            txt_bill_box.Text = "";
            TotalBill = 0;
            SrNo = 1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}