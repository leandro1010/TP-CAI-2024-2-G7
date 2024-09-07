using System;
using System.Windows.Forms;
using TemplateTPIntegrador.UTILS; // Verifica que este namespace sea correcto
using DATOS; // Verifica que este namespace sea correcto
using NEGOCIO;

namespace TemplateTPIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesYUtiles validaciones = new ValidacionesYUtiles();

            if (!validaciones.ValidarStringVacio(textUsername, textPassword)) // Verifica que los nombres de los controles sean correctos
            {
                LoginNegocio loginNegocio = new LoginNegocio();
                bool resultado = loginNegocio.ValidarLogin(textUsername.Text, textPassword.Text);

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
    }
}
