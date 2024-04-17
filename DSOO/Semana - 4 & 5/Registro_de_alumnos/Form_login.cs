namespace Registro_de_alumnos
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if ( txtName.Text.Trim() == "Administrador" && txtPass.Text.Trim() == "Admin1234")
            {
                Register register = new Register(this);
                this.Hide();
                register.ShowDialog();
            } else
            {
                Alert loginAlert = new Alert("Usuario o contraseña invalidos");
                loginAlert.ShowDialog();
            }
        }
    }
}
