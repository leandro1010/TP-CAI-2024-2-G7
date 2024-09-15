using System;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            ValidacionesYUtiles validaciones = new ValidacionesYUtiles();
            if (validaciones.ValidarStringVacio(txt_username, txt_password))
            {
                return;
            }

            // Validar login
            LoginNegocio loginNegocio = new LoginNegocio();
            if (loginNegocio.ValidarLogin(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login exitoso");
                // Aquí puedes abrir otro formulario si es necesario
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            // Código que se ejecute al cargar el formulario
        }
    }
}
