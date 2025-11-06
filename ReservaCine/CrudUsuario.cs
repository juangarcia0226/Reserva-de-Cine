using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class CrudUsuario
    {
        //Variable global en la clase para la conexión a la DB
        //private string connDB = "Server=localhost;Database=cine;Trusted_Connection=True;";

        //Método para traer los usuarios de la DB
        public List<Usuario> GetUsuarios()
        {
            //Se declara una lista de usuarios vacia
            List<Usuario> usuarios = new List<Usuario>();

            //Using accede a la base de datos y al terminar cierra la conexión
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM usuario", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuario(
                    (int)reader["id_usuario"],
                    (string)reader["nombre"],
                    (string)reader["correo"],
                    (string)reader["contrasena"],
                     reader["imagen"] == DBNull.Value ? "" : (string)reader["imagen"],
                    (int)reader["id_rol"]
                    ));
                }
            }
            return usuarios;
        }
        // Método para registrar un usuario a la BDs
        public void AddUsuario(Usuario usuario)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();

                //Cifrar la contraseña antes de guardar 
                string hash = CifradoPSW.HashPassword(usuario.Contrasena);

                SqlCommand cmd = new SqlCommand("INSERT INTO usuario (nombre, correo, contrasena, imagen, id_rol) VALUES (@nombre, @correo, @contrasena, @imagen, @id_rol)", conn);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@contrasena", hash);
                cmd.Parameters.AddWithValue("@imagen", usuario.Imagen ?? "");
                cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para actualizar un usuario
        public void UpdateUsuario(Usuario usuario)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();

                //Cifrar contraseña
                string hash = CifradoPSW.HashPassword(usuario.Contrasena);

                SqlCommand cmd = new SqlCommand("UPDATE usuario SET nombre = @name, contrasena = @psw, correo = @mail, id_rol = @id_rol WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@name", usuario.Nombre);
                cmd.Parameters.AddWithValue("@mail", usuario.Correo);
                cmd.Parameters.AddWithValue("@psw", hash);
                cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un usuario
        public void DeleteUsuario(int id_usuario)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM usuario WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
