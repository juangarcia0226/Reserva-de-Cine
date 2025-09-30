using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Conexión a SQL Server
using System.Data;
using System.Data.SqlClient;

namespace ReservaCine
{
    class CrudUsuario
    {
        //Variable global en la clase para la conexión a la DB
        private string connDB = "Server=localhost;Database=cine;Trusted_Connection=True;";

        //Método para traer los usuarios de la DB
        public List<Usuario> GetUsuarios()
        {
            //Se declara una lista de usuarios vacia
            List<Usuario> usuarios = new List<Usuario>();

            //Using accede a la base de datos y al terminar cierra la conexión
            using (SqlConnection conn = new SqlConnection(connDB)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM usuario", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    usuarios.Add(new Usuario(
                        (string)reader["nombre"],
                        (string)reader["contrasena"],
                        (string)reader["correo"],
                        (int)reader["id_rol"]
                    ));
                }
            }
            return usuarios;
        }
    }
}
