using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace HospitalAdministration
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
     
        {
          
            string User = txtUsername.Text;
            string Pass = txtPassword.Text;

            if (User == "Username")
            {
                if (Pass == "Password")
                {

                    MessageBox.Show("Login Successful");
                    Form1 f = new Form1();
                    f.Show();
                }

                else
                    MessageBox.Show("Password is incorrect please try again");


            }

            else
                MessageBox.Show("Username is incorrect please try again");

             

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //terminates application 
        }
    }
}
