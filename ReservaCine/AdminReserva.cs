using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCine
{
    public partial class AdminReserva : Form
    {
        CrudUsuario dbUsuario;
        List<Usuario> usuarios;
        CrudPelicula dbPelicula;
        List<Pelicula> peliculas;
        CrudSala dbSala;
        List<Sala> salas;
        CrudFuncion dbFuncion;
        List<Funcion> funciones;
        CrudAsiento dbAsiento;
        CrudReserva dbReserva;
        List<Reserva> reservas;
        List<ReservaAsiento> reserva_asientos;
        public AdminReserva()
        {
            InitializeComponent();

            Lbl_reservas.Text = "RESERVAS";

            dbUsuario = new CrudUsuario();
            usuarios = dbUsuario.GetUsuarios();

            dbPelicula = new CrudPelicula();
            peliculas = dbPelicula.GetPeliculas();

            dbSala = new CrudSala();
            salas = dbSala.GetSalas();

            dbFuncion = new CrudFuncion();
            funciones = dbFuncion.GetFuncion();

            dbAsiento = new CrudAsiento();

            dbReserva = new CrudReserva();
            reservas = dbReserva.GetReservas(); 
            reserva_asientos = dbReserva.GetReservaAsiento();

            LoadReservas();
        }

        private void LoadReservas()
        {
            Flp_reservas.Controls.Clear();

            // Obtener TODAS las reservas 
            reservas = dbReserva.GetReservas();
            reserva_asientos = dbReserva.GetReservaAsiento();

            foreach (var reserva in reservas)
            {
                // Obtener usuario
                Usuario usu = usuarios.First(u => u.IdUsuario == reserva.IdUsuario);

                // Obtener función
                Funcion funcion = funciones.First(f => f.IdFuncion == reserva.IdFuncion);

                // Película y sala
                Pelicula pelicula = peliculas.First(p => p.IdPelicula == funcion.IdPelicula);
                Sala sala = salas.First(s => s.IdSala == funcion.IdSala);

                // Asientos disponibles para esa función
                var asientosFuncion = dbAsiento.GetAsientos(funcion.IdFuncion);

                // Asientos de esta reserva
                List<ReservaAsiento> asientosList = reserva_asientos
                    .Where(a => a.IdReserva == reserva.IdReserva)
                    .ToList();

                string listaAsientos = string.Join(", ",
                    asientosList.Select(a => asientosFuncion.First(x => x.IdAsiento == a.IdAsiento).Codigo)
                );

                // Crear Card Admin
                var card = new UC_ListReserva();
                card.IdReserva = reserva.IdReserva;

                card.Configurar(
                    usu.Correo,       // correo del usuario
                    pelicula.Titulo,
                    sala.Nombre,
                    listaAsientos,
                    funcion.Fecha,
                    funcion.Horario
                );

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
                reservas = dbReserva.GetReservas();
                reserva_asientos = dbReserva.GetReservaAsiento();

                LoadReservas();

                MessageBox.Show("La reserva ha sido eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la reserva. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FiltrarReservas(string texto)
        {
            Flp_reservas.Controls.Clear();

            // Si no escribió nada, mostrar todas las reservas
            if (string.IsNullOrWhiteSpace(texto))
            {
                LoadReservas();
                return;
            }

            string filtro = texto.ToLower();

            // Filtrar reservas según el correo del usuario
            var reservasFiltradas = reservas
                .Where(r =>
                {
                    Usuario u = usuarios.First(x => x.IdUsuario == r.IdUsuario);
                    return u.Correo.ToLower().Contains(filtro);
                })
                .ToList();

            foreach (var reserva in reservasFiltradas)
            {
                Usuario usu = usuarios.First(u => u.IdUsuario == reserva.IdUsuario);
                Funcion funcion = funciones.First(f => f.IdFuncion == reserva.IdFuncion);
                Pelicula pelicula = peliculas.First(p => p.IdPelicula == funcion.IdPelicula);
                Sala sala = salas.First(s => s.IdSala == funcion.IdSala);

                var asientosFuncion = dbAsiento.GetAsientos(funcion.IdFuncion);

                List<ReservaAsiento> asientosList = reserva_asientos
                    .Where(a => a.IdReserva == reserva.IdReserva)
                    .ToList();

                string listaAsientos = string.Join(", ",
                    asientosList.Select(a => asientosFuncion.First(x => x.IdAsiento == a.IdAsiento).Codigo)
                );

                var card = new UC_ListReserva();
                card.IdReserva = reserva.IdReserva;

                card.Configurar(
                    usu.Correo,
                    pelicula.Titulo,
                    sala.Nombre,
                    listaAsientos,
                    funcion.Fecha,
                    funcion.Horario
                );

                card.EliminarReserva += (s, e) => EliminarReserva(reserva);

                Flp_reservas.Controls.Add(card);
            }
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarReservas(NormalizarTexto(Txt_buscar.Text));
        }

        //Quita tildes y pasa a minusculas el texto ingresado
        private string NormalizarTexto(string texto)
        {
            return new string(texto
                .Normalize(NormalizationForm.FormD)
                .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray()
            ).ToLower();
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void Btn_salas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSala adminSala = new AdminSala();
            adminSala.Show();
        }

        private void Btn_funciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFuncion adminFuncion = new AdminFuncion();
            adminFuncion.Show();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsuario adminUsuario = new AdminUsuario();
            adminUsuario.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void AdminReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
