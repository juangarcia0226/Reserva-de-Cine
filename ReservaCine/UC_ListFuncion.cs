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

namespace ReservaCine
{
    public partial class UC_ListFuncion: UserControl
    {
        public int IdFuncion {  get; set; }

        public event EventHandler EditarClicked;
        public event EventHandler EliminarClicked;

        private CrudPelicula dbPelicula = new CrudPelicula();
        private CrudSala dbSala = new CrudSala();
        private List<Pelicula> peliculas = new List<Pelicula>();
        private List<Sala> salas = new List<Sala>();

        private Guna2Panel panel;
        private Label Lbl_descripcion;
        private Label Lbl_pelicula;
        private Label Lbl_sala;
        private Label Lbl_fecha;
        private Label Lbl_hora;
        private Guna2Button Btn_editar;
        private Guna2Button Btn_eliminar;
        public UC_ListFuncion()
        {
            InitializeComponent();
            InicializarUI();

            peliculas = dbPelicula.GetPeliculas();
            salas = dbSala.GetSalas();
        }
        private void InicializarUI()
        {
            //Configuración del UC
            this.Size = new Size(300, 170);
            this.Margin = new Padding(10);

            //Panel principal
            panel = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(245, 245, 245),
                Size = new Size(300, 200),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };
            this.Controls.Add(panel);

            //Label descripción
            Lbl_descripcion = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(22, 15),
                Size = new Size(260, 25)
            };
            panel.Controls.Add(Lbl_descripcion);

            //Label película
            Lbl_pelicula = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(22, 50),
                Size = new Size(120, 20)
            };
            panel.Controls.Add(Lbl_pelicula);

            //Label sala
            Lbl_sala = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(22, 75),
                Size = new Size(120, 20)
            };
            panel.Controls.Add(Lbl_sala);

            //Label fecha
            Lbl_fecha = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(22, 100),
                Size = new Size(120, 20)
            };
            panel.Controls.Add(Lbl_fecha);

            //Label hora
            Lbl_hora = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(164, 50),
                Size = new Size(120, 20)
            };
            panel.Controls.Add(Lbl_hora);

            //Botón Editar
            Btn_editar = new Guna2Button
            {
                Text = "Editar",
                FillColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(22, 125),
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
                Location = new Point(164, 125),
                BorderRadius = 6,
                Cursor = Cursors.Hand
            };
            Btn_eliminar.Click += (s, e) => EliminarClicked?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_eliminar);
        }
        
        //Método para mostrar los datos de la función en la tarjeta(card)
        public void Configurar(string descripcion, int id_pelicula, int id_sala, DateTime fecha, string hora)
        {
            Pelicula pelicula = peliculas.FirstOrDefault(p => p.IdPelicula == id_pelicula);
            Sala sala = salas.FirstOrDefault(s => s.IdSala == id_sala);

            Lbl_descripcion.Text = descripcion;
            Lbl_pelicula.Text = "Película: " + pelicula.Titulo;
            Lbl_sala.Text = "Sala: " + sala.Nombre;
            Lbl_fecha.Text = $"Fecha: {fecha:dd/MM/yyyy}";
            Lbl_hora.Text = "Hora: " + hora;
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
