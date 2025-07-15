namespace Medical_Store
{
    partial class Admin_Dashboard
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
            this.btn_add_medicine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_billing_page = new System.Windows.Forms.Button();
            this.btn_update_medicine = new System.Windows.Forms.Button();
            this.btn_del_medicine = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_medicine
            // 
            this.btn_add_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_add_medicine.Location = new System.Drawing.Point(296, 253);
            this.btn_add_medicine.Name = "btn_add_medicine";
            this.btn_add_medicine.Size = new System.Drawing.Size(286, 52);
            this.btn_add_medicine.TabIndex = 2;
            this.btn_add_medicine.Text = "Add  Medicine";
            this.btn_add_medicine.UseVisualStyleBackColor = true;
            this.btn_add_medicine.Click += new System.EventHandler(this.btn_new_medicine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(185, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome To Medical Store";
            // 
            // btn_billing_page
            // 
            this.btn_billing_page.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing_page.Location = new System.Drawing.Point(296, 164);
            this.btn_billing_page.Name = "btn_billing_page";
            this.btn_billing_page.Size = new System.Drawing.Size(286, 52);
            this.btn_billing_page.TabIndex = 1;
            this.btn_billing_page.Text = "Billing Page";
            this.btn_billing_page.UseVisualStyleBackColor = true;
            this.btn_billing_page.Click += new System.EventHandler(this.btn_billing_page_Click);
            // 
            // btn_update_medicine
            // 
            this.btn_update_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_medicine.Location = new System.Drawing.Point(296, 343);
            this.btn_update_medicine.Name = "btn_update_medicine";
            this.btn_update_medicine.Size = new System.Drawing.Size(286, 52);
            this.btn_update_medicine.TabIndex = 3;
            this.btn_update_medicine.Text = "Update Medicine";
            this.btn_update_medicine.UseVisualStyleBackColor = true;
            this.btn_update_medicine.Click += new System.EventHandler(this.btn_update_medicine_Click);
            // 
            // btn_del_medicine
            // 
            this.btn_del_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_medicine.Location = new System.Drawing.Point(296, 435);
            this.btn_del_medicine.Name = "btn_del_medicine";
            this.btn_del_medicine.Size = new System.Drawing.Size(286, 52);
            this.btn_del_medicine.TabIndex = 4;
            this.btn_del_medicine.Text = "Delete Medicine";
            this.btn_del_medicine.UseVisualStyleBackColor = true;
            this.btn_del_medicine.Click += new System.EventHandler(this.btn_del_medicine_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(34, 532);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(190, 41);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<---- Back To Login";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 611);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_del_medicine);
            this.Controls.Add(this.btn_update_medicine);
            this.Controls.Add(this.btn_billing_page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add_medicine);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_medicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_billing_page;
        private System.Windows.Forms.Button btn_update_medicine;
        private System.Windows.Forms.Button btn_del_medicine;
        private System.Windows.Forms.Button btn_back;
    }
}