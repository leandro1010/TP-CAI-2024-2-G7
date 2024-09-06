using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public class ValidacionesYUtiles
    {
        public Boolean ValidarStringVacio() {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo textBox1 está vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo textBox2 está vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true ;
            }
            else
            {
                // Aquí iría el código a ejecutar si ambos TextBox no están vacíos
                return false
            }
        }
    }
    }
}



   