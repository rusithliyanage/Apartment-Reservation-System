using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Reservation_System.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        public UserControlReservation()
        {
            InitializeComponent();
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

        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
