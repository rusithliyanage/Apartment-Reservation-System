using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Reservation_System.User_Control
{
    public partial class UserControlSettings : UserControl
    {
        private string ID = "";
        public UserControlSettings()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPassword.Clear();
            //tabControlUser.SelectedTab = tabPageAllUsers;
        }
        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }
        public bool AddUser(string Uname, string Fname, string Lname, string pwd)
        {
            bool status = false;
            string sql = "INSERT INTO User_Table (User_Name,First_Name,Last_Name,User_Password) VALUES (@userName, @FirstName, @LastName, @passWord)";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@userName", Uname);
                    sqlCommand.Parameters.AddWithValue("@FirstName", Fname);
                    sqlCommand.Parameters.AddWithValue("@LastName", Lname);
                    sqlCommand.Parameters.AddWithValue("@passWord", pwd);
                    int queryStatus = (int)sqlCommand.ExecuteNonQuery();

                    if (queryStatus > 0)
                    {
                        status = true;
                        return status;
                    }
                    else
                    {
                        return status;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return status;
            }
        }

        public void GetUser(string userName)
        {
            string sql = "SELECT User_ID,User_Name,First_Name,Last_Name FROM User_Table WHERE User_Name=@userName";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@userName", userName);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewUser.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBoxSearchUsername_Enter(object sender, EventArgs e)
        {
            GetUser(textBoxSearchUsername.Text.Trim());
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateOrDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxFirstName.Text.Trim() == string.Empty || textBoxLastName.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = AddUser(textBoxUsername.Text.Trim(), textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPassword.Text.Trim());
                if (check)
                {
                    Clear();
                    MessageBox.Show("User added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username alredy exits or somthing went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabPageAllUsers_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM User_Table";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewAllUsers.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = AddUser(textBoxUsername.Text.Trim(), textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPassword.Text.Trim());
                    if (check)
                    {
                        Clear();
                        MessageBox.Show("User added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = AddUser(textBoxUsername.Text.Trim(), textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPassword.Text.Trim());
                    if (check)
                    {
                        Clear();
                        MessageBox.Show("User added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            dataGridViewAllUsers.ClearSelection();
        }

        private void buttonSearchUsername_Click(object sender, EventArgs e)
        {
            GetUser(textBoxSearchUsername.Text.Trim());
        }
    }
}
