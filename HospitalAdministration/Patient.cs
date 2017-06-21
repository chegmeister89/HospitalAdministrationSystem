using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdministration
{
    class Patient : Person //Inheriting from person class
    {
        public int PatID { get; set; }

        public string GetAllPatients()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(PatID);
            sb.Append(" ");
            sb.Append(base.GetAll());  
            return sb.ToString();
        }

    }

}
