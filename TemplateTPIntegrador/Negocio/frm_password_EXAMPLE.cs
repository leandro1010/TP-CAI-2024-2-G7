/* Ahora, cuando necesites cambiar una contraseña desde cualquier formulario, asegúrate de usar el método 
 * ChangePassword de la clase UserBusinessLogic para aplicar estas validaciones. Aquí hay un ejemplo simple 
 * de cómo podrías integrarlo en un formulario:*/



using System;
using System.Windows.Forms;
using NEGOCIO;

namespace Presentacion
{
    public partial class frm_someForm : Form
    {
        private UserBusinessLogic userBusinessLogic = new UserBusinessLogic();

        public frm_someForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtNewPassword.Text;
                DateTime lastPasswordChangeDate = GetLastPasswordChangeDate(); // Implementa este método según tu lógica
                string previousPassword = GetPreviousPassword(); // Implementa este método según tu lógica

                userBusinessLogic.ChangePassword("username", newPassword, lastPasswordChangeDate, previousPassword);

                MessageBox.Show("Contraseña cambiada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private DateTime GetLastPasswordChangeDate()
        {
            // Implementa la lógica para obtener la fecha del último cambio de contraseña
            return DateTime.Now.AddDays(-10); // Ejemplo
        }

        private string GetPreviousPassword()
        {
            // Implementa la lógica para obtener la contraseña anterior
            return "OldPassword123"; // Ejemplo
        }
    }
}
