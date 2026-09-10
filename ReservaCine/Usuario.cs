using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }  
        public string Correo { get; set; }
        public string Imagen { get; set; }      
        public int IdRol { get; set; }

        public Usuario(int id_usuario, string nombre, string correo, string contrasena, string imagen, int id_rol)
        {
            this.IdUsuario = id_usuario;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Contrasena = contrasena;
            this.Imagen = imagen;
            this.IdRol = id_rol;
        }
    }
}
