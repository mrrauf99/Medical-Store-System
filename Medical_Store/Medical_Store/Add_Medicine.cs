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
    public partial class Add_Medicine : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
                "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
                "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";
        public Add_Medicine()
        {
            InitializeComponent();
            expiry_date.Value = DateTime.Now;
        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_medicine_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_price.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Please fill all the fields...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Insert into Medicine (Medicine_Name, Price, Quantity, Expiry_date) " +
                                   "values (:name, :price, :quantity, :expiry_date)";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        /* txt_name.Text is a property of TextBox, and its type is string.
                        .Value assigns the actual value from the text box to the parameter. */
                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txt_name.Text;
                        cmd.Parameters.Add("price", OracleDbType.Double).Value = Convert.ToDouble(txt_price.Text);
                        cmd.Parameters.Add("quantity", OracleDbType.Int32).Value = Convert.ToInt32(txt_quantity.Text); //  Direct passing value
                        cmd.Parameters.Add("expiry_date", OracleDbType.Date).Value = expiry_date.Value;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine added successfully...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_name.Text = "";
                        txt_price.Text = "";
                        txt_quantity.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void date_expiry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
