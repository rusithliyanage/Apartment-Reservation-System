using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace Apartment_Reservation_System
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private bool IsValidUser(string userName, string passWord)
        {
            bool loginSuccessful = false;
            string sql = "SELECT COUNT(*) FROM User_Table WHERE User_Name=@userName AND [User_Password]=@passWord";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@userName", userName);
                    sqlCommand.Parameters.AddWithValue("@passWord", passWord);
                    int loginStatus = (int)sqlCommand.ExecuteScalar();

                    if (loginStatus == 1)
                    {
                        loginSuccessful = true;
                        conn.Close();
                        return loginSuccessful;
                    }
                    else
                    {
                        return loginSuccessful;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return loginSuccessful;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void FormLogIn_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool check = IsValidUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if(textBoxUsername.Text.Trim() == string.Empty ||
                textBoxPassword.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Please fill out all fields.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (check)
                {
                    FormDashboard Fd = new FormDashboard();
                    Fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    Fd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "username or password", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
