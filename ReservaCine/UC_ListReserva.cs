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
    public partial class UC_ListReserva: UserControl
    {
        public int IdReserva { get; set; }
        public event EventHandler EliminarReserva;

        private Guna2Panel panel;
        private Label Lbl_usuario;
        private Label Lbl_pelicula;
        private Label Lbl_sala;
        private Label Lbl_asientos;
        private Label Lbl_fecha;
        private Label Lbl_hora;
        private Guna2Button Btn_eliminar;
        public UC_ListReserva()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void InicializarUI()
        {
            this.Size = new Size(300, 190);
            this.Margin = new Padding(8);

            panel = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(245, 245, 245),
                Size = new Size(350, 190),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 4 }
            };
            this.Controls.Add(panel);

            // Usuario (email)
            Lbl_usuario = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(15, 10),
                Size = new Size(400, 20)
            };
            panel.Controls.Add(Lbl_usuario);

            // Película
            Lbl_pelicula = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(15, 40),
                Size = new Size(300, 18)
            };
            panel.Controls.Add(Lbl_pelicula);

            // Sala
            Lbl_sala = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(15, 60),
                Size = new Size(300, 18)
            };
            panel.Controls.Add(Lbl_sala);

            // Asientos
            Lbl_asientos = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(15, 80),
                Size = new Size(300, 18)
            };
            panel.Controls.Add(Lbl_asientos);

            // Fecha
            Lbl_fecha = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(15, 100),
                Size = new Size(300, 18)
            };
            panel.Controls.Add(Lbl_fecha);

            // Hora
            Lbl_hora = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(15, 120),
                Size = new Size(300, 18)
            };
            panel.Controls.Add(Lbl_hora);

            // Botón eliminar
            Btn_eliminar = new Guna2Button
            {
                Text = "Eliminar reserva",
                FillColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(150, 35),
                Location = new Point(80, 145),
                BorderRadius = 8
            };
            Btn_eliminar.Click += (s, e) => EliminarReserva?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_eliminar);
        }

        public void Configurar(string usuarioEmail, string pelicula, string sala, string asientos, DateTime fecha, string hora)
        {
            Lbl_usuario.Text = $"Usuario: {usuarioEmail}";
            Lbl_pelicula.Text = $"Película: {pelicula}";
            Lbl_sala.Text = $"Sala: {sala}";
            Lbl_asientos.Text = $"Asientos: {asientos}";
            Lbl_fecha.Text = $"Fecha: {fecha:dd/MM/yyyy}";
            Lbl_hora.Text = $"Hora: {hora}";
        }
    }
}
