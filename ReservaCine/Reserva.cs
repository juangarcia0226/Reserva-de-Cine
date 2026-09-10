using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class Reserva
    {
        public int IdReserva {  get; set; }
        public int IdUsuario { get; set; }
        public int IdFuncion {  get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int id_reserva, int id_usuario, int id_funcion, DateTime fecha_reserva)
        {
            this.IdReserva = id_reserva;
            this.IdUsuario = id_usuario;
            this.IdFuncion = id_funcion;
            this.FechaReserva = fecha_reserva;
        }
    }
}
