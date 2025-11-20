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
    public partial class UC_UserFuncion: UserControl
    {
        public int IdFuncion { get; set; } 

        public event EventHandler SeleccionarClicked;


        private Guna2Panel panel;
        private Label Lbl_fecha;
        private Label Lbl_hora;
        private Label Lbl_nombre;
        private Guna2Button Btn_seleccionar;

        public UC_UserFuncion()
        {
            InitializeComponent();
            InicializarUI();
        }

        public void InicializarUI()
        {
            this.Size = new Size(200, 80);
            this.Margin = new Padding(5);

            panel = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(245, 245, 245),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 3 }
            };

            panel.MouseEnter += (s, e) => panel.FillColor = Color.FromArgb(230, 230, 230);
            panel.MouseLeave += (s, e) => panel.FillColor = Color.FromArgb(245, 245, 245);

            this.Controls.Add(panel);

            Lbl_fecha = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(10, 10)
            };
            panel.Controls.Add(Lbl_fecha);

            Lbl_hora = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35)
            };
            panel.Controls.Add(Lbl_hora);

            Lbl_nombre = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(10, 55)
            };
            panel.Controls.Add(Lbl_nombre);

            Btn_seleccionar = new Guna2Button()
            {
                Text = "Seleccionar",
                Size = new Size(90, 30),
                Location = new Point(100, 25),
                BorderRadius = 6,
                FillColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };

            Btn_seleccionar.Click += (s, e) => SeleccionarClicked?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_seleccionar);

            // Permitir seleccionar haciendo clic en todo el panel
            panel.Click += (s, e) => Btn_seleccionar.PerformClick();
            Lbl_fecha.Click += (s, e) => Btn_seleccionar.PerformClick();
            Lbl_hora.Click += (s, e) => Btn_seleccionar.PerformClick();
            Lbl_nombre.Click += (s, e) => Btn_seleccionar.PerformClick();
        }


        public void Configurar(Funcion funcion)
        {
            CrudSala dbSala = new CrudSala();
            List<Sala> salas = dbSala.GetSalas();
            Sala sala = salas.FirstOrDefault(s=> s.IdSala == funcion.IdSala);

            this.IdFuncion = funcion.IdFuncion;
            Lbl_fecha.Text = funcion.Fecha.ToString("dd/MM/yyyy");
            Lbl_nombre.Text = sala.Tipo;

            // Convertir hora militar a formato 12h
            if (TimeSpan.TryParse(funcion.Horario, out TimeSpan hora))
            {
                DateTime horaFormato12 = DateTime.Today.Add(hora);
                Lbl_hora.Text = horaFormato12.ToString("hh:mm tt"); 
            }
            else
            {
                Lbl_hora.Text = funcion.Horario; 
            }
        }
    }
}
