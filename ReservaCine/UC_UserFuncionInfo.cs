using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCine
{
    public partial class UC_UserFuncionInfo : UserControl
    {
        private int idPelicula;
        public UC_UserFuncionInfo(int id_pelicula)
        {
            InitializeComponent();
            this.idPelicula = id_pelicula;
        }
        //Método para mostrar el contenido de cada película en la tarejeta(card)
        public void Configurar(int id_pelicula)
        {
            CrudPelicula dbPelicula = new CrudPelicula();
            List<Pelicula> peliculas = dbPelicula.GetPeliculas();

            var pelicula = peliculas.FirstOrDefault(p => p.IdPelicula == id_pelicula);

            Lbl_titulo.Text = "Título:" + pelicula.Titulo;
            Lbl_descripcion.Text = "Descripción: " + pelicula.Descripcion;
            Lbl_genero.Text = "Género: " + pelicula.Genero;
            Lbl_duracion.Text = "Duración: " + pelicula.Duracion + " min";
            Lbl_director.Text = "Director: " + pelicula.Director;

            try
            {
                string rutaBase = Path.Combine(Application.StartupPath, @"..\..\");

                // Si la película tiene una imagen asignada
                if (!string.IsNullOrEmpty(pelicula.Imagen))
                {
                    string rutaFisica = Path.Combine(rutaBase, pelicula.Imagen);
                    if (File.Exists(rutaFisica))
                    {
                        using (var tempImage = Image.FromFile(rutaFisica))
                        {
                            Pbx_imagen.Image = new Bitmap(tempImage);
                        }
                        return;
                    }
                }

                // Si no tiene imagen, usar la imagen por defecto
                string rutaNoImage = Path.Combine(rutaBase, "ImagenesPeliculas", "no_image.jpg");
                if (File.Exists(rutaNoImage))
                {
                    using (var tempImage = Image.FromFile(rutaNoImage))
                    {
                        Pbx_imagen.Image = new Bitmap(tempImage);
                    }
                }
                else
                {
                    Pbx_imagen.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
