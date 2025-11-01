using Guna.UI2.WinForms;
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
    public partial class UC_ListUsuario : UserControl
    {
        public int IdUsuario { get; set; }

        public event EventHandler EditarClicked;
        public event EventHandler EliminarClicked;

        private Guna2Panel panel;
        private Label Lbl_nombre;
        private Label Lbl_correo;
        private Label Lbl_rol;
        private Guna2Button Btn_editar;
        private Guna2Button Btn_eliminar;
        public UC_ListUsuario()
        {
            InitializeComponent();
            InicializarUI();
        }

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
                Size = new Size(300, 200),
                Dock = DockStyle.Fill,
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };
            this.Controls.Add(panel);

            //Label nombre
            Lbl_nombre = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(22, 15),
                Size = new Size(260, 25)
            };
            panel.Controls.Add(Lbl_nombre);

            //Label correo
            Lbl_correo = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(22, 50),
                Size = new Size(200, 20)
            };
            panel.Controls.Add(Lbl_correo);

            //Label rol
            Lbl_rol = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(22, 75),
                Size = new Size(120, 20)
            };
            panel.Controls.Add(Lbl_rol);

            //Botón Editar
            Btn_editar = new Guna2Button
            {
                Text = "Editar",
                FillColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(22, 100),
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
                Location = new Point(164, 100),
                BorderRadius = 6,
                Cursor = Cursors.Hand
            };
            Btn_eliminar.Click += (s, e) => EliminarClicked?.Invoke(this, EventArgs.Empty);
            panel.Controls.Add(Btn_eliminar);
        }

        //Método para mostrar los datos del usuario en la tarjeta(card)
        public void Configurar(string nombre, string correo, int id_rol)
        {
            Lbl_nombre.Text = nombre;
            Lbl_correo.Text = "Correo: " + correo;
            Lbl_rol.Text = "Rol: " + (id_rol == 1 ? "Administrador" : "Usuario");
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
