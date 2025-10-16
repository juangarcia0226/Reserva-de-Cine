using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //Para el NormalizarTexto()

namespace ReservaCine
{
    public partial class AdminHome: Form
    {
        private CrudPelicula dbPelicula;
        List<Pelicula> peliculas;
        public AdminHome()
        {
            InitializeComponent();

            dbPelicula = new CrudPelicula();
            LoadPeliculas();
            Lbl_peliculas.Text = "PELÍCULAS";
        }
        //Método para cargar las películas al Flp
        private void LoadPeliculas()
        {
            peliculas = dbPelicula.GetPeliculas();

            Flp_peliculas.Controls.Clear();

            foreach (var peli in peliculas)
            {
                var card = new UC_Pelicula();
                card.IdPelicula = peli.IdPelicula; 
                card.Configurar(peli.Titulo, peli.Genero, peli.Duracion);

                card.EditarClicked += (s, e) => MostrarFormulario("editar", peli);
                card.EliminarClicked += (s, e) => EliminarPelicula(peli);

                Flp_peliculas.Controls.Add(card);  
            }
        }
        //Este método elimina la película seleccionada
        private void EliminarPelicula(Pelicula pelicula)
        {
            var confirm = MessageBox.Show($"¿Deseas eliminar la película '{pelicula.Titulo}'?","Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                dbPelicula.DeletePelicula(pelicula.IdPelicula); 
                LoadPeliculas(); 
            }
        }

        //Este método muestra el formulario para editar o agregar una película
        private void MostrarFormulario(string accion, Pelicula pelicula = null)
        {
            // Limpia cualquier formulario anterior
            Pnl_form.Controls.Clear();

            var formPelicula = new UC_FormPelicula(accion);

            if (accion == "editar" && pelicula != null)
            {
                formPelicula.CargarDatos(pelicula);
            }              

            formPelicula.VolverListado += () =>
            {
                Pnl_form.Visible = false;
                Pnl_form.Controls.Clear();
                LoadPeliculas();
            };

            Pnl_form.Controls.Add(formPelicula);
            Pnl_form.Visible = true;
            Pnl_form.BringToFront();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            Txt_buscar.Focus();
            LoadPeliculas();
        }
        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_salas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSala adminSala = new AdminSala();
            adminSala.Show();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MostrarFormulario("agregar");
        }

        //Método para buscar una película
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
                var card = new UC_Pelicula();
                card.IdPelicula = peli.IdPelicula;
                card.Configurar(peli.Titulo, peli.Genero, peli.Duracion);

                card.EditarClicked += (s, e2) => MostrarFormulario("editar", peli);
                card.EliminarClicked += (s, e2) => EliminarPelicula(peli);

                Flp_peliculas.Controls.Add(card);
            }
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
    }
}
