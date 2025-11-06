using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace ReservaCine
{
    public partial class UserHome: Form
    {
        private Usuario usuario;
        private CrudPelicula dbPelicula;
        List<Pelicula> peliculas;
        public UserHome(Usuario usuario)
        {
            InitializeComponent();
            dbPelicula = new CrudPelicula();
            this.usuario = usuario;
            Lbl_usuario.Text = usuario.Nombre;
            LoadPeliculas();
            CargarFotoUsuario(usuario);
            Lbl_peliculas.Text = "Películas";
        }

        private void LoadPeliculas()
        {
            peliculas = dbPelicula.GetPeliculas();

            Flp_peliculas.Controls.Clear();

            foreach (var peli in peliculas)
            {
                var card = new UC_UserPelicula();
                card.IdPelicula = peli.IdPelicula;
                card.Configurar(peli.Titulo, peli.Imagen);

                card.Seleccionar += (s, e) => MostrarFunciones(peli);

                Flp_peliculas.Controls.Add(card);
            }
        }

        private void MostrarFunciones(Pelicula pelicula)
        {
            this.Hide();
            UserFuncion userFuncion = new UserFuncion(pelicula.IdPelicula, usuario);
            userFuncion.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            Txt_buscar.Focus();
            LoadPeliculas();
        }

        private void UserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
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

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = NormalizarTexto(Txt_buscar.Text);

            //Si no hay texto, muestra todas las películas
            if (string.IsNullOrWhiteSpace(filtro))
            {
                LoadPeliculas();
                return;
            }

            //Filtra las películas por título contenga el texto buscado
            List<Pelicula> filtradas = peliculas.Where(p => NormalizarTexto(p.Titulo).Contains(filtro)).ToList();

            //Muestra solo las que coinciden
            Flp_peliculas.Controls.Clear();
            foreach (var peli in filtradas)
            {
                var card = new UC_UserPelicula();
                card.IdPelicula = peli.IdPelicula;
                card.Configurar(peli.Titulo, peli.Imagen);

                card.Seleccionar += (s, e2) => MostrarFunciones(peli);

                Flp_peliculas.Controls.Add(card);
            }
        }
        private void CargarFotoUsuario(Usuario usuario)
        {
            // Si no hay imagen, usar una ruta relativa por defecto
            string rutaRelativa = string.IsNullOrEmpty(usuario.Imagen)
                ? "ImagenesUsuarios\\default.png"
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
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios\default.png")
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
