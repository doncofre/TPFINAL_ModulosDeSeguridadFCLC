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
            var enuum = new Model.Class.Enums();

            var NameValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Name, txtName.Text);
            var DNIValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.DNI, txtDNI.Text);
            var EmailValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Email, txtEmail.Text);
            var PasswordValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Password, txtPassword.Text);
            
            
            var EmailDDBB = new Controller.Controllers.ValidInfoUserController((int)enuum.CheckDDBB, (int)enuum.Email, txtEmail.Text);
            var DNIDDBB = new Controller.Controllers.ValidInfoUserController((int)enuum.CheckDDBB, (int)enuum.DNI, txtDNI.Text);


            if (txtEmail == txtReEmail && txtPassword == txtRePassword)
            {
                if (NameValid && DNIValid && EmailValid && PasswordValid && !EmailDDBB && !DNIDDBB)
                {
                    var us = Model.Class.User();
                    us.Name = txtName.Text;
                    us.Email = txtEmail.Text;
                    us.Password = txtPassword.Text;
                    us.DNI = txtDNI.Text;
                    try
                    {
                        Controller.Controllers.UserCtrl(us);
                        MessageBox.Show("User Signed in correctly");

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Cant Sign in user: {0}",err.Message);
                    }
                    


                }
                else
                {
                    MessageBox.Show("Data error: Verify data before submit");
                }





            }
            else
            {
                MessageBox.Show("ERROR: Email or Password aren't equal");
            }




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
