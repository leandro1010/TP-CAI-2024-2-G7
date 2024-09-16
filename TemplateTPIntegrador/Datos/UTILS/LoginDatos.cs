namespace DATOS
{
    public class LoginDatos
    {
        public bool ExisteUsuario(string usuario, string password)
        {
            // Simulación de verificación de usuario
            return usuario == "admin" && password == "1234";
        }
    }
}
