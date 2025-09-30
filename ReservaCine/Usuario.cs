using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; } 
        public Usuario(string nombre, string contrasena, string correo, int idrol) 
        {
            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Correo = correo;
            this.IdRol = idrol;
        }
    }
}
