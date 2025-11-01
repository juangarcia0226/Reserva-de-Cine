using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class CrudFuncion
    {
        private string connDB = "Server=localhost;Database=cine;Trusted_Connection=True;";

        //Método para traer las funciones de la db
        public List<Funcion> GetFuncion()
        {
            List<Funcion> funciones = new List<Funcion>();
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM funcion", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    funciones.Add(new Funcion(
                        (int)reader["id_funcion"],
                        (string)reader["descripcion"],
                        (int)reader["id_pelicula"],
                        (int)reader["id_sala"],
                        (DateTime)reader["fecha"],
                        (string)reader["horario"]
                    ));
                }
            }
            return funciones;
        }

        //Método para guardar una nueva función en la db
        public void AddFuncion(Funcion funcion)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO funcion (descripcion, id_pelicula, id_sala, fecha, horario) VALUES (@descripcion, @id_pelicula, @id_sala, @fecha, @horario)", conn);
                cmd.Parameters.AddWithValue("@descripcion", funcion.Descripcion);
                cmd.Parameters.AddWithValue("@id_pelicula", funcion.IdPelicula);
                cmd.Parameters.AddWithValue("@id_sala", funcion.IdSala);
                cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para actualizar una función
        public void UpdateFuncion(Funcion funcion)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE funcion SET descripcion = @descripcion, id_pelicula = @id_pelicula, id_sala = @id_sala, fecha = @fecha, horario = @horario WHERE id_funcion = @id_funcion", conn);
                cmd.Parameters.AddWithValue("@descripcion", funcion.Descripcion);
                cmd.Parameters.AddWithValue("@id_pelicula", funcion.IdPelicula);
                cmd.Parameters.AddWithValue("@id_sala", funcion.IdSala);
                cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar una función
        public void DeleteFuncion(int id_funcion)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM funcion WHERE id_funcion = @id_funcion", conn);
                cmd.Parameters.AddWithValue("@id_funcion", id_funcion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
