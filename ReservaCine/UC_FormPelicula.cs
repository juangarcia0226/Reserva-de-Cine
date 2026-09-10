using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservaCine
{
    public partial class UC_FormPelicula: UserControl
    {
        private string accion; //"agregar" o "editar"
        private CrudPelicula dbPelicula;
        private int idPelicula;
        public string ImagenSeleccionada { get; set; }

        public event Action VolverListado;
        public UC_FormPelicula(string accion)
        {
            InitializeComponent();
            this.accion = accion;
            dbPelicula = new CrudPelicula();
            this.BorderStyle = BorderStyle.FixedSingle;

            Lbl_titulo.Text = "Título:";
            Lbl_descripcion.Text = "Descripción:";
            Lbl_genero.Text = "Genero:";
            Lbl_duracion.Text = "Duración:";
            Lbl_fecha.Text = "Fecha de estreno:";
            Lbl_director.Text = "Director:";
            Lbl_imagen.Text = "Imagen:";
        }

        public void CargarDatos(Pelicula pelicula)
        {
            idPelicula = pelicula.IdPelicula;
            Txt_titulo.Text = pelicula.Titulo;
            Txt_descripcion.Text = pelicula.Descripcion;
            Txt_duracion.Text = pelicula.Duracion.ToString();
            Txt_genero.Text = pelicula.Genero;
            Dtp_fecha.Value = pelicula.FechaEstreno;
            Txt_director.Text = pelicula.Director;

            // Guardar la ruta de imagen existente (si tiene)
            ImagenSeleccionada = pelicula.Imagen ?? "";

            // Mostrar imagen si existe físicamente
            if (!string.IsNullOrEmpty(pelicula.Imagen))
            {
                string rutaFisica = Path.Combine(Application.StartupPath, @"..\..\", pelicula.Imagen);
                if (File.Exists(rutaFisica))
                {
                    Pbx_imagen.Image = Image.FromFile(rutaFisica);
                    Pbx_imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Debe ingresar un título para la película.";
                return;
            }

            if (!int.TryParse(Txt_duracion.Text, out int duracion))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Duración inválida. Ingrese un número entero.";
                return;
            }

            if (accion == "agregar")
            {
                Pelicula newPelicula = new Pelicula(
                    0,
                    Txt_titulo.Text.Trim(),
                    Txt_descripcion.Text.Trim(),
                    duracion,
                    Txt_genero.Text.Trim(),
                    Dtp_fecha.Value,
                    Txt_director.Text.Trim(),
                    ImagenSeleccionada
                );

                dbPelicula.AddPelicula(newPelicula);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Película {newPelicula.Titulo} agregada correctamente.";
            }
            else if (accion == "editar")
            {
                Pelicula updatePelicula = new Pelicula(
                    idPelicula,
                    Txt_titulo.Text.Trim(),
                    Txt_descripcion.Text.Trim(),
                    duracion,
                    Txt_genero.Text.Trim(),
                    Dtp_fecha.Value,
                    Txt_director.Text.Trim(),
                    ImagenSeleccionada
                );

                dbPelicula.UpdatePelicula(updatePelicula);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Película {updatePelicula.Titulo} actualizada correctamente.";
            }

            VolverListado?.Invoke();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            VolverListado?.Invoke();
        }

        private void Btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccionar imagen de la película";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                // Validar tamaño (máx. 2 MB)
                if (fileInfo.Length > 2 * 1024 * 1024)
                {
                    MessageBox.Show("La imagen no puede superar los 2 MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que haya título antes de generar el nombre de la imagen
                string titulo = Txt_titulo.Text.Trim();
                if (string.IsNullOrWhiteSpace(titulo))
                {
                    MessageBox.Show("Ingrese el título antes de seleccionar una imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Reemplazar caracteres inválidos por guion bajo
                char[] invalidChars = Path.GetInvalidFileNameChars();
                foreach (char c in invalidChars)
                {
                    titulo = titulo.Replace(c, '_');
                }

                string extension = Path.GetExtension(openFileDialog.FileName);
                string nombreArchivo = $"{titulo.Replace(" ", "_")}{extension}";

                // Carpeta destino (ruta absoluta limpia)
                string carpetaDestino = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesPeliculas"));
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                try
                {
                    // Crear carpeta si no existe
                    if (!Directory.Exists(carpetaDestino))
                        Directory.CreateDirectory(carpetaDestino);

                    // Liberar imagen anterior del PictureBox para evitar bloqueo del archivo
                    if (Pbx_imagen.Image != null)
                    {
                        Pbx_imagen.Image.Dispose();
                        Pbx_imagen.Image = null;
                    }

                    // Copiar la nueva imagen (sobrescribe si ya existe)
                    File.Copy(openFileDialog.FileName, rutaDestino, true);

                    // Guardar ruta relativa en la propiedad
                    ImagenSeleccionada = Path.Combine("ImagenesPeliculas", nombreArchivo);

                    // Cargar la imagen sin bloquear el archivo
                    using (var stream = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                    {
                        Pbx_imagen.Image = Image.FromStream(stream);
                    }
                    Pbx_imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la imagen: {ex.Message}\nRuta: {rutaDestino}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
