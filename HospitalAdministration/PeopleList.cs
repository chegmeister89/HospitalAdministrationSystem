using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAdministration
{
    public class PeopleList
    {
        internal List<Patient> Pats; //internal keyword is restricting access to the contents of the list
        internal List<Staff> Staff;

        public PeopleList()
        {
            Pats = new List<Patient>();
            Staff = new List<Staff>();
        }

        public string AddPatient(string title, string fn, string ln, string dob, int id, string email, string phone)

        { //Contents of patient list
            Patient p = new Patient();
            p.Title = title;
            p.FirstName = fn;
            p.LastName = ln;
            p.DOB = dob;
            p.PatID = id;
            p.Email = email;
            p.Phone = phone;

            Pats.Add(p);

            return "Added Patient to list";
        }

        public string AddStaff(string title, string fn, string ln, string dob, int id, string email, string phone)

        {   //Contents of staff list
            Staff s = new Staff();
            s.Title = title;
            s.FirstName = fn;
            s.LastName = ln;
            s.DOB = dob;
            s.StaffID = id;
            s.Email = email;
            s.Phone = phone;

            Staff.Add(s);

            return "Added Staff to list";


        }
        //Delete patient method
        public string DeletePatient(int PatID)
        {
            for (int i = 0; i < Pats.Count; i++)
            {
                Patient c = Pats[i];

                if (c.PatID == PatID)
                {
                    DialogResult dr = MessageBox.Show("Delete" + c.ToString(), "Delete", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.OK)
                    {
                        Pats.Remove(c);
                        return "Patient Record Deleted";

                    }

                }


            }

            return "No Match Found";
        }

        public string SearchPatient(int PatID)
        {
            for (int i = 0; i < Pats.Count; i++)
            {
                Patient c = Pats[i];

                if (c.PatID == PatID)
                {
                    DialogResult dr = MessageBox.Show("Search" + c.ToString(), "Search", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.OK)
                    {
                        Pats.Remove(c);
                        return "Patient Found";

                    }

                }


            }

            return "Match Found";

        }


        //Delete staff method
        public string DeleteStaff(int StaffID)
        {
            for (int b = 0; b < Staff.Count; b++)
            {
                Staff d = Staff[b];

                if (d.StaffID == StaffID)
                {
                    DialogResult dr = MessageBox.Show("Delete" + d.ToString(), "Delete", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.OK)
                    {
                        Staff.Remove(d);
                        return "Staff Record Deleted";

                    }

                }

            }

            return "No Match Found";

        }
        //Delete staff method
        public string SearchStaff(int StaffID)
        {
            for (int b = 0; b < Staff.Count; b++)
            {
                Staff d = Staff[b];

                if (d.StaffID == StaffID)
                {
                    DialogResult dr = MessageBox.Show("Search" + d.ToString(), "Search", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.OK)
                    {
                        Staff.Remove(d);
                        return "Staff Record Found";

                    }

                }

            }

            return "Match Found";


        }

    }

}




    

    
