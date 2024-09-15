using System;
using System.Linq;

namespace NEGOCIO
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            // Verifica si la contraseña contiene al menos una letra mayúscula y un número
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);

            return hasUpperCase && hasDigit;
        }
    }
}
