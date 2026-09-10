using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class Asiento
    {
        public int IdAsiento {  get; set; }
        public int IdFuncion { get; set; }
        public string Codigo { get; set; }
        public bool Disponible { get; set; }

        public Asiento(int id_asiento, int id_funcion, string codigo, bool disponible)
        {
            this.IdAsiento = id_asiento;
            this.IdFuncion = id_funcion;
            this.Codigo = codigo;
            this.Disponible = disponible;
        }
    }
}