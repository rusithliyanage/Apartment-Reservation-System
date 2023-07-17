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
    public partial class UserControlLease : UserControl
    {
        public UserControlLease()
        {
            InitializeComponent();
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

        }
    }
}
