using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class InterfazMenu : Ventana
    {
        public InterfazMenu() // Inicializa el menú de navegación 
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private void UsuariosIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "3")
            {
                InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios(); 

                Hide(); 

                InterfazListaUsuarios.FormClosed += (s, args) => Close(); 
                InterfazListaUsuarios.Show(); 
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Usuarios", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


       



        private void BotonSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea volver al inicio de sesión?\n\nSe cerrará la sesión actual.", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
            {
                InterfazLogIn LogIn = new InterfazLogIn(); // Redirigir al LogIn
                LogIn.Show();
                Hide();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Desea volver al inicio de sesión?\n\nSe cerrará la sesión actual.", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazLogIn LogIn = new InterfazLogIn();
                    LogIn.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}