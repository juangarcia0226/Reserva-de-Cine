using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ReservaCine
{
    public class Conexion
    {
        private static string conexDb = "Server=localhost;Database=cine;Trusted_Connection=True;"; 

        public static SqlConnection GetConnection() => new SqlConnection(conexDb);
    }
}