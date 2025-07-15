using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Medical_Store
{
    public partial class Customer_Transaction : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        public Customer_Transaction(string username)
        {
            InitializeComponent();
            LoadLastTransactions(username);
        }

        private void dgv_record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadLastTransactions(string username)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT Medicine_Name, Quantity, Rate, Amount, TO_CHAR(Purchased_Date, 'dd-Mon-yyyy hh:mi:ss am') AS Purchased_Date
                    FROM (SELECT Medicine_Name, Quantity, Rate, Amount, Purchased_Date FROM Transaction
                    WHERE Customer_ID = :username ORDER BY Purchased_Date DESC)  WHERE ROWNUM <= 5";
                    // @ string k start me lgane se hum aik string ko multiple lines me likh skte hn without concatenate them
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", username));
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        // Fetch data from Oracle
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        // Store data in table obj
                        dgv_record.DataSource = dt;
                        // Display data in grid view
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
        }
    }
}
