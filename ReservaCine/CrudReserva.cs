using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class CrudReserva
    {
        //Métodod para traer las reservas de la db
        public List<Reserva> GetReservas()
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM reserva", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(new Reserva(
                        (int)reader["id_reserva"],
                        (int)reader["id_usuario"],
                        (int)reader["id_funcion"],
                        (DateTime)reader["fecha_reserva"]
                    ));
                }
            }
            return reservas;
        }

        //Método para traer las reservas de un usuario de la db
        public List<Reserva> GetReservasByUser(int id_usuario)
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM reserva WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(new Reserva(
                        (int)reader["id_reserva"],
                        (int)reader["id_usuario"],
                        (int)reader["id_funcion"],
                        (DateTime)reader["fecha_reserva"]
                    ));
                }
            }
            return reservas;
        }

        //Métodod para traer las reserva_asiento de la db
        public List<ReservaAsiento> GetReservaAsiento()
        {
            List<ReservaAsiento> reservas = new List<ReservaAsiento>();
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM reserva_asiento", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(new ReservaAsiento(
                        (int)reader["id_reserva"],
                        (int)reader["id_asiento"]
                    ));
                }
            }
            return reservas;
        }

        //Método para guardar una nueva reserva en la db
        public int AddReserva(Reserva reserva)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO reserva (id_usuario, id_funcion, fecha_reserva) " + "OUTPUT INSERTED.id_reserva " + "VALUES (@id_usuario, @id_funcion, @fecha_reserva)", conn);
                cmd.Parameters.AddWithValue("@id_usuario", reserva.IdUsuario);
                cmd.Parameters.AddWithValue("@id_funcion", reserva.IdFuncion);
                cmd.Parameters.AddWithValue("@fecha_reserva", reserva.FechaReserva);
                
                return (int)cmd.ExecuteScalar();
            }
        }

        //Método para guardar un nuevo reserva_asiento
        public void AddReservaAsiento(int id_reserva, int id_asiento)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO reserva_asiento (id_reserva, id_asiento) VALUES (@id_reserva, @id_asiento)", conn);
                cmd.Parameters.AddWithValue("@id_reserva", id_reserva);
                cmd.Parameters.AddWithValue("@id_asiento", id_asiento);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para actualizar una reserva
        public void UpdateReserva(Reserva reserva)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE reserva SET id_usuario = @id_usuario, id_funcion = @id_funcion, fecha_reserva = @fecha_reserva WHERE id_reserva = @id_reserva", conn);
                cmd.Parameters.AddWithValue("@id_usuario", reserva.IdUsuario);
                cmd.Parameters.AddWithValue("@id_funcion", reserva.IdFuncion);
                cmd.Parameters.AddWithValue("@fecha_reserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@id_reserva", reserva.IdReserva);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para eliminar una reserva
        public void DeleteReserva(int id_reserva)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM reserva WHERE id_reserva = @id_reserva", conn);
                cmd.Parameters.AddWithValue("@id_reserva", id_reserva);
                cmd.ExecuteNonQuery();
            }
        }

        //Método para eliminar una reserva_asiento
        public void DeleteReservaAsiento(int id_reserva)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM reserva_asiento WHERE id_reserva = @id_reserva", conn);
                cmd.Parameters.AddWithValue("@id_reserva", id_reserva);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
