using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        public void Login(string usuario, string password)
        {
            ValidacionesUtiles validaciones = new ValidacionesUtiles();
            if (validaciones.validarNombreUsuario(usuario, password))

            {

            }
        }
    }
}
