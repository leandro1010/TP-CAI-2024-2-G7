using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_login()); // Asegúrate de que esté referenciado el formulario correcto
        }
    }
}
