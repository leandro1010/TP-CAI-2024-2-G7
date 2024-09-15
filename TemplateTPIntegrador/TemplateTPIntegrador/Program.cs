using System;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_login()); // Asegúrate de que 'frm_login' esté en el espacio de nombres correcto
        }
    }
}
