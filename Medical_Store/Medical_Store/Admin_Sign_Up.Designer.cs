using System;

namespace Medical_Store
{
    partial class Admin_Sign_Up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_back_login = new System.Windows.Forms.Button();
            this.lbl_pic = new System.Windows.Forms.Label();
            this.btn_pic = new System.Windows.Forms.Button();
            this.picbox_insert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_insert)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_firstname.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(51, 123);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(112, 30);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(51, 174);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(110, 30);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(51, 225);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(106, 30);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(51, 280);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(99, 30);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(51, 333);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 30);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(51, 388);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(87, 30);
            this.lbl_country.TabIndex = 5;
            this.lbl_country.Text = "Country";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.Location = new System.Drawing.Point(279, 123);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(220, 34);
            this.txt_firstname.TabIndex = 1;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Location = new System.Drawing.Point(279, 174);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(220, 34);
            this.txt_lastname.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(279, 222);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(220, 34);
            this.txt_username.TabIndex = 3;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(279, 274);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(220, 34);
            this.txt_pass.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(279, 330);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(220, 34);
            this.txt_email.TabIndex = 5;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // combo_country
            // 
            this.combo_country.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Items.AddRange(new object[] {
            "Afghanistan",
            "",
            "Albania",
            "",
            "Algeria",
            "",
            "Andorra",
            "",
            "Angola",
            "",
            "Argentina",
            "",
            "Armenia",
            "",
            "Australia",
            "",
            "Austria",
            "",
            "Azerbaijan",
            "",
            "Bahamas",
            "",
            "Bahrain",
            "",
            "Bangladesh",
            "",
            "Barbados",
            "",
            "Belarus",
            "",
            "Belgium",
            "",
            "Belize",
            "",
            "Benin",
            "",
            "Bhutan",
            "",
            "Bolivia",
            "",
            "Bosnia and Herzegovina",
            "",
            "Botswana",
            "",
            "Brazil",
            "",
            "Brunei",
            "",
            "Bulgaria",
            "",
            "Burkina Faso",
            "",
            "Burundi",
            "",
            "Cambodia",
            "",
            "Cameroon",
            "",
            "Canada",
            "",
            "Cape Verde",
            "",
            "Central African Republic",
            "",
            "Chad",
            "",
            "Chile",
            "",
            "China",
            "",
            "Colombia",
            "",
            "Comoros",
            "",
            "Congo",
            "",
            "Costa Rica",
            "",
            "Croatia",
            "",
            "Cuba",
            "",
            "Cyprus",
            "",
            "Czech Republic",
            "",
            "Denmark",
            "",
            "Djibouti",
            "",
            "Dominica",
            "",
            "Dominican Republic",
            "",
            "East Timor",
            "",
            "Ecuador",
            "",
            "Egypt",
            "",
            "El Salvador",
            "",
            "Equatorial Guinea",
            "",
            "Eritrea",
            "",
            "Estonia",
            "",
            "Eswatini",
            "",
            "Ethiopia",
            "",
            "Fiji",
            "",
            "Finland",
            "",
            "France",
            "",
            "Gabon",
            "",
            "Gambia",
            "",
            "Georgia",
            "",
            "Germany",
            "",
            "Ghana",
            "",
            "Greece",
            "",
            "Grenada",
            "",
            "Guatemala",
            "",
            "Guinea",
            "",
            "Guinea-Bissau",
            "",
            "Guyana",
            "",
            "Haiti",
            "",
            "Honduras",
            "",
            "Hungary",
            "",
            "Iceland",
            "",
            "India",
            "",
            "Indonesia",
            "",
            "Iran",
            "",
            "Iraq",
            "",
            "Ireland",
            "",
            "Israel",
            "",
            "Italy",
            "",
            "Ivory Coast",
            "",
            "Jamaica",
            "",
            "Japan",
            "",
            "Jordan",
            "",
            "Kazakhstan",
            "",
            "Kenya",
            "",
            "Kiribati",
            "",
            "Kuwait",
            "",
            "Kyrgyzstan",
            "",
            "Laos",
            "",
            "Latvia",
            "",
            "Lebanon",
            "",
            "Lesotho",
            "",
            "Liberia",
            "",
            "Libya",
            "",
            "Liechtenstein",
            "",
            "Lithuania",
            "",
            "Luxembourg",
            "",
            "Madagascar",
            "",
            "Malawi",
            "",
            "Malaysia",
            "",
            "Maldives",
            "",
            "Mali",
            "",
            "Malta",
            "",
            "Marshall Islands",
            "",
            "Mauritania",
            "",
            "Mauritius",
            "",
            "Mexico",
            "",
            "Micronesia",
            "",
            "Moldova",
            "",
            "Monaco",
            "",
            "Mongolia",
            "",
            "Montenegro",
            "",
            "Morocco",
            "",
            "Mozambique",
            "",
            "Myanmar ",
            "",
            "Namibia",
            "",
            "Nauru",
            "",
            "Nepal",
            "",
            "Netherlands",
            "",
            "New Zealand",
            "",
            "Nicaragua",
            "",
            "Niger",
            "",
            "Nigeria",
            "",
            "North Korea",
            "",
            "North Macedonia",
            "",
            "Norway",
            "",
            "Oman",
            "",
            "Pakistan",
            "",
            "Palau",
            "",
            "Panama",
            "",
            "Papua New Guinea",
            "",
            "Paraguay",
            "",
            "Peru",
            "",
            "Philippines",
            "",
            "Poland",
            "",
            "Portugal",
            "",
            "Qatar",
            "",
            "Romania",
            "",
            "Russia",
            "",
            "Rwanda",
            "",
            "Saint Kitts and Nevis",
            "",
            "Saint Lucia",
            "",
            "Samoa",
            "",
            "San Marino",
            "",
            "Saudi Arabia",
            "",
            "Senegal",
            "",
            "Serbia",
            "",
            "Seychelles",
            "",
            "Sierra Leone",
            "",
            "Singapore",
            "",
            "Slovakia",
            "",
            "Slovenia",
            "",
            "Solomon Islands",
            "",
            "Somalia",
            "",
            "South Africa",
            "",
            "South Korea",
            "",
            "South Sudan",
            "",
            "Spain",
            "",
            "Sri Lanka",
            "",
            "Sudan",
            "",
            "Suriname",
            "",
            "Sweden",
            "",
            "Switzerland",
            "",
            "Syria",
            "",
            "Taiwan",
            "",
            "Tajikistan",
            "",
            "Tanzania",
            "",
            "Thailand",
            "",
            "Togo",
            "",
            "Tonga",
            "",
            "Tunisia",
            "",
            "Turkey",
            "",
            "Turkmenistan",
            "",
            "Tuvalu",
            "",
            "Uganda",
            "",
            "Ukraine",
            "",
            "UAE",
            "",
            "United Kingdom",
            "",
            "USA",
            "",
            "Uruguay",
            "",
            "Uzbekistan",
            "",
            "Vanuatu",
            "",
            "Vatican City",
            "",
            "Venezuela",
            "",
            "Vietnam",
            "",
            "Yemen",
            "",
            "Zambia",
            "",
            "Zimbabwe"});
            this.combo_country.Location = new System.Drawing.Point(279, 383);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(220, 36);
            this.combo_country.TabIndex = 6;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_signup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_signup.Location = new System.Drawing.Point(149, 453);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(108, 42);
            this.btn_signup.TabIndex = 8;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.Location = new System.Drawing.Point(48, 29);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(250, 48);
            this.lbl_signup.TabIndex = 13;
            this.lbl_signup.Text = "Sign Up Form";
            this.lbl_signup.Click += new System.EventHandler(this.label7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_back_login
            // 
            this.btn_back_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_login.Location = new System.Drawing.Point(51, 556);
            this.btn_back_login.Name = "btn_back_login";
            this.btn_back_login.Size = new System.Drawing.Size(223, 41);
            this.btn_back_login.TabIndex = 9;
            this.btn_back_login.Text = "<---- Back to Login";
            this.btn_back_login.UseVisualStyleBackColor = true;
            // 
            // lbl_pic
            // 
            this.lbl_pic.AutoSize = true;
            this.lbl_pic.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pic.Location = new System.Drawing.Point(887, 90);
            this.lbl_pic.Name = "lbl_pic";
            this.lbl_pic.Size = new System.Drawing.Size(75, 28);
            this.lbl_pic.TabIndex = 54;
            this.lbl_pic.Text = "Picture";
            this.lbl_pic.Click += new System.EventHandler(this.lbl_pic_Click);
            // 
            // btn_pic
            // 
            this.btn_pic.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pic.Location = new System.Drawing.Point(840, 365);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(173, 47);
            this.btn_pic.TabIndex = 7;
            this.btn_pic.Text = "Upload Picture";
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // picbox_insert
            // 
            this.picbox_insert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_insert.Location = new System.Drawing.Point(800, 123);
            this.picbox_insert.Name = "picbox_insert";
            this.picbox_insert.Size = new System.Drawing.Size(250, 230);
            this.picbox_insert.TabIndex = 52;
            this.picbox_insert.TabStop = false;
            this.picbox_insert.Click += new System.EventHandler(this.picbox_insert_Click_1);
            // 
            // Admin_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 619);
            this.Controls.Add(this.lbl_pic);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.picbox_insert);
            this.Controls.Add(this.btn_back_login);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.combo_country);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Name = "Admin_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            this.Load += new System.EventHandler(this.Admin_Sign_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_insert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Admin_Sign_Up_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_insert_img_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_signup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_back_login;
        private System.Windows.Forms.Label lbl_pic;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.PictureBox picbox_insert;
    }
}