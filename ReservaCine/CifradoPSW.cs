using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ReservaCine
{
    class CifradoPSW
    {
        //Generar hash de la contraseña
        public static string HashPassword(string contrasena)
        {
            return BCrypt.Net.BCrypt.HashPassword(contrasena);
        }

        //Verificar contraseña (para el login)
        public static bool VerificarPassword(string contrasena, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(contrasena, hash);
        }
    }
}
