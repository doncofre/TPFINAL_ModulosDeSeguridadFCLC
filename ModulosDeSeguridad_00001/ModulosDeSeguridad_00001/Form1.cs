using View.Forms;

namespace ModulosDeSeguridad_00001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var enuum = new Model.Class.Enums();
            var validEmail = new Controller.Controllers.ValidInfoUserController((int)enuum.CheckDDBB, (int)enuum.Email, txtUser.Text);

            /*using (var ctx = new entity)
            {
                var usu = ctx.User.Where(x => x.Email == txtUser.Text).FirstOrDefault();
                if (txtPassword.Text == usu.Password)
                {

                }

            }*/


            if (validEmail && ValidPassword(txtUser.Text,txtPassword.Text) )
            {
                var user = new View.Forms.FormUser();
                user.Show();
            }
            else
            {
                MessageBox.Show("Error: Incorrect User or password");
            }




            


        }
    }
}