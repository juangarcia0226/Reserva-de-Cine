using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class CrudAsiento
    {
        //Método para traer los asientos de la db
        public List<Asiento> GetAsientos(int id_funcion)
        {
            List<Asiento> asientos = new List<Asiento>();
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM asiento WHERE id_funcion = @id_funcion", conn);
                cmd.Parameters.AddWithValue("@id_funcion", id_funcion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asientos.Add(new Asiento(
                        (int)reader["id_asiento"],
                        (int)reader["id_funcion"],
                        (string)reader["codigo"],
                        (bool)reader["disponible"]
                    ));
                }
            }
            return asientos;
        }

        //Método para guardar una nuevo asiento en la db
        public void AddAsiento(Asiento asiento)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO asiento (id_funcion, codigo, disponible) VALUES (@id_funcion, @codigo, @disponible)", conn);
                cmd.Parameters.AddWithValue("@id_funcion", asiento.IdFuncion);
                cmd.Parameters.AddWithValue("@codigo", asiento.Codigo);
                cmd.Parameters.AddWithValue("@disponible", asiento.Disponible);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para actualizar un asiento
        public void UpdateAsiento(Asiento asiento)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE asiento SET id_funcion = @id_funcion, codigo = @codigo, disponible = @disponible WHERE id_asiento = @id_asiento", conn);
                cmd.Parameters.AddWithValue("@id_funcion", asiento.IdFuncion);
                cmd.Parameters.AddWithValue("@codigo", asiento.Codigo);
                cmd.Parameters.AddWithValue("@disponible", asiento.Disponible); 
                cmd.Parameters.AddWithValue("@id_asiento", asiento.IdAsiento);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para actualizar estado en un asiento
        public void UpdateAsientoEstado(int id_asiento, bool disponible)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE asiento SET disponible = @disponible WHERE id_asiento = @id_asiento", conn);
                cmd.Parameters.AddWithValue("@id_asiento", id_asiento);
                cmd.Parameters.AddWithValue("@disponible", disponible);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para eliminar un asiento
        public void DeleteAsiento(int id_asiento)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM asiento WHERE id_asiento = @id_asiento", conn);
                cmd.Parameters.AddWithValue("@id_asiento", id_asiento);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
