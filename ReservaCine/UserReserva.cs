using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            Lbl_usuario.Text = usuario.Nombre;

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
            CargarFotoUsuario(usuario);
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

        private void LoadReservasFiltradas(List<Reserva> reservasFiltradas)
        {
            Flp_reservas.Controls.Clear();

            foreach (var reserva in reservasFiltradas)
            {
                Funcion funcion = funciones.First(f => f.IdFuncion == reserva.IdFuncion);
                Pelicula pelicula = peliculas.First(p => p.IdPelicula == funcion.IdPelicula);
                Sala sala = salas.First(s => s.IdSala == funcion.IdSala);

                var asientosFuncion = dbAsiento.GetAsientos(funcion.IdFuncion);

                List<ReservaAsiento> asientosList = reserva_asientos
                    .Where(a => a.IdReserva == reserva.IdReserva)
                    .ToList();

                string listaAsientos = string.Join(", ",
                    asientosList.Select(a =>
                        asientosFuncion.First(x => x.IdAsiento == a.IdAsiento).Codigo
                    ));

                var card = new UC_UserReserva();
                card.IdReserva = reserva.IdReserva;

                card.Configurar(
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
            string texto = NormalizarTexto(Txt_buscar.Text);

            // Si está vacío, mostramos todas las reservas
            if (string.IsNullOrEmpty(texto))
            {
                LoadReservas(usuario.IdUsuario);
                return;
            }

            // Filtrar las reservas por nombre de película
            var filtradas = reservas.Where(r =>
            {
                var funcion = funciones.First(f => f.IdFuncion == r.IdFuncion);
                var pelicula = peliculas.First(p => p.IdPelicula == funcion.IdPelicula);

                return pelicula.Titulo.ToLower().Contains(texto);
            }).ToList();

            LoadReservasFiltradas(filtradas);
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
            UserHome userHome = new UserHome(usuario);
            userHome.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void UserReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CargarFotoUsuario(Usuario usuario)
        {
            // Si no hay imagen, usar una ruta relativa por defecto
            string rutaRelativa = string.IsNullOrEmpty(usuario.Imagen)
                ? "ImagenesUsuarios\\default.jpg"
                : usuario.Imagen;

            // Construir la ruta física completa a partir del directorio base del proyecto
            string rutaFisica = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", rutaRelativa)
            );

            // Liberar imagen previa para evitar bloqueo
            if (Pbx_usuario.Image != null)
            {
                Pbx_usuario.Image.Dispose();
                Pbx_usuario.Image = null;
            }

            // Cargar imagen si existe
            if (File.Exists(rutaFisica))
            {
                using (var stream = new FileStream(rutaFisica, FileMode.Open, FileAccess.Read))
                {
                    Pbx_usuario.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Si no existe, carga el placeholder por defecto
                string rutaDefault = Path.GetFullPath(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios\default.jpg")
                );

                if (File.Exists(rutaDefault))
                {
                    using (var stream = new FileStream(rutaDefault, FileMode.Open, FileAccess.Read))
                    {
                        Pbx_usuario.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    Pbx_usuario.Image = null;
                }
            }

            Pbx_usuario.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
