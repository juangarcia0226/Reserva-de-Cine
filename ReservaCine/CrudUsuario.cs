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
                        (int)reader["id_usuario"],
                        (string)reader["nombre"],
                        (string)reader["contrasena"],
                        (string)reader["correo"],
                        (int)reader["id_rol"]
                    ));
                }
            }
            return usuarios;
        }
        // Método para registrar un usuario a la BDs
        public void AddUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand InsertUser = new SqlCommand("INSERT INTO usuario (nombre, contrasena, correo, id_rol) VALUES (@name, @mail, @psw, @id_rol);", conn);
                InsertUser.Parameters.AddWithValue("@name", usuario.Nombre);
                InsertUser.Parameters.AddWithValue("@mail", usuario.Correo);
                InsertUser.Parameters.AddWithValue("@psw", usuario.Contrasena);
                InsertUser.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                InsertUser.ExecuteNonQuery();
            }
        }

        //Método para actualizar un usuario
        public void UpdateUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE usuario SET nombre = @name, contrasena = @psw, correo = @mail, id_rol = @id_rol WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@name", usuario.Nombre);
                cmd.Parameters.AddWithValue("@mail", usuario.Correo);
                cmd.Parameters.AddWithValue("@psw", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un usuario
        public void DeleteUsuario(int id_usuario)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM usuario WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
