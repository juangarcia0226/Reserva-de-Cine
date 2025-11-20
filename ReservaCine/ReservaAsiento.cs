using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class ReservaAsiento
    {
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; } 

        public ReservaAsiento(int id_reserva, int id_asiento)
        {
            this.IdReserva = id_reserva;
            this.IdAsiento = id_asiento;
        }
    }
}
