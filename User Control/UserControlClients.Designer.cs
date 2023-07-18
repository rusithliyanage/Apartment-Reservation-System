namespace Apartment_Reservation_System.User_Control
{
    partial class UserControlClients
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
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonSearchUsername = new System.Windows.Forms.Button();
            this.textBoxSearchUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HelveticaNowText Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.label13.Location = new System.Drawing.Point(38, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "Client Details";
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(23, 138);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(1575, 306);
            this.dataGridViewClient.TabIndex = 8;
            // 
            // buttonSearchUsername
            // 
            this.buttonSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.buttonSearchUsername.FlatAppearance.BorderSize = 0;
            this.buttonSearchUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUsername.Font = new System.Drawing.Font("HelveticaNowText Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUsername.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUsername.Location = new System.Drawing.Point(947, 90);
            this.buttonSearchUsername.Name = "buttonSearchUsername";
            this.buttonSearchUsername.Size = new System.Drawing.Size(138, 31);
            this.buttonSearchUsername.TabIndex = 11;
            this.buttonSearchUsername.Text = "Search";
            this.buttonSearchUsername.UseVisualStyleBackColor = false;
            this.buttonSearchUsername.Click += new System.EventHandler(this.buttonSearchUsername_Click);
            // 
            // textBoxSearchUsername
            // 
            this.textBoxSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchUsername.Location = new System.Drawing.Point(576, 91);
            this.textBoxSearchUsername.Name = "textBoxSearchUsername";
            this.textBoxSearchUsername.Size = new System.Drawing.Size(347, 22);
            this.textBoxSearchUsername.TabIndex = 10;
            this.textBoxSearchUsername.TextChanged += new System.EventHandler(this.textBoxSearchUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNowText Regular", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "NIC/Passport No:";
            // 
            // UserControlClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonSearchUsername);
            this.Controls.Add(this.textBoxSearchUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.label13);
            this.Name = "UserControlClients";
            this.Size = new System.Drawing.Size(1616, 462);
            this.Load += new System.EventHandler(this.UserControlClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonSearchUsername;
        private System.Windows.Forms.TextBox textBoxSearchUsername;
        private System.Windows.Forms.Label label3;
    }
}
