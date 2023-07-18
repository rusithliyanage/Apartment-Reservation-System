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
    public partial class UserControlClients : UserControl
    {
        public string sqlConnString = @"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;";
        public UserControlClients()
        {
            InitializeComponent();
        }
        public void GetClient(string NIC)
        {
            string sql = "SELECT * FROM Clients WHERE NicOrPassportNo=@NIC_PP";
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlConnString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.Parameters.AddWithValue("@NIC_PP", NIC);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewClient.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearchUsername_Click(object sender, EventArgs e)
        {
            GetClient(textBoxSearchUsername.Text.Trim());
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
