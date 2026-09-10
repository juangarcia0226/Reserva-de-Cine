using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class Funcion
    {
        public int IdFuncion { get; set; }
        public string Descripcion { get; set; }
        public int IdPelicula { get; set; }
        public int IdSala { get; set; }
        public DateTime Fecha { get; set; }
        public string Horario { get; set; }

        public Funcion(int id_funcion, string descripcion, int id_pelicula, int id_sala, DateTime fecha, string horario)
        {
            this.IdFuncion = id_funcion;
            this.Descripcion = descripcion;
            this.IdPelicula = id_pelicula;
            this.IdSala = id_sala;
            this.Fecha = fecha;
            this.Horario = horario;
        }
    }
}
