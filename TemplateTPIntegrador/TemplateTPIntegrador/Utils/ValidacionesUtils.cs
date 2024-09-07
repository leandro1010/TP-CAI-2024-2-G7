using System.Windows.Forms;

namespace TemplateTPIntegrador.UTILS
{
    public class ValidacionesYUtiles
    {
        public bool ValidarStringVacio(TextBox textBox1, TextBox textBox2)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Usuario está vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo Contraseña está vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
