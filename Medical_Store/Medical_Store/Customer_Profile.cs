using System;
using System.IO;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace Medical_Store
{
    public partial class Customer_Profile : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=cs;Password=123;";

        //Property for storing Image Data
        byte[] img = null;
        string Username = "";
        public Customer_Profile(string username)
        {
            InitializeComponent();
            Username = username;
            LoadProfileDetails(Username);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to update your details?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.OKCancel);
            if (DialogResult.OK == result)
            {
                if (txt_firstname.Text == "" || txt_lastname.Text == "" || txt_username.Text == "" || txt_pass.Text == "" || txt_email.Text == "")
                {
                    {
                        MessageBox.Show("Please fill in all the fields...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (combo_country.SelectedItem == null)
                {
                    MessageBox.Show("Please select the country...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (img == null)
                {
                    MessageBox.Show("Please insert the image...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        if (!CheckUsername(txt_username.Text))
                        {
                            // Update Personal Information
                            string query = "UPDATE Customer SET First_name = :firstname, Last_name = :lastname, " +
                            "Username = :NewUsername, Password = :password, Email = :email, Country = :country, Image = :image where Username = :OldUsername";
                            using (OracleCommand cmd = new OracleCommand(query, con))
                            {
                                cmd.Parameters.Add("firstname", OracleType.VarChar).Value = txt_firstname.Text;
                                cmd.Parameters.Add("lastname", OracleType.VarChar).Value = txt_lastname.Text;
                                cmd.Parameters.Add("NewUsername", OracleType.VarChar).Value = txt_username.Text;
                                cmd.Parameters.Add("password", OracleType.VarChar).Value = txt_pass.Text;
                                cmd.Parameters.Add("email", OracleType.VarChar).Value = txt_email.Text;
                                cmd.Parameters.Add("country", OracleType.VarChar).Value = combo_country.SelectedItem.ToString();
                                cmd.Parameters.Add("image", OracleType.Blob).Value = img;
                                cmd.Parameters.Add("OldUsername", OracleType.VarChar).Value = Username;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Profile updated Successfully...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Customer_Dashboard.SetUsername(txt_username.Text);
                                Username = txt_username.Text;
                                LoadProfileDetails(txt_username.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username already exist...!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error" + ex.Message);
                    //ex is a variable of Exception class which stores information about error
                }
            }
        }


        private bool CheckUsername(string txt_username)
        {
            if (Username == txt_username)
            {
                return false;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from Customer where username = :username";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("username", OracleType.VarChar).Value = txt_username;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // cmd.ExecuteScaler() method return a single value like Sum, Count(*),Avg...etc
                        if (UserCount > 0)
                        {
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
        private void Customer_Profile_Load(object sender, EventArgs e)
        {

        }

        private void LoadProfileDetails(string Username)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    // Personal Information Display
                    string query = " Select First_Name, Last_Name, Username, Password, Email, Country from Customer where Username = :username";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("username", OracleType.VarChar).Value = Username;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {   // cmd.ExecuteReader() retrieve data from Oracle
                            while (reader.Read())
                            {
                                txt_firstname.Text = reader["First_Name"].ToString();
                                txt_lastname.Text = reader["Last_Name"].ToString();
                                txt_username.Text = reader["Username"].ToString();
                                txt_pass.Text = reader["Password"].ToString();
                                txt_email.Text = reader["Email"].ToString();
                                combo_country.SelectedItem = reader["Country"].ToString();
                            }
                        }
                    }

                    //Image Display
                    query = "Select Image from Customer where Username = :username";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("username", OracleType.VarChar).Value = Username;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                img = (byte[])reader["Image"];
                                using (MemoryStream ms = new MemoryStream(img))
                                {
                                    // MemoryStream: Converts the byte array to an image.
                                    picbox_insert.Image = System.Drawing.Image.FromStream(ms);
                                    picbox_insert.SizeMode = PictureBoxSizeMode.StretchImage;
                                    //  FromStream read data from memory stream and create image 
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image load failed: " + ex.Message);
            }
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
                    picbox_insert.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    picbox_insert.SizeMode = PictureBoxSizeMode.StretchImage;
                    using (FileStream FS = new FileStream(@openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        // .FileName contains the full file path of the selected file.
                        // FileStream can perform both reading and writing operations
                        img = new byte[FS.Length];
                        // FS.Length size of that img
                        FS.Read(img, 0, (int)(FS.Length));
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

        private void picbox_insert_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            GetImageBytes();
        }
    }
}
