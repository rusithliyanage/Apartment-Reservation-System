using Apartment_Reservation_System.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Reservation_System
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                try
                {
                    FormLogIn formLogIn1 = new FormLogIn();
                    this.Hide();
                    formLogIn1.ShowDialog();
                    //Application.Run(new FormLogIn());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            //MovePanel(buttonDashboard);
            userControlSettings1.Hide();
            userControlLease1.Hide();
            userControlApartment1.Hide();
            userControlReservation1.Hide();
            userControlClients1.Hide();
        }

        private void buttonLease_Click(object sender, EventArgs e)
        {
            MovePanel(buttonLease);
            userControlLease1.Show();
            userControlSettings1.Hide();
            userControlApartment1.Hide();
            userControlReservation1.Hide();
            userControlClients1.Hide();
        }

        private void buttonApartment_Click(object sender, EventArgs e)
        {
            MovePanel(buttonApartment);
            userControlApartment1.Show();
            userControlSettings1.Hide();
            userControlLease1.Hide();
            userControlReservation1.Hide();
            userControlClients1.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlReservation1.Show();
            userControlSettings1.Hide();
            userControlLease1.Hide();
            userControlApartment1.Hide();
            userControlClients1.Hide();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClients);
            userControlClients1.Show();
            userControlSettings1.Hide();
            userControlLease1.Hide();
            userControlApartment1.Hide();
            userControlReservation1.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlSettings1.Clear();
            userControlSettings1.Show();
            userControlLease1.Hide();
            userControlApartment1.Hide();
            userControlClients1.Hide();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
