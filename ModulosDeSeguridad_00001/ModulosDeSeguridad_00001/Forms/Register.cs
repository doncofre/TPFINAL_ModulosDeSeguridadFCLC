using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            if ( si todos los validadores son true)
            {
                /*Model.Class.User user = new Model.Class.User();
                user.Name = txtName.Text;
                user.Email = txtEmail.Text;
                user.DNI = txtDNI.Text;
                user.Password = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("Cant Sign in the user, try again with another data");
            }*/
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
