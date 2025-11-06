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
    public partial class UC_UserPelicula : UserControl
    {
        public int IdPelicula { get; set; }
        public event EventHandler Seleccionar;

        private Guna2Panel panel;
        private Label Lbl_titulo;
        private Guna2Button Btn_seleccionar;
        private Guna2PictureBox Pbx_imagen;
        public UC_UserPelicula()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void InicializarUI()
        {
            //Configuración del UC
            this.Size = new Size(200, 300);
            this.Margin = new Padding(10);

            //Panel principal
            panel = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(245, 245, 245),
                Size = new Size(200, 300),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };
            this.Controls.Add(panel);

            //Label Título
            Lbl_titulo = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(18, 15),
                Size = new Size(190, 25)
            };
            panel.Controls.Add(Lbl_titulo);

            // PictureBox para la imagen de la película
            Pbx_imagen = new Guna2PictureBox
            {
                Size = new Size(150, 200),
                Location = new Point(24, 50),
                BorderRadius = 8,
                SizeMode = PictureBoxSizeMode.Zoom,
                FillColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            panel.Controls.Add(Pbx_imagen);

            //Botón seleccionar
            Btn_seleccionar = new Guna2Button
            {
                Text = "Seleccionar",
                FillColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(50, 260),
                BorderRadius = 6,
                Cursor = Cursors.Hand
            };
            Btn_seleccionar.Click += (s, e) => Seleccionar?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_seleccionar);
        }

        public void Configurar(string titulo, string rutaImagen)
        {
            Lbl_titulo.Text = titulo;

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

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar?.Invoke(this, EventArgs.Empty);
        }
    }
}
