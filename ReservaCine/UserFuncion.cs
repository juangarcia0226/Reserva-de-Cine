using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCine
{
    public partial class UserFuncion: Form
    {
        private int idPelicula;
        private int idFuncion;
        private CrudFuncion dbFuncion;
        List<Funcion> funciones;
        public UserFuncion(int idPeli)
        {
            InitializeComponent();
            dbFuncion = new CrudFuncion();
            Lbl_funciones.Text = "FUNCIONES";
            LoadFunciones();
            this.idPelicula = idPeli;
        }
        private void LoadFunciones()
        {
            funciones = dbFuncion.GetFuncion();

            var funcionesFiltradas = funciones.Where(f => f.IdPelicula == idFuncion).OrderBy(f => f.IdFuncion);

            Flp_funciones.Controls.Clear();

            foreach (var funcion in funciones)
            {
                var card = new UC_UserFuncion();
                card.IdFuncion = idFuncion;
                card.Configurar(funcion.Fecha, funcion.Horario, funcion.IdFuncion);

                Flp_funciones.Controls.Add(card);
            }
        }
        private void MostrarFunciones(List<Funcion> funcionesPeliculas, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();

            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(2); // Hoy + 2 días

            // Filtrar funciones entre hoy y límite
            var funcionesFiltradas = funcionesPeliculas
                .Where(f => f.Fecha >= hoy && f.Fecha <= limite)
                .OrderBy(f => f.Fecha)
                .ThenBy(f => f.Horario) // ordena por hora
                .ToList();

            // Agrupar por día
            var funcionesPorDia = funcionesFiltradas
                .GroupBy(f => f.Fecha)
                .OrderBy(g => g.Key);

            foreach (var grupo in funcionesPorDia)
            {
                // Label con el día
                Label lblDia = new Label
                {
                    Text = grupo.Key.ToString("dddd, dd MMMM"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(10, 10, 0, 5)
                };
                flp.Controls.Add(lblDia);

                // Cards de cada función
                foreach (var funcion in grupo)
                {
                    UC_UserFuncion card = new UC_UserFuncion();
                    card.Configurar(funcion.Fecha, funcion.Horario, funcion.IdFuncion);
                    card.SeleccionarClicked += (s, e) => SeleccionarFuncion(funcion);
                    flp.Controls.Add(card);
                }
            }
        }

        private void SeleccionarFuncion(Funcion funcion)
        {

        }
    }
}
