namespace Medical_Store
{
    partial class Update_Medicine
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update_medicine = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_expirydate = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantitty = new System.Windows.Forms.Label();
            this.lbl_medicine = new System.Windows.Forms.Label();
            this.combobox_medicine = new System.Windows.Forms.ComboBox();
            this.lbl_select_medicine = new System.Windows.Forms.Label();
            this.expiry_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(40, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(229, 41);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "<---- Back to Dashboard";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_update_medicine
            // 
            this.btn_update_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_medicine.Location = new System.Drawing.Point(297, 465);
            this.btn_update_medicine.Name = "btn_update_medicine";
            this.btn_update_medicine.Size = new System.Drawing.Size(277, 56);
            this.btn_update_medicine.TabIndex = 6;
            this.btn_update_medicine.Text = "Update Medicine";
            this.btn_update_medicine.UseVisualStyleBackColor = true;
            this.btn_update_medicine.Click += new System.EventHandler(this.btn_update_medicine_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(484, 316);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(197, 34);
            this.txt_price.TabIndex = 4;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(484, 249);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(197, 34);
            this.txt_quantity.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(484, 184);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(197, 34);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_expirydate
            // 
            this.lbl_expirydate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_expirydate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_expirydate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expirydate.Location = new System.Drawing.Point(220, 382);
            this.lbl_expirydate.Name = "lbl_expirydate";
            this.lbl_expirydate.Size = new System.Drawing.Size(187, 32);
            this.lbl_expirydate.TabIndex = 5;
            this.lbl_expirydate.Text = "Enter Expiry Date:";
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(220, 316);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(187, 32);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "Enter Price:";
            // 
            // lbl_quantitty
            // 
            this.lbl_quantitty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_quantitty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_quantitty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantitty.Location = new System.Drawing.Point(220, 249);
            this.lbl_quantitty.Name = "lbl_quantitty";
            this.lbl_quantitty.Size = new System.Drawing.Size(187, 32);
            this.lbl_quantitty.TabIndex = 7;
            this.lbl_quantitty.Text = "Enter Quantity:";
            // 
            // lbl_medicine
            // 
            this.lbl_medicine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicine.Location = new System.Drawing.Point(220, 182);
            this.lbl_medicine.Name = "lbl_medicine";
            this.lbl_medicine.Size = new System.Drawing.Size(187, 36);
            this.lbl_medicine.TabIndex = 8;
            this.lbl_medicine.Text = "Enter Name:";
            // 
            // combobox_medicine
            // 
            this.combobox_medicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_medicine.Location = new System.Drawing.Point(484, 116);
            this.combobox_medicine.Name = "combobox_medicine";
            this.combobox_medicine.Size = new System.Drawing.Size(197, 36);
            this.combobox_medicine.TabIndex = 1;
            this.combobox_medicine.SelectedIndexChanged += new System.EventHandler(this.combobox_medicine_SelectedIndexChanged);
            // 
            // lbl_select_medicine
            // 
            this.lbl_select_medicine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_select_medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_select_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_medicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_select_medicine.Location = new System.Drawing.Point(220, 118);
            this.lbl_select_medicine.Name = "lbl_select_medicine";
            this.lbl_select_medicine.Size = new System.Drawing.Size(181, 32);
            this.lbl_select_medicine.TabIndex = 16;
            this.lbl_select_medicine.Text = "Select Medicine:";
            // 
            // expiry_date
            // 
            this.expiry_date.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry_date.CustomFormat = "dd-MMM-yyyy";
            this.expiry_date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_date.Location = new System.Drawing.Point(484, 380);
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.Size = new System.Drawing.Size(197, 34);
            this.expiry_date.TabIndex = 5;
            this.expiry_date.Value = new System.DateTime(2025, 4, 3, 0, 0, 0, 0);
            this.expiry_date.ValueChanged += new System.EventHandler(this.date_expiry_ValueChanged);
            // 
            // Update_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 604);
            this.Controls.Add(this.expiry_date);
            this.Controls.Add(this.combobox_medicine);
            this.Controls.Add(this.lbl_select_medicine);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update_medicine);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_expirydate);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantitty);
            this.Controls.Add(this.lbl_medicine);
            this.Name = "Update_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Medicine";
            this.Load += new System.EventHandler(this.Update_Medicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update_medicine;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_expirydate;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantitty;
        private System.Windows.Forms.Label lbl_medicine;
        private System.Windows.Forms.ComboBox combobox_medicine;
        private System.Windows.Forms.Label lbl_select_medicine;
        private System.Windows.Forms.DateTimePicker expiry_date;
    }
}