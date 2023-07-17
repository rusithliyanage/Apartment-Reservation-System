﻿namespace Apartment_Reservation_System.User_Control
{
    partial class UserControlApartment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearchUsername = new System.Windows.Forms.Button();
            this.textBoxSearchUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNowText Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Apartments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonSearchUsername
            // 
            this.buttonSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.buttonSearchUsername.FlatAppearance.BorderSize = 0;
            this.buttonSearchUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUsername.Font = new System.Drawing.Font("HelveticaNowText Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUsername.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUsername.Location = new System.Drawing.Point(738, 144);
            this.buttonSearchUsername.Name = "buttonSearchUsername";
            this.buttonSearchUsername.Size = new System.Drawing.Size(138, 31);
            this.buttonSearchUsername.TabIndex = 14;
            this.buttonSearchUsername.Text = "Search";
            this.buttonSearchUsername.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchUsername
            // 
            this.textBoxSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchUsername.Location = new System.Drawing.Point(367, 145);
            this.textBoxSearchUsername.Name = "textBoxSearchUsername";
            this.textBoxSearchUsername.Size = new System.Drawing.Size(347, 25);
            this.textBoxSearchUsername.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNowText Regular", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apartment Class No:";
            // 
            // UserControlApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonSearchUsername);
            this.Controls.Add(this.textBoxSearchUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HelveticaNowText Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlApartment";
            this.Size = new System.Drawing.Size(1240, 635);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearchUsername;
        private System.Windows.Forms.TextBox textBoxSearchUsername;
        private System.Windows.Forms.Label label3;
    }
}
