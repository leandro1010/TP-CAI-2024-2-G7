using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesUtiles
    {
        public Boolean validarNombreUsuario(string usuario, string password)
        {
            if (usuario.Length < 0)
            {
                return true;
            }
            return false;
        }
    }
}
