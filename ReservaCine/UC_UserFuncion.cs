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
        private Guna2Button Btn_seleccionar;

        public UC_UserFuncion()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void InicializarUI()
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
            this.Controls.Add(panel);

            Lbl_fecha = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(10, 10)
            };
            panel.Controls.Add(Lbl_fecha);

            Lbl_hora = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35)
            };
            panel.Controls.Add(Lbl_hora);

            Btn_seleccionar = new Guna2Button
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
        }

        public void Configurar(DateTime fechaHora, string horaMilitar, int idFuncion)
        {
            this.IdFuncion = idFuncion;
            Lbl_fecha.Text = fechaHora.ToString("dd/MM/yyyy");

            // Convertir hora militar a formato 12h
            if (TimeSpan.TryParse(horaMilitar, out TimeSpan hora))
            {
                DateTime horaFormato12 = DateTime.Today.Add(hora);
                Lbl_hora.Text = horaFormato12.ToString("hh:mm tt"); 
            }
            else
            {
                Lbl_hora.Text = horaMilitar; 
            }
        }
    }
}
