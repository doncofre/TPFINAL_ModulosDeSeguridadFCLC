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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            int asd = 1;
            if (asd == 1)
            {
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var useredit = new View.Forms.EditUser();
            useredit.ShowDialog();
        }
    }
}
