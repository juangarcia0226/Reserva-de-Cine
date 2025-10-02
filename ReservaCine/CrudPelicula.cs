using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;

namespace ReservaCine
{
    class CrudPelicula
    {
        private string connDB = "Server=localhost;Database=cine;Trusted_Connection=True;";
        
        //Método para traer las películas de la db
        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM pelicula", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    peliculas.Add(new Pelicula(
                        (int)reader["id_pelicula"],
                        (string)reader["titulo"],
                        (string)reader["descripcion"],
                        (int)reader["duracion"],
                        (string)reader["genero"],
                        (DateTime)reader["fecha_estreno"],
                        (string)reader["director"],
                        (string)reader["reparto"]
                    ));
                }
            }
            return peliculas;
        }
        //Método para guardar una nueva película en la db
        public void AddPelicula (Pelicula pelicula)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO pelicula (titulo, descripcion, duracion, genero, fecha_estreno, director, reparto) VALUES (@titulo, @descripcion, @duracion, @genero, @fecha_estreno, @director, @reparto)", conn);
                cmd.Parameters.AddWithValue("@titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                cmd.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                cmd.Parameters.AddWithValue("@genero", pelicula.Genero);
                cmd.Parameters.AddWithValue("@fecha_estreno", pelicula.FechaEstreno);
                cmd.Parameters.AddWithValue("@director", pelicula.Director);
                cmd.Parameters.AddWithValue("@reparto", pelicula.Reparto);
                cmd.ExecuteNonQuery();
            }
        }
        //Método para actualizar una pelícual
        public void UpdatePelicula(Pelicula pelicula)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE pelicula SET titulo = @titulo, descripcion = @descripcion, duracion = @duracion, genero = @genero, fecha_estreno = @fecha_estreno, director = @director, reparto = @reparto WHERE id_pelicula = @id_pelicula", conn);
                cmd.Parameters.AddWithValue("@titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                cmd.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                cmd.Parameters.AddWithValue("@genero", pelicula.Genero);
                cmd.Parameters.AddWithValue("@fecha_estreno", pelicula.FechaEstreno);
                cmd.Parameters.AddWithValue("@director", pelicula.Director);
                cmd.Parameters.AddWithValue("@reparto", pelicula.Reparto);
                cmd.Parameters.AddWithValue("@id_pelicula", pelicula.IdPelicula);
                cmd.ExecuteNonQuery();
            }
        }
        // Método para eliminar una película
        public void DeletePelicula(int id_pelicula)
        {
            using (SqlConnection conn = new SqlConnection(connDB))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM pelicula WHERE id_pelicula = @id_pelicula", conn);
                cmd.Parameters.AddWithValue("@id_pelicula", id_pelicula);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
