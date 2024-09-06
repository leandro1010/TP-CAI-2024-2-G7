//using Negocio;
using NEGOCIO.UTILS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.UTILS;

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

            if (!validaciones.ValidarStringVacio(textBox1, textBox2))
            {
                LoginNegocio loginNegocio = new LoginNegocio();
                bool resultado = loginNegocio.ValidarLogin(textBox1.Text, textBox2.Text);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
