using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class CrudSala
    {
        private string connDB = "Server=localhost;Database=cine;Trusted_Connection=True;";
        //Método para traer las salas de la db
        public List<Sala> GetSalas()
        {
            List<Sala> salas = new List<Sala>();
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM sala", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    salas.Add(new Sala(
                        (int)reader["id_sala"],
                        (string)reader["nombre"],
                        (int)reader["capacidad"],
                        (int)reader["filas"],
                        (int)reader["columnas"],
                        (string)reader["tipo"],
                        (bool)reader["estado"]
                    ));
                }
            }
            return salas;
        }
        //Método para guardar una nueva sala en la db
        public void AddSala(Sala sala)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sala (nombre, capacidad, filas, columnas, tipo, estado) VALUES (@nombre, @capacidad, @filas, @columnas, @tipo, @estado)", conn);
                cmd.Parameters.AddWithValue("@nombre", sala.Nombre);
                cmd.Parameters.AddWithValue("@capacidad", sala.Capacidad);
                cmd.Parameters.AddWithValue("@filas", sala.Filas);
                cmd.Parameters.AddWithValue("@columnas", sala.Columnas);
                cmd.Parameters.AddWithValue("@tipo", sala.Tipo);
                cmd.Parameters.AddWithValue("@estado", sala.Estado);
                cmd.ExecuteNonQuery();
            }
        }
        //Método para actualizar una sala
        public void UpdateSala(Sala sala)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE sala SET nombre = @nombre, capacidad = @capacidad, filas = @filas, columnas = @columnas, tipo = @tipo, estado = @estado WHERE id_sala = @id_sala", conn);
                cmd.Parameters.AddWithValue("@nombre", sala.Nombre);
                cmd.Parameters.AddWithValue("@capacidad", sala.Capacidad);
                cmd.Parameters.AddWithValue("@filas", sala.Filas);
                cmd.Parameters.AddWithValue("@columnas", sala.Columnas);
                cmd.Parameters.AddWithValue("@tipo", sala.Tipo);
                cmd.Parameters.AddWithValue("@estado", sala.Estado);
                cmd.Parameters.AddWithValue("@id_sala", sala.IdSala);
                cmd.ExecuteNonQuery();
            }
        }
        // Método para eliminar una sala
        public void DeleteSala(int id_sala)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM sala WHERE id_sala = @id_sala", conn);
                cmd.Parameters.AddWithValue("@id_pelicula", id_sala);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
