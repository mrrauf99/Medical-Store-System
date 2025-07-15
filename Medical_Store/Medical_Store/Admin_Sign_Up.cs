using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Store
{
    public partial class Admin_Sign_Up : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION= (ADDRESS=(PROTOCOL=TCP)" +
        "(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        // Property for storing Image Data
        byte[] img = null;

        public Admin_Sign_Up()
        {
            InitializeComponent();
            combo_country.SelectedItem = "Pakistan";
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            string FirstName = txt_firstname.Text;
            string LastName = txt_lastname.Text;
            string Username = txt_username.Text;
            string Pass = txt_pass.Text;
            string Email = txt_email.Text;
            string Country = combo_country.SelectedItem.ToString();
            if (FirstName == "" || LastName == "" || Username == "" || Pass == "" || Email == "")
            {
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
            }
            else if (img == null)
            {
                MessageBox.Show("Please insert the image");
                return;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    if (CheckUsername(Username))
                    {
                        string Query = "INSERT INTO Admin (first_name, last_name, username, password, email, country, Image) " +
                                                  "VALUES (:firstname, :lastname, :username, :password, :email, :country, :image)";
                        using (OracleCommand cmd = new OracleCommand(Query, con))
                        {
                            cmd.Parameters.Add("firstname", OracleDbType.Varchar2).Value = FirstName;
                            cmd.Parameters.Add("lastname", OracleDbType.Varchar2).Value = LastName;
                            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = Username;
                            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = Pass;
                            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = Email;
                            cmd.Parameters.Add("country", OracleDbType.Varchar2).Value = Country;
                            cmd.Parameters.Add("image", OracleDbType.Blob).Value = img;
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Sign Up Successfully...!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists...!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error" + ex.Message);
                //ex is a variable of Exception class which stores information about error
            }
        }
        private bool CheckUsername(string username)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from Admin where username = :username";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // cmd.ExecuteScaler() method return a single value like Sum, Count(*),Avg...etc
                        if (UserCount > 0)
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
            return true;
        }

        private void picbox_insert_Click(object sender, EventArgs e)
        {

        }

        private void GetImageBytes()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "[JPG,JPEG]|*.jpg; *.png";
            try
            {
                //If the user selects a file(i.e., DialogResult.OK), the code proceeds to read the file.
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image
                    picbox_insert.Image = Image.FromFile(openFileDialog1.FileName);
                    picbox_insert.SizeMode = PictureBoxSizeMode.StretchImage;
                    using (FileStream FS = new FileStream(@openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        // .FileName contains the full file path of the selected file.
                        // FileStream can perform both reading and writing operations
                        img = new byte[FS.Length];
                        // FS.Length size of that img
                        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                        /*   img – The destination byte array where the file data will be stored.
                             0 – The starting position in the byte array where data will be written.
                             Convert.ToInt32(FS.Length) – The number of bytes to read from the file.  */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error:" + ex.Message);
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void picbox_insert_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            GetImageBytes();
            // We call this method so that the image should display in picture box
        }

        private void lbl_pic_Click(object sender, EventArgs e)
        {

        }
    }
}

