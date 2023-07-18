using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Apartment_Reservation_System.Classes
{
    internal class Clerk
    {
        public string sqlConnString = @"Data Source=DESKTOP-C2D8DI8\SQLEXPRESS;Initial Catalog=Apartment_Reservation_System;Integrated Security=True;";
        
        public string ConnString(string constr)
        {
            return constr;
        }
        public static void main(string[] args)
        {
            
        }

        
    }
}
