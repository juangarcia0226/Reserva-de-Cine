using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    class Pelicula
    {
        public int IdPelicula {  get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public string Genero { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Director {  get; set; }
        public string Reparto { get; set; }
        public Pelicula(int id_pelicula, string titulo, string descripcion, int duracion, string genero, DateTime fecha_estreno, string director, string reparto)
        {
            this.IdPelicula = id_pelicula;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Duracion = duracion;   
            this.Genero = genero;
            this.FechaEstreno = fecha_estreno;
            this.Director = director;
            this.Reparto = reparto;
        }
    }
}
