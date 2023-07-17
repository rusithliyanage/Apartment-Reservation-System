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
    public partial class UserControlLease : UserControl
    {
        public UserControlLease()
        {
            InitializeComponent();
        }
        public bool SubmitLeaseAgreement(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11, string v12)
        {
            bool SubmitStatus = false;
            string sql = "INSERT INTO LeaseAgreement (User_Name,First_Name,Last_Name,User_Password) VALUES (@userName, @FirstName, @LastName, @passWord)";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@userName", v1);
                    sqlCommand.Parameters.AddWithValue("@FirstName", v2);
                    sqlCommand.Parameters.AddWithValue("@LastName", v3);
                    sqlCommand.Parameters.AddWithValue("@passWord", v4);

                    int queryStatus = (int)sqlCommand.ExecuteNonQuery();

                    if (queryStatus > 0)
                    {
                        SubmitStatus = true;
                        conn.Close();
                        return SubmitStatus;
                    }
                    else
                    {
                        return SubmitStatus;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return SubmitStatus;
            }
            
        }
        public void Clear()
        {
            textBoxFullName.Clear();
            textBoxNicOrPassportNo.Clear();
            textBoxAltAddress.Clear();
            textBoxEmgContact.Clear();
            textBoxDependents.Clear();
            comboBoxLocation= null;
            comboBoxAptClass = null;
            textBoxAptNo.Clear();
            dateTimePickerLeaseExpDate = null;
            textBoxTimePeriod.Clear();
            textBoxDeposit.Clear();
            textBoxFirstMonthRent.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UserControlLease_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool check;
            bool str = 
                string.IsNullOrEmpty(textBoxFullName.Text) || 
                string.IsNullOrEmpty(textBoxNicOrPassportNo.Text) || 
                string.IsNullOrEmpty(textBoxAltAddress.Text) || 
                string.IsNullOrEmpty(textBoxEmgContact.Text) ||
                string.IsNullOrEmpty(textBoxDependents.Text) ||
                string.IsNullOrEmpty(comboBoxLocation.Text) ||
                string.IsNullOrEmpty(comboBoxAptClass.Text) ||
                string.IsNullOrEmpty(textBoxAptNo.Text) ||
                string.IsNullOrEmpty(dateTimePickerLeaseExpDate.Text)||
                string.IsNullOrEmpty(textBoxTimePeriod.Text)||
                string.IsNullOrEmpty(textBoxDeposit.Text) ||
                string.IsNullOrEmpty(textBoxFirstMonthRent.Text);
    
            if (str)
            {
                MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = SubmitLeaseAgreement(
                    textBoxFullName.Text.Trim(),
                    textBoxNicOrPassportNo.Text.Trim(),
                    textBoxAltAddress.Text.Trim(),
                    textBoxEmgContact.Text.Trim(),
                    textBoxDependents.Text.Trim(),
                    comboBoxLocation.Text,
                    comboBoxAptClass.Text,
                    textBoxAptNo.Text.Trim(),
                    dateTimePickerLeaseExpDate.Text,
                    textBoxTimePeriod.Text.Trim(),
                    textBoxDeposit.Text.Trim(),
                    textBoxFirstMonthRent.Text.Trim()
                    );
                if (check)
                {
                    Clear();
                    MessageBox.Show("Lease Agreement added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Somthing went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
