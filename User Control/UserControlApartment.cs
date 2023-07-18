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
    public partial class UserControlApartment : UserControl
    {
        public string sqlConnString = @"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;";
        public UserControlApartment()
        {
            InitializeComponent();
        }
        public void GetAvailableApartments(string AptClass)
        {
            string sql = "SELECT * FROM Apartments WHERE AptClass=@aptClass";
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlConnString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@aptClass", AptClass);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewAvlApartments.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void UserControlApartment_Load(object sender, EventArgs e)
        {
            GetAvailableApartments(textBoxSearchUsername.Text);
        }

        private void buttonSearchUsername_Click(object sender, EventArgs e)
        {
            GetAvailableApartments(textBoxSearchUsername.Text);
        }
    }
}
