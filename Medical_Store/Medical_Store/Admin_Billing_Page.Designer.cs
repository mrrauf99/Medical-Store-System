namespace Medical_Store
{
    partial class Admin_Billing_Page
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_select_medicine = new System.Windows.Forms.Label();
            this.lbl_quantitty = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.combobox_medicine = new System.Windows.Forms.ComboBox();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_clearbill = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_bill_box = new System.Windows.Forms.TextBox();
            this.lbl_customer_id = new System.Windows.Forms.Label();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.Location = new System.Drawing.Point(59, 50);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(482, 64);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to Billing Page";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_select_medicine
            // 
            this.lbl_select_medicine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_select_medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_select_medicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_medicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_select_medicine.Location = new System.Drawing.Point(68, 171);
            this.lbl_select_medicine.Name = "lbl_select_medicine";
            this.lbl_select_medicine.Size = new System.Drawing.Size(195, 32);
            this.lbl_select_medicine.TabIndex = 0;
            this.lbl_select_medicine.Text = "Select Medicine:";
            this.lbl_select_medicine.Click += new System.EventHandler(this.lbl_select_medicine_Click);
            // 
            // lbl_quantitty
            // 
            this.lbl_quantitty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_quantitty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_quantitty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantitty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_quantitty.Location = new System.Drawing.Point(68, 237);
            this.lbl_quantitty.Name = "lbl_quantitty";
            this.lbl_quantitty.Size = new System.Drawing.Size(195, 31);
            this.lbl_quantitty.TabIndex = 0;
            this.lbl_quantitty.Text = "Enter Quantity:";
            this.lbl_quantitty.Click += new System.EventHandler(this.lbl_quantitty_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(330, 234);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(178, 34);
            this.txt_quantity.TabIndex = 2;
            this.txt_quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // combobox_medicine
            // 
            this.combobox_medicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_medicine.Location = new System.Drawing.Point(330, 169);
            this.combobox_medicine.Name = "combobox_medicine";
            this.combobox_medicine.Size = new System.Drawing.Size(178, 36);
            this.combobox_medicine.TabIndex = 1;
            this.combobox_medicine.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_bill
            // 
            this.btn_bill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.Location = new System.Drawing.Point(628, 426);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(156, 44);
            this.btn_bill.TabIndex = 5;
            this.btn_bill.Text = "Generate Bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_enter.Location = new System.Drawing.Point(246, 424);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(99, 46);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_clearbill
            // 
            this.btn_clearbill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearbill.Location = new System.Drawing.Point(1101, 423);
            this.btn_clearbill.Name = "btn_clearbill";
            this.btn_clearbill.Size = new System.Drawing.Size(136, 44);
            this.btn_clearbill.TabIndex = 6;
            this.btn_clearbill.Text = "Clear Bill";
            this.btn_clearbill.UseVisualStyleBackColor = true;
            this.btn_clearbill.Click += new System.EventHandler(this.btn_clearbill_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(38, 565);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(229, 41);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "<---- Back to Dashboard";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_bill_box
            // 
            this.txt_bill_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bill_box.Enabled = false;
            this.txt_bill_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_box.Location = new System.Drawing.Point(628, 50);
            this.txt_bill_box.Multiline = true;
            this.txt_bill_box.Name = "txt_bill_box";
            this.txt_bill_box.Size = new System.Drawing.Size(609, 350);
            this.txt_bill_box.TabIndex = 6;
            this.txt_bill_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_customer_id
            // 
            this.lbl_customer_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_customer_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_customer_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_id.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_customer_id.Location = new System.Drawing.Point(68, 303);
            this.lbl_customer_id.Name = "lbl_customer_id";
            this.lbl_customer_id.Size = new System.Drawing.Size(195, 31);
            this.lbl_customer_id.TabIndex = 0;
            this.lbl_customer_id.Text = "Enter Customer-ID:";
            this.lbl_customer_id.Click += new System.EventHandler(this.lbl_quantitty_Click);
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_id.Location = new System.Drawing.Point(330, 303);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(178, 34);
            this.txt_customer_id.TabIndex = 3;
            this.txt_customer_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Admin_Billing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 638);
            this.Controls.Add(this.txt_bill_box);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clearbill);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.combobox_medicine);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_customer_id);
            this.Controls.Add(this.lbl_quantitty);
            this.Controls.Add(this.lbl_select_medicine);
            this.Controls.Add(this.lbl_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Admin_Billing_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_select_medicine;
        private System.Windows.Forms.Label lbl_quantitty;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.ComboBox combobox_medicine;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_clearbill;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_bill_box;
        private System.Windows.Forms.Label lbl_customer_id;
        private System.Windows.Forms.TextBox txt_customer_id;
    }
}