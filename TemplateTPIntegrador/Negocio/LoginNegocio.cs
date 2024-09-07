using DATOS;

namespace NEGOCIO
{
    public class LoginNegocio
    {
        public bool ValidarLogin(string usuario, string password)
        {
            LoginDatos loginDatos = new LoginDatos();
            return loginDatos.ExisteUsuario(usuario, password);
        }
    }
}
