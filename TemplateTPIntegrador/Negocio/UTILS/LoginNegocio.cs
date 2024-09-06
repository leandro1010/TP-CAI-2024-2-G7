using DATOS.UTILS;

namespace NEGOCIO.UTILS
{
    public class LoginNegocio
    {
        public bool ValidarLogin(string usuario, string password)
        {
            LoginDatos loginDatos = new LoginDatos();
            return loginDatos.ExisteUsuario(usuario, password);  // Cambiado a ExisteUsuario
        }
    }
}
