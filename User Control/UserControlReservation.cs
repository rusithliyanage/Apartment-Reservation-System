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
    public partial class UserControlReservation : UserControl
    {
        public string sqlConnString = @"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;";
        public UserControlReservation()
        {
            InitializeComponent();
        }
        public bool SubmitReserveAgreement(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11)
        {
            bool SubmitStatus = false;
            string sql = "INSERT INTO ReserveAgreements VALUES (@V1,@V2,@V3,@V4,@V5,@V6,@V7,@V8,@V9,@V10,@V11)";
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlConnString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@V1", v1);
                    sqlCommand.Parameters.AddWithValue("@V2", v2);
                    sqlCommand.Parameters.AddWithValue("@V3", v3);
                    sqlCommand.Parameters.AddWithValue("@V4", v4);
                    sqlCommand.Parameters.AddWithValue("@V5", v5);
                    sqlCommand.Parameters.AddWithValue("@V6", v6);
                    sqlCommand.Parameters.AddWithValue("@V7", v7);
                    sqlCommand.Parameters.AddWithValue("@V8", v8);
                    sqlCommand.Parameters.AddWithValue("@V9", v9);
                    sqlCommand.Parameters.AddWithValue("@V10", v10);
                    sqlCommand.Parameters.AddWithValue("@V11", v11);

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
        public bool AddToQueue(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11)
        {
            bool SubmitStatus = false;
            string sql = "INSERT INTO WaitingLists VALUES (@V1,@V2,@V3,@V4,@V5,@V6,@V7,@V8,@V9,@V10,@V11)";
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlConnString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@V1", v1);
                    sqlCommand.Parameters.AddWithValue("@V2", v2);
                    sqlCommand.Parameters.AddWithValue("@V3", v3);
                    sqlCommand.Parameters.AddWithValue("@V4", v4);
                    sqlCommand.Parameters.AddWithValue("@V5", v5);
                    sqlCommand.Parameters.AddWithValue("@V6", v6);
                    sqlCommand.Parameters.AddWithValue("@V7", v7);
                    sqlCommand.Parameters.AddWithValue("@V8", v8);
                    sqlCommand.Parameters.AddWithValue("@V9", v9);
                    sqlCommand.Parameters.AddWithValue("@V10", v10);
                    sqlCommand.Parameters.AddWithValue("@V11", v11);

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
            textBoxFullName1.Clear();
            textBoxNicOrPassportNo1.Clear();
            textBoxAltAddress1.Clear();
            textBoxEmgContact1.Clear();
            textBoxDependents1.Clear();
            comboBoxLocation1 = null;
            comboBoxAptClass1 = null;
            textBoxAptNo1.Clear();
            dateTimePickerDateOfOccp = null;
            textBoxTimePeriod1.Clear();
            textBoxDeposit1.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            bool check;
            bool str =
                string.IsNullOrEmpty(textBoxFullName1.Text) ||
                string.IsNullOrEmpty(textBoxNicOrPassportNo1.Text) ||
                string.IsNullOrEmpty(textBoxAltAddress1.Text) ||
                string.IsNullOrEmpty(textBoxEmgContact1.Text) ||
                string.IsNullOrEmpty(textBoxDependents1.Text) ||
                string.IsNullOrEmpty(comboBoxLocation1.Text) ||
                string.IsNullOrEmpty(comboBoxAptClass1.Text) ||
                string.IsNullOrEmpty(textBoxAptNo1.Text) ||
                string.IsNullOrEmpty(dateTimePickerDateOfOccp.Text) ||
                string.IsNullOrEmpty(textBoxTimePeriod1.Text) ||
                string.IsNullOrEmpty(textBoxDeposit1.Text);

            if (str)
            {
                MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = SubmitReserveAgreement(
                    textBoxFullName1.Text.Trim(),
                    textBoxNicOrPassportNo1.Text.Trim(),
                    textBoxAltAddress1.Text.Trim(),
                    textBoxEmgContact1.Text.Trim(),
                    textBoxDependents1.Text.Trim(),
                    comboBoxLocation1.Text,
                    comboBoxAptClass1.Text,
                    textBoxAptNo1.Text.Trim(),
                    dateTimePickerDateOfOccp.Text,
                    textBoxTimePeriod1.Text.Trim(),
                    textBoxDeposit1.Text.Trim()
                    );
                if (check)
                {
                    Clear();
                    MessageBox.Show("Reserve Agreement added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Somthing went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {
            bool check;
            bool str =
                string.IsNullOrEmpty(textBoxFullName1.Text) ||
                string.IsNullOrEmpty(textBoxNicOrPassportNo1.Text) ||
                string.IsNullOrEmpty(textBoxAltAddress1.Text) ||
                string.IsNullOrEmpty(textBoxEmgContact1.Text) ||
                string.IsNullOrEmpty(textBoxDependents1.Text) ||
                string.IsNullOrEmpty(comboBoxLocation1.Text) ||
                string.IsNullOrEmpty(comboBoxAptClass1.Text) ||
                string.IsNullOrEmpty(textBoxAptNo1.Text) ||
                string.IsNullOrEmpty(dateTimePickerDateOfOccp.Text) ||
                string.IsNullOrEmpty(textBoxTimePeriod1.Text) ||
                string.IsNullOrEmpty(textBoxDeposit1.Text);

            if (str)
            {
                MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = AddToQueue (
                    textBoxFullName1.Text.Trim(),
                    textBoxNicOrPassportNo1.Text.Trim(),
                    textBoxAltAddress1.Text.Trim(),
                    textBoxEmgContact1.Text.Trim(),
                    textBoxDependents1.Text.Trim(),
                    comboBoxLocation1.Text,
                    comboBoxAptClass1.Text,
                    textBoxAptNo1.Text.Trim(),
                    dateTimePickerDateOfOccp.Text,
                    textBoxTimePeriod1.Text.Trim(),
                    textBoxDeposit1.Text.Trim()
                    );
                if (check)
                {
                    Clear();
                    MessageBox.Show("Added to waiting list successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Somthing went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
