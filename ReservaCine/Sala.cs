using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCine
{
    public class Sala
    {
        public int IdSala { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Filas { get; set; }
        public int Columnas { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }
        public Sala(int sala, string nombre, int capacidad, int filas, int columnas, string tipo, bool estado)
        {
            this.IdSala = sala;
            this.Nombre = nombre;
            this.Capacidad = capacidad;
            this.Filas = filas;
            this.Columnas = columnas;
            this.Tipo = tipo;
            this.Estado = estado;
        }
    }
}
