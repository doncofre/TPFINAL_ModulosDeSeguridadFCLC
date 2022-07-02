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
            var user = new View.Forms.FormUser();
            user.Show();


        }
    }
}