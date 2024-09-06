using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo está vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginNegocio = new LoginNegocio();
              
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
