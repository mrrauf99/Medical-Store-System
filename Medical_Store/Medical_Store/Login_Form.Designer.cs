namespace Medical_Store
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pnl_logo1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_storename2 = new System.Windows.Forms.Label();
            this.lbl_storename1 = new System.Windows.Forms.Label();
            this.pnl_home = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.pic_loginlogo = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_suggest = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_logo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_home.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_logo1
            // 
            this.pnl_logo1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnl_logo1.Controls.Add(this.pictureBox3);
            this.pnl_logo1.Controls.Add(this.lbl_storename2);
            this.pnl_logo1.Controls.Add(this.lbl_storename1);
            this.pnl_logo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_logo1.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo1.Name = "pnl_logo1";
            this.pnl_logo1.Size = new System.Drawing.Size(316, 661);
            this.pnl_logo1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pic_loginlogo_Click);
            // 
            // lbl_storename2
            // 
            this.lbl_storename2.AutoSize = true;
            this.lbl_storename2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storename2.Location = new System.Drawing.Point(13, 284);
            this.lbl_storename2.Name = "lbl_storename2";
            this.lbl_storename2.Size = new System.Drawing.Size(285, 38);
            this.lbl_storename2.TabIndex = 0;
            this.lbl_storename2.Text = "Management System";
            this.lbl_storename2.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_storename1
            // 
            this.lbl_storename1.AutoSize = true;
            this.lbl_storename1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storename1.Location = new System.Drawing.Point(54, 246);
            this.lbl_storename1.Name = "lbl_storename1";
            this.lbl_storename1.Size = new System.Drawing.Size(191, 38);
            this.lbl_storename1.TabIndex = 0;
            this.lbl_storename1.Text = "Medical Store";
            this.lbl_storename1.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // pnl_home
            // 
            this.pnl_home.BackColor = System.Drawing.Color.White;
            this.pnl_home.Controls.Add(this.button1);
            this.pnl_home.Controls.Add(this.panel2);
            this.pnl_home.Controls.Add(this.pic_loginlogo);
            this.pnl_home.Controls.Add(this.panel3);
            this.pnl_home.Controls.Add(this.btn_login);
            this.pnl_home.Controls.Add(this.btn_signup);
            this.pnl_home.Controls.Add(this.lbl_suggest);
            this.pnl_home.Controls.Add(this.lbl_login);
            this.pnl_home.Location = new System.Drawing.Point(315, 0);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(754, 661);
            this.pnl_home.TabIndex = 9;
            this.pnl_home.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_home_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(480, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Forget Password?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_pass);
            this.panel2.Location = new System.Drawing.Point(67, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 70);
            this.panel2.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(284, 24);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(296, 34);
            this.txt_pass.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(129, 25);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(97, 28);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Password";
            // 
            // pic_loginlogo
            // 
            this.pic_loginlogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_loginlogo.Image")));
            this.pic_loginlogo.Location = new System.Drawing.Point(291, 66);
            this.pic_loginlogo.Name = "pic_loginlogo";
            this.pic_loginlogo.Size = new System.Drawing.Size(104, 96);
            this.pic_loginlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_loginlogo.TabIndex = 17;
            this.pic_loginlogo.TabStop = false;
            this.pic_loginlogo.Click += new System.EventHandler(this.pic_loginlogo_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(365, 544);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(141, 41);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_signup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_signup.Location = new System.Drawing.Point(310, 441);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(90, 40);
            this.btn_signup.TabIndex = 3;
            this.btn_signup.Text = "SignUp";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_suggest
            // 
            this.lbl_suggest.AutoSize = true;
            this.lbl_suggest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suggest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_suggest.Location = new System.Drawing.Point(112, 448);
            this.lbl_suggest.Name = "lbl_suggest";
            this.lbl_suggest.Size = new System.Drawing.Size(197, 25);
            this.lbl_suggest.TabIndex = 13;
            this.lbl_suggest.Text = "Don\'t have an account?";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_login.Location = new System.Drawing.Point(195, 188);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(300, 38);
            this.lbl_login.TabIndex = 12;
            this.lbl_login.Text = "Login to Your Account";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(129, 22);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(104, 28);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(283, 22);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(297, 34);
            this.txt_username.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbl_username);
            this.panel3.Location = new System.Drawing.Point(67, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 70);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 661);
            this.Controls.Add(this.pnl_logo1);
            this.Controls.Add(this.pnl_home);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_From_Load);
            this.pnl_logo1.ResumeLayout(false);
            this.pnl_logo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_home.ResumeLayout(false);
            this.pnl_home.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_logo1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_storename1;
        private System.Windows.Forms.Label lbl_storename2;
        private System.Windows.Forms.Panel pnl_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.PictureBox pic_loginlogo;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_suggest;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_username;
    }
}

