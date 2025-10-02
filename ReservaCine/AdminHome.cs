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
    public partial class AdminHome: Form
    {
        private CrudPelicula dbPelicula;
        List<Pelicula> peliculas;
        private bool menuExpandido = true;
        private const int MAX_ANCHO = 212, MIN_ANCHO = 40;
        int idPeliSearch = 0;
        public AdminHome()
        {
            InitializeComponent();

            dbPelicula = new CrudPelicula();
            LoadPeliculas();
            Lbl_peliculas.Text = "PELÍCULAS";
            Lbl_fecha.Text = "Fecha de estreno:";
            Lbl_btnSala.Text = "SALAS";
        }
        //Método para cargar las películas al Dgv
        private void LoadPeliculas()
        {
            peliculas = dbPelicula.GetPeliculas();
            Dgv_pelis.DataSource = peliculas;
        }
        private void AdminHome_Load(object sender, EventArgs e)
        {
            Txt_titulo.Focus();
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                if (!int.TryParse(Txt_duracion.Text, out int duracion))
                {
                    Lbl_error.Text = "Ingrese una duración valida (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }

                Pelicula newPelicula = new Pelicula(0, Txt_titulo.Text, Txt_descripcion.Text, duracion, Txt_genero.Text, Dtp_fecha.Value, Txt_director.Text, Txt_reparto.Text);
                dbPelicula.AddPelicula(newPelicula);

                Lbl_error.Text = "Película guardada correctamente";
                Lbl_error.ForeColor = Color.SeaGreen;
                LoadPeliculas();
            }
            else 
            {
                Lbl_error.Text = "No se ingresó el título de la película";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                string peliculaBusacada = Txt_titulo.Text.Trim();

                Pelicula pelicula = peliculas.FirstOrDefault(p  => p.Titulo.Equals(peliculaBusacada, StringComparison.OrdinalIgnoreCase));

                if (pelicula != null)
                {
                    Txt_titulo.Text = pelicula.Titulo;
                    Txt_descripcion.Text = pelicula.Descripcion;
                    Txt_duracion.Text = Convert.ToString(pelicula.Duracion);
                    Txt_genero.Text = pelicula.Genero;
                    Dtp_fecha.Value = pelicula.FechaEstreno;
                    Txt_director.Text = pelicula.Director;
                    Txt_reparto.Text = pelicula.Reparto;

                    idPeliSearch = pelicula.IdPelicula;
                    Lbl_error.Text = "";
                }
                else
                {
                    Lbl_error.Text = "La película no está guardada";
                    Lbl_error.ForeColor = Color.Crimson;
                }
            }
            else
            {
                Lbl_error.Text = "No se ingresó el título de la película";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                if (!int.TryParse(Txt_duracion.Text, out var duracion))
                {
                    Lbl_error.Text = "Ingrese una duración valida (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (idPeliSearch != 0)
                {
                    Pelicula updatePelicula = new Pelicula(idPeliSearch, Txt_titulo.Text, Txt_descripcion.Text, duracion, Txt_genero.Text, Dtp_fecha.Value, Txt_director.Text, Txt_reparto.Text);
                    dbPelicula.UpdatePelicula(updatePelicula);

                    Lbl_error.Text = $"Película {updatePelicula.Titulo} actualizada correctamente";
                    Lbl_error.ForeColor = Color.SeaGreen;
                    LoadPeliculas();
                }
                else
                {
                    Lbl_error.Text = "Para actualizar primero tiene que buscar una película";
                    Lbl_error.ForeColor = Color.Crimson;
                }
            }
            else
            {
                Lbl_error.Text = "No se ingresó el título de la película";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idPeliSearch != 0) 
            {
                dbPelicula.DeletePelicula(idPeliSearch);

                Lbl_error.Text = $"Película {Txt_titulo.Text} ELIMINADA correctamente";
                Lbl_error.ForeColor = Color.SeaGreen;
                LoadPeliculas();
            }
            else
            {
                Lbl_error.Text = "Para eliminar primero tiene que buscar una película";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }
        private void Btn_sala_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSala adminSala = new AdminSala();
            adminSala.Show();
        }
        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Tmr_menu.Start();
        }
        private void Tmr_menu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                Pnl_menu_left.Width -= 10;
                if (Pnl_menu_left.Width <= MIN_ANCHO)
                {
                    Tmr_menu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                Pnl_menu_left.Width += 10;
                if (Pnl_menu_left.Width >= MAX_ANCHO)
                {
                    Tmr_menu.Stop();
                    menuExpandido = true;
                }
            }
        }
    }
}
