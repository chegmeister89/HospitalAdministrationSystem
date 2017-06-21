using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAdministration
{
    public partial class Form1 : Form
    {
        PeopleList p = new PeopleList();
        PeopleList s = new PeopleList();
        BindingSource bs = new BindingSource(); //Binding source is being used to represent the data in the lists
        public Form1()
        {
            InitializeComponent();
        }

        //private method to search patients
        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            try
            {
                string title = cmbPatTitle.SelectedItem.ToString();
                string fname = txtPatFirstName.Text;
                string lname = txtPatLastName.Text;
                string dob = dtpPat.Text;
                int id = int.Parse(txtPatID.Text);
                string email = txtPatEmail.Text;
                string phone = txtPatPhone.Text;

                lblDisplayRemarks.Text = p.AddPatient(title, fname, lname, dob, id, email, phone);

            }
            catch
            {
                MessageBox.Show("Patient Added");

            }
            txtPatFirstName.Text = "";
            txtPatLastName.Text = "";
            txtPatPhone.Text = "";
            txtPatID.Text = "";
            txtPatEmail.Text = "";

        }

        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            foreach (Patient p in p.Pats)
            {
                lstDisplay.Items.Add(p.GetAllPatients());
            }


        }

        private void btnPatientNames_Click(object sender, EventArgs e)
        {
            foreach (Patient p in p.Pats)
            {
                lstDisplay.Items.Add(p.GetPatientNames());
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            foreach (Patient p in p.Pats)
            {
                lstDisplay.Items.Add(p.GetContacts());
            }


        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            foreach (Patient p in p.Pats)
            {
                lstDisplay.Items.Add(p.ToString());
                MessageBox.Show("Patient Found");
            }
            ConvertListToDataTable();
        }
            
        void ConvertListToDataTable()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = p.Pats;
            dgv.DataSource = bs; //displays list

        }



        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {

                int removeid = int.Parse(txtPatRemove.Text);
                lblDisplayRemarks.Text = p.DeletePatient(removeid);


            }
            catch
            {
                MessageBox.Show("You must enter a valid input");

            }

        }



        private void btnStaffAdd_Click(object sender, EventArgs e)

        {
            try
            {

                string title = cmbStaffTitle.SelectedItem.ToString();
                string fname = txtStaffFirstName.Text;
                string lname = txtStaffLastName.Text;
                string dob = dtpStaff.Text;
                int id = int.Parse(txtStaffID.Text);
                string email = txtStaffEmail.Text;
                string phone = txtStaffPhone.Text;

                lblDisplayRemarks.Text = s.AddStaff(title, fname, lname, dob, id, email, phone);
            }
            catch
            {
                MessageBox.Show("Staff Added");
            }

            txtStaffFirstName.Text = "";
            txtStaffLastName.Text = "";
            txtStaffPhone.Text = "";
            txtStaffID.Text = "";
            txtStaffEmail.Text = "";

        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            foreach (Staff s in s.Staff)
            {
                lstDisplay.Items.Add(s.GetAllStaff());
            }



        }

        private void btnStaffNames_Click(object sender, EventArgs e)
        {
            foreach (Staff s in s.Staff)
            {
                lstDisplay.Items.Add(s.GetStaffNames());
            }



        }

        private void btnStaffContact_Click(object sender, EventArgs e)
        {
            foreach (Staff s in s.Staff)
            {
                lstDisplay.Items.Add(s.GetContacts());
            }




        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            foreach (Staff s in s.Staff)
            {
                lstDisplay.Items.Add(s.ToString());
                MessageBox.Show("Staff Found");
            }
            ConvertListToTable();
        }

        void ConvertListToTable()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = s.Staff;
            dgv.DataSource = bs;

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {

                int removeid = int.Parse(txtStaffRemove.Text);
                lblDisplayRemarks.Text = s.DeleteStaff(removeid);


            }
            catch
            {
                MessageBox.Show("You must enter a valid input");
            }

        }


    }


}



