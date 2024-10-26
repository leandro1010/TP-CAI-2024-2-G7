using System;

namespace NEGOCIO
{
    public class UserBusinessLogic
    {
        public bool ChangePassword(string username, string newPassword, DateTime lastPasswordChangeDate, string previousPassword)
        {
            if (!PasswordValidator.ValidatePassword(newPassword))
            {
                throw new ArgumentException("La contraseña debe contener al menos una letra mayúscula y un número.");
            }

            if (PasswordExpirationChecker.IsPasswordExpired(lastPasswordChangeDate))
            {
                throw new InvalidOperationException("La contraseña ha expirado. Debe cambiarla.");
            }

            if (newPassword == previousPassword)
            {
                throw new ArgumentException("La nueva contraseña no puede ser igual a la anterior.");
            }

            // Aquí iría el código para actualizar la contraseña en la base de datos
            return true;
        }
    }
}
