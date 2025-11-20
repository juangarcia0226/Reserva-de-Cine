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
    public partial class UserReserva: Form
    {
        private Usuario usuario;
        List<Pelicula> peliculas;
        CrudPelicula dbPelicula;
        List<Sala> salas;
        CrudSala dbSala;
        List<Funcion> funciones;
        CrudFuncion dbFuncion;
        List<Asiento> asientos;
        CrudAsiento dbAsiento;
        List<Reserva> reservas;
        CrudReserva dbReserva;
        List<ReservaAsiento> reserva_asientos;
        

        public UserReserva(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            Lbl_reservas.Text = "Reservas";

            dbPelicula = new CrudPelicula();
            peliculas = dbPelicula.GetPeliculas();

            dbSala = new CrudSala();
            salas = dbSala.GetSalas();

            dbFuncion = new CrudFuncion();
            funciones = dbFuncion.GetFuncion();

            dbAsiento = new CrudAsiento();

            dbReserva = new CrudReserva();
            reservas = dbReserva.GetReservasByUser(usuario.IdUsuario);
            reserva_asientos = dbReserva.GetReservaAsiento();

            LoadReservas(usuario.IdUsuario);
        }

        private void LoadReservas(int id_usuario)
        {
            Flp_reservas.Controls.Clear();

            foreach (var reserva in reservas)
            {
                Funcion funcion = funciones.First(f => f.IdFuncion == reserva.IdFuncion);
                Pelicula pelicula = peliculas.First(p => p.IdPelicula == funcion.IdPelicula);
                Sala sala = salas.First(s => s.IdSala == funcion.IdSala);

                var asientosFuncion = dbAsiento.GetAsientos(funcion.IdFuncion);

                List<ReservaAsiento> asientosList = reserva_asientos.Where(a => a.IdReserva == reserva.IdReserva).ToList();
                string listaAsientos = string.Join(", ", asientosList.Select(a => asientosFuncion.First(x => x.IdAsiento == a.IdAsiento).Codigo));

                var card = new UC_UserReserva();
                card.IdReserva = reserva.IdReserva;

                card.Configurar(pelicula.Titulo, sala.Nombre, listaAsientos, funcion.Fecha, funcion.Horario);

                card.EliminarReserva += (s, e) => EliminarReserva(reserva);
                Flp_reservas.Controls.Add(card);

            }
        }

        private void EliminarReserva(Reserva reserva)
        {
            try
            {
                var confirmacion = MessageBox.Show("¿Está seguro de eliminar esta reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                //Obtener los asientos que están asociados a esta reserva
                List<ReservaAsiento> asientosReserva = reserva_asientos.Where(a => a.IdReserva == reserva.IdReserva).ToList();

                //Eliminar los registros en reserva_asiento
                foreach (var ra in asientosReserva)
                {
                    dbReserva.DeleteReservaAsiento(reserva.IdReserva);
                }

                //Marcar cada asiento como disponible
                foreach (var ra in asientosReserva)
                {
                    dbAsiento.UpdateAsientoEstado(ra.IdAsiento, true);
                }

                //Eliminar la reserva principal
                dbReserva.DeleteReserva(reserva.IdReserva);

                //Recargar datos en memoria
                reservas = dbReserva.GetReservasByUser(usuario.IdUsuario);
                reserva_asientos = dbReserva.GetReservaAsiento();

                LoadReservas(usuario.IdUsuario);

                MessageBox.Show("La reserva ha sido eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la reserva. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
