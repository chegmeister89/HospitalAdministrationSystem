using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdministration
{
    class Staff : Person
    {
        public int StaffID { get; set; }

        public string GetAllStaff()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(StaffID);
            sb.Append(" ");
            sb.Append(base.GetAll());
            return sb.ToString();


        }

    }

}
