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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var NameValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Name, txtName.Text);
            var DNIValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.DNI, txtDNI.Text);
            var EmailValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Email, txtEmail.Text);
            var PasswordValid = new Controller.Controllers.ValidInfoUserController((int)enuum.ValidType, (int)enuum.Password, txtPassword.Text);






            txtName.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtProfile.Clear();

            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtDNI.Enabled = false;
            txtPassword.Enabled = false;
            txtProfile.Enabled = false;
            btnEdit.Enabled = false;


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {




            dgvUsers.DataSource = listusers;






        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsers.Row; // renglon seleccionado

            if (row)
            {
                btnEdit.Enabled = true;

                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtDNI.Enabled = true;
                txtPassword.Enabled = true;
                txtProfile.Enabled = true;
                btnEdit.Enabled = true;



                txtName.Text = row.name;
                txtEmail.Text = row.email;
                txtDNI.Text = row.dni;
                txtPassword.Text = row.password;
                txtProfile.Text = row.profile;

            }
            

        }
    }
}
