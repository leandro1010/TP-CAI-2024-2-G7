using Datos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Negocio
{
    public static class Validar
    {
        public static string EsNombre(string text, string nombreCampo)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(text))
            {
                return $"No se especificó el {nombreCampo}.";
            }

            // Verificar si el texto tiene menos de 3 caracteres
            if (text.Length < 3)
            {
                return $"El {nombreCampo} debe tener al menos 3 caracteres.";
            }

            // Verificar si el texto contiene números
            if (text.Any(char.IsDigit))
            {
                return $"El {nombreCampo} no puede tener números.";
            }

            // Verificar si el texto contiene caracteres especiales excepto espacios
            if (text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return $"El {nombreCampo} no puede tener caracteres especiales."; // Saco al espaciado como "caracter especial".
            }
            // Si pasa todas las condiciones, el texto es válido
            return null; // Retorna null si el nombre es válido
        }

        public static string EsDNI(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo DNI no puede estar vacío.";
            }

            // Verificar si el texto tiene longitud diferente de 8 dígitos
            if (texto.Length != 8)
            {
                return "El campo DNI debe tener exactamente 8 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo DNI debe contener solo dígitos numéricos.";
            }

            // Verificar si el número de DNI ya existe en la lista de usuarios, clientes y proveedores

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            List<UsuariosActivos> usuarios = usuarioNegocio.ListarUsuarios();
            usuarios = usuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList(); // Filtrar usuarios cuyo NombreUsuario empiece por "G1"

            string dni = texto;
            int dniNumero;

            if (int.TryParse(dni, out dniNumero))
            {
                if (usuarios.Exists(u => u.DNI == dniNumero))
                {
                    return "Este DNI ya existe como usuario.";
                }
            }
return null;
        }

        
        public static string EsEdadLaboral(DateTime fechaNacimiento)
        {
            {
                DateTime fechaHoy = DateTime.Today;// Obtener la fecha de hoy
                if
                (fechaNacimiento >= fechaHoy) // Verificar si la fecha de nacimiento es mayor o igual al día de hoy
                {
                    return
                    "No se puede seleccionar un día posterior a hoy."
                    ;
                }

                else
                {
                    DateTime fechaHace18 = fechaHoy.AddYears(-18);
                    // Calcular fecha de hace 18 años
                    DateTime fechaHace65 = fechaHoy.AddYears(-65);
                    // Calcular fecha de hace 65 años

                    if
                    (fechaNacimiento >= fechaHace18) // Verificar si la fecha de nacimiento está entre hace 18 y hace 65 años

                    {
                        return
                        "No se permite incorporar usuarios menores de edad."
                        ;
                    }

                    else if
                    (fechaNacimiento <= fechaHace65)
                    {
                        return
                        "No se permite incorporar usuarios en edad jubilatoria."
                        ;
                    }

                    else
                    {
                        return
                        null; // Si la fecha de nacimiento cumple con los requisitos, no hay error
                    }
                }
            }
        }

        public static string EsDireccion(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Dirección no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 3 || texto.Length > 50)
            {
                return "El campo Dirección debe tener entre 3 y 50 caracteres.";
            }

            // Verificar si la cadena contiene caracteres especiales
            if (!texto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                return "El campo Dirección no puede contener caracteres especiales.";
            }

            // Si se cumplen todas las condiciones, la calle es válida
            return null;
        }

        public static string EsTelefono(string texto)
        {
            // Verificar si el texto tiene longitud fuera del rango de 8 a 12 dígitos
            if (texto.Length < 8 || texto.Length > 12)
            {
                return "El campo Teléfono debe tener entre 8 y 12 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo Teléfono debe contener únicamente dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static string EsMail(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @Grupo7.com
            string patronCorreo = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string patronDominio = @"@Grupo7\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo electrónico es inválido.";
            }

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }
            if (!Regex.IsMatch(texto, patronDominio))
            {
                return "El correo electrónico ser del dominio @Grupo7.com";
            }

            return null;

        }

        public static string ConfirmarMail(string correo, string confirmation)
        {
            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(confirmation))
            {
                return "Ambos campos de correo electrónico son obligatorios.";
            }

            // Verificar si los correos electrónicos coinciden ignorando mayúsculas y minúsculas
            if (correo.Equals(confirmation, StringComparison.OrdinalIgnoreCase))
            {
                return null; // Si los correos coinciden, retornar null indicando que no hay error
            }
            else
            {
                return "Los correos electrónicos no coinciden.";
            }
        }

        public static string EsContraseña(string Contraseña)
        {
            // Verificar si la contraseña está vacía
            if (string.IsNullOrEmpty(Contraseña))
            {
                return "El campo de contraseña no puede estar vacío.";
            }

            bool mayuscula = false;
            bool numero = false;

            for (int i = 0; i < Contraseña.Length; i++)
            {
                if (Char.IsUpper(Contraseña, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsDigit(Contraseña, i))
                {
                    numero = true;
                }
            }

            // Verificar si la contraseña cumple con los criterios de validez
            if (numero && mayuscula && Contraseña.Length >= 8 && Contraseña.Length < 15)
            {
                return null; // Si la contraseña es válida, retornar null indicando que no hay error
            }

            return "La contraseña debe tener al menos una mayúscula, un número y tener entre 8 y 14 caracteres.";
        }

        public static string ConfirmarContraseña(string Contraseña, string confirmation)
        {
            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(confirmation))
            {
                return "Ambos campos de contraseña son obligatorios.";
            }

            // Verificar si las contraseñas coinciden
            if (Contraseña == confirmation)
            {
                return null; // Si las contraseñas coinciden, retornar null indicando que no hay error
            }
            else
            {
                return "Las contraseñas no coinciden.";
            }
        }

        public static string CampoEnBlanco(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "1";
            }

            return "0";
        }

        public static int EsID(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return 0; // Devuelve 0 si el texto está vacío
            }

            // Expresión regular para validar un UUID en formato de hash
            string patron = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            // Verifica si el texto coincide con el patrón de expresión regular
            if (Regex.IsMatch(texto, patron))
            {
                return 1; // Devuelve 1 si el texto es un hash UUID válido
            }
            else
            {
                return 2; // Devuelve 2 si el texto no es un hash UUID válido
            }
        }

        public static string NumeroHost(string nombreUsuario)
        {
            if (nombreUsuario == "ADMINI24")
            {
                // Devuelve el número de host para el administrador
                return "3";
            }

            // Listar todos los usuarios activos
            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
            List<UsuariosActivos> usuarios = UsuarioNegocio.ListarUsuarios();

            // Buscar el usuario por el nombre de usuario ingresado
            UsuariosActivos usuarioEncontrado = usuarios.FirstOrDefault(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            // Si se encuentra el usuario, devolver su número de host
            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.Host;
            }
            else
            {
                return null;
            }
        }

        public static bool UsuarioInactivo(string usuario)
        {
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (File.Exists(path))
                {
                    string[] lineasTXT = File.ReadAllLines(path);

                    foreach (string linea in lineasTXT)
                    {
                        if (linea.StartsWith(usuario + ";"))
                        {
                            string[] parametros = linea.Split(';');
                            if (parametros.Length > 3)
                            {
                                string estado = parametros[3];
                                if (estado == "inactivo")
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public static bool ContraseñaExpirada(string usuario)
        {
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (File.Exists(path))
                {
                    string[] lineasTXT = File.ReadAllLines(path);

                    foreach (string linea in lineasTXT)
                    {
                        if (linea.StartsWith(usuario + ";"))
                        {
                            string[] parametros = linea.Split(';');
                            if (parametros.Length > 2)
                            {
                                string UltimoCambio = parametros[2];
                                DateTime fechaUltimoCambio = DateTime.ParseExact(UltimoCambio, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                                int diasExpiracion = 30; // Si pasaron 30 días
                                if (DateTime.Now.Subtract(fechaUltimoCambio).TotalDays > diasExpiracion)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        }
    }
