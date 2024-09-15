namespace DATOS
{
    public class LoginDatos
    {
        public bool ExisteUsuario(string usuario, string password)
        {
            // Simulación de verificación de múltiples usuarios
            if ((usuario == "admin" && password == "1234") ||
                (usuario == "lean" && password == "4321") ||
                (usuario == "mica" && password == "5678") ||
                (usuario == "juli" && password == "8765") ||
                (usuario == "flor" && password == "1357") ||
                (usuario == "marti" && password == "2468"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
