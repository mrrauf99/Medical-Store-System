namespace Medical_Store
{
    partial class Delete_Medicine
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
            this.combobox_medicine = new System.Windows.Forms.ComboBox();
            this.lbl_select_medicine = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_del_medicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_medicine
            // 
            this.combobox_medicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_medicine.Location = new System.Drawing.Point(468, 124);
            this.combobox_medicine.Name = "combobox_medicine";
            this.combobox_medicine.Size = new System.Drawing.Size(197, 36);
            this.combobox_medicine.TabIndex = 1;
            // 
            // lbl_select_medicine
            // 
            this.lbl_select_medicine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_select_medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_select_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_medicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_select_medicine.Location = new System.Drawing.Point(204, 126);
            this.lbl_select_medicine.Name = "lbl_select_medicine";
            this.lbl_select_medicine.Size = new System.Drawing.Size(181, 32);
            this.lbl_select_medicine.TabIndex = 19;
            this.lbl_select_medicine.Text = "Select Medicine:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(24, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(229, 41);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "<---- Back to Dashboard";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_del_medicine
            // 
            this.btn_del_medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_medicine.Location = new System.Drawing.Point(293, 215);
            this.btn_del_medicine.Name = "btn_del_medicine";
            this.btn_del_medicine.Size = new System.Drawing.Size(277, 56);
            this.btn_del_medicine.TabIndex = 2;
            this.btn_del_medicine.Text = "Delete Medicine";
            this.btn_del_medicine.UseVisualStyleBackColor = true;
            this.btn_del_medicine.Click += new System.EventHandler(this.btn_del_medicine_Click);
            // 
            // Delete_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 456);
            this.Controls.Add(this.btn_del_medicine);
            this.Controls.Add(this.combobox_medicine);
            this.Controls.Add(this.lbl_select_medicine);
            this.Controls.Add(this.btn_back);
            this.Name = "Delete_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Medicine";
            this.Load += new System.EventHandler(this.Delete_Medicine_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_medicine;
        private System.Windows.Forms.Label lbl_select_medicine;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_del_medicine;
    }
}