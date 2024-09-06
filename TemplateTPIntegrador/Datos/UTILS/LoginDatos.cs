namespace DATOS.UTILS
{
    public class LoginDatos
    {
        public bool ExisteUsuario(string usuario, string password)
        {
            // Aquí iría la lógica para consultar la base de datos.
            // Por ahora, simulamos la existencia de un usuario.
            if (usuario == "admin" && password == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
