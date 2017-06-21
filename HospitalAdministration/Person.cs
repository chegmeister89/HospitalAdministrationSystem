using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdministration
{
    class Person
    {
        //get set is setting and retrieving the value of the strings
        public string Title { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DOB { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }




        public string GetAll()

        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Title);
            sb.Append(" ");
            sb.Append(FirstName);
            sb.Append(" ");
            sb.Append(LastName);
            sb.Append(" ");
            sb.Append(DOB);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Phone);
            return sb.ToString();


        }


        public string GetPatientNames()

        {

            StringBuilder sb = new StringBuilder();
            sb.Append(FirstName);
            sb.Append(" ");
            sb.Append(LastName);
            sb.Append(" ");
            return sb.ToString();


        }

        public string GetStaffNames()

        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FirstName);
            sb.Append(" ");
            sb.Append(LastName);
            sb.Append(" ");
            return sb.ToString();
        }

        public string GetContacts()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(FirstName);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Phone);
            return sb.ToString();

        }



    }
}
