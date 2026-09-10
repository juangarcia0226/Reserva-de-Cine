using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;

namespace ReservaCine
{
    public partial class UC_Pelicula: UserControl
    {
        public int IdPelicula { get; set; }

        // Eventos para que el formulario principal los escuche
        public event EventHandler EditarClicked;
        public event EventHandler EliminarClicked;

        // Controles
        private Guna2Panel panel;
        private Label Lbl_titulo;
        private Label Lbl_genero;
        private Label Lbl_duracion;
        private Guna2Button Btn_editar;
        private Guna2Button Btn_eliminar;
        private Guna2PictureBox Pbx_imagen;

        public UC_Pelicula()
        {
            InitializeComponent();
            InicializarUI();
        }

        //Configura toda la parte visual del UC
        private void InicializarUI()
        {
            //Configuración del UC
            this.Size = new Size(300, 150);
            this.Margin = new Padding(10);

            //Panel principal
            panel = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(245, 245, 245),
                Size = new Size(300, 150),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };
            this.Controls.Add(panel);

            // PictureBox para la imagen de la película
            Pbx_imagen = new Guna2PictureBox
            {
                Size = new Size(100, 75),
                Location = new Point(160, 15),
                BorderRadius = 8,
                SizeMode = PictureBoxSizeMode.Zoom,
                FillColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            panel.Controls.Add(Pbx_imagen);

            //Label Título
            Lbl_titulo = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(18, 15),
                Size = new Size(160, 25)
            };
            panel.Controls.Add(Lbl_titulo);

            //Label Género
            Lbl_genero = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(18, 50),
                Size = new Size(260, 20)
            };
            panel.Controls.Add(Lbl_genero);

            //Label Duración
            Lbl_duracion = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(18, 75),
                Size = new Size(260, 20)
            };
            panel.Controls.Add(Lbl_duracion);

            //Botón Editar
            Btn_editar = new Guna2Button
            {
                Text = "Editar",
                FillColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(18, 110),
                BorderRadius = 6,
                Cursor = Cursors.Hand
            };
            Btn_editar.Click += (s, e) => EditarClicked?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_editar);

            //Botón Eliminar
            Btn_eliminar = new Guna2Button
            {
                Text = "Eliminar",
                FillColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(160, 110),
                BorderRadius = 6,
                Cursor = Cursors.Hand
            };
            Btn_eliminar.Click += (s, e) => EliminarClicked?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_eliminar);
        }

        //Método para mostrar el contenido de cada película en la tarejeta(card)
        public void Configurar(string titulo, string genero, int duracion, string rutaImagen)
        {
            Lbl_titulo.Text = titulo;
            Lbl_genero.Text = "Género: " + genero;
            Lbl_duracion.Text = "Duración: " + duracion + " min";

            try
            {
                string rutaBase = Path.Combine(Application.StartupPath, @"..\..\");

                // Si la película tiene una imagen asignada
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    string rutaFisica = Path.Combine(rutaBase, rutaImagen);
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

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            EditarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
