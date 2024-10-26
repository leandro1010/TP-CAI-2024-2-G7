using NEGOCIO;
using System;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class frm_login : Form
    {
        private LoginNegocio loginNegocio;

        public frm_login()
        {
            InitializeComponent();
            loginNegocio = new LoginNegocio(); // Inicializar la capa de negocio
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txt_username.Text;
            string password = txt_password.Text;

            if (ValidarCampos())
            {
                if (loginNegocio.ValidarLogin(usuario, password))
                {
                    // Login exitoso, abre el formulario principal
                    frm_main mainForm = new frm_main();
                    mainForm.Show(); // Muestra el nuevo formulario
                    this.Hide(); // Oculta el formulario de login
                }
                else
                {
                    // Mostrar mensaje de error si las credenciales son incorrectas
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            // Código que deseas ejecutar cuando el formulario se carga, si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
