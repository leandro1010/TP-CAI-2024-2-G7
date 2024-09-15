using System;

namespace NEGOCIO
{
    public static class PasswordExpirationChecker
    {
        private static readonly int PasswordExpirationDays = 30;

        public static bool IsPasswordExpired(DateTime lastPasswordChangeDate)
        {
            // Calcula la diferencia en días entre la fecha actual y la última fecha de cambio de contraseña
            return (DateTime.Now - lastPasswordChangeDate).TotalDays > PasswordExpirationDays;
        }
    }
}
