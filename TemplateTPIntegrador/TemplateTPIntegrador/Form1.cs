using System;
using System.Windows.Forms;
using PRESENTACION; 
using NEGOCIO;

namespace PRESENTACION
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesYUtiles validaciones = new ValidacionesYUtiles();

            if (!validaciones.ValidarStringVacio(txt_username, txt_password)) // Verifica que los nombres de los controles sean correctos
            {
                LoginNegocio loginNegocio = new LoginNegocio();
                bool resultado = loginNegocio.ValidarLogin(txt_username.Text, txt_password.Text);

                if (resultado)
                {
                    MessageBox.Show("Login exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            // Lógica para cuando el texto cambia en textUsername, si es necesario
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
