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
    public partial class UserFuncion: Form
    {
        private int idPelicula;
        private Usuario Usuario;
        private CrudFuncion dbFuncion;
        List<Funcion> funciones;
        public UserFuncion(int idPeli, Usuario usuario)
        {
            InitializeComponent();

            dbFuncion = new CrudFuncion();

            Lbl_funciones.Text = "Funciones";
            Lbl_usuario.Text = usuario.Nombre;

            this.idPelicula = idPeli;
            this.Usuario = usuario;

            funciones = dbFuncion.GetFuncion().Where(f => f.IdPelicula == idPelicula).ToList();
            MostrarFunciones(funciones, Flp_funciones);

            MostrarInfoPelicula();

            CargarFotoUsuario(usuario);

            Lbl_usuario.Text = usuario.Nombre;
        }

        //Método para filtrar y mostrar las funciones por día
        private void MostrarFunciones(List<Funcion> funcionesPeliculas, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();

            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(2);

            var funcionesFiltradas = funcionesPeliculas
                .Where(f => f.Fecha >= hoy && f.Fecha <= limite)
                .OrderBy(f => f.Fecha)
                .ThenBy(f => f.Horario)
                .ToList();

            var funcionesPorDia = funcionesFiltradas
                .GroupBy(f => f.Fecha)
                .OrderBy(g => g.Key);

            foreach (var grupo in funcionesPorDia)
            {
                // CONTENEDOR DEL DÍA
                Panel contenedorDia = new Panel
                {
                    Width = flp.Width - 30,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Margin = new Padding(10, 10, 10, 10),
                    BackColor = Color.Transparent,
                };

                // LABEL DEL DÍA
                Label lblDia = new Label
                {
                    Text = grupo.Key.ToString("dddd, dd MMMM"),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(5, 0)
                };
                contenedorDia.Controls.Add(lblDia);

                // FLOWLAYOUT DE LAS FUNCIONES DE ESE DÍA
                FlowLayoutPanel flpDia = new FlowLayoutPanel
                {
                    Location = new Point(5, 30),
                    Width = contenedorDia.Width - 10,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    WrapContents = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                contenedorDia.Controls.Add(flpDia);

                // AGREGAR LAS CARDS
                foreach (var funcion in grupo)
                {
                    var card = new UC_UserFuncion();
                    card.Configurar(funcion);
                    card.SeleccionarClicked += (s, e) => SeleccionarFuncion(funcion);

                    flpDia.Controls.Add(card);
                }

                flp.Controls.Add(contenedorDia);
            }
        }

        private void SeleccionarFuncion(Funcion funcion)
        {
            this.Hide();
            UserAsiento userAsiento = new UserAsiento(idPelicula, funcion, Usuario);
            userAsiento.Show();
        }

        private void MostrarInfoPelicula()
        {
            Pnl_funcionInfo.Controls.Clear();
            var infoPelicula = new UC_UserFuncionInfo(idPelicula);
            infoPelicula.Configurar(idPelicula);
            Pnl_funcionInfo.Controls.Add(infoPelicula);
        }

        private void CargarFotoUsuario(Usuario usuario)
        {
            // Si no hay imagen, usar una ruta relativa por defecto
            string rutaRelativa = string.IsNullOrEmpty(usuario.Imagen)
                ? "ImagenesUsuarios\\default.jpg"
                : usuario.Imagen;

            // Construir la ruta física completa a partir del directorio base del proyecto
            string rutaFisica = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", rutaRelativa)
            );

            // Liberar imagen previa para evitar bloqueo
            if (Pbx_usuario.Image != null)
            {
                Pbx_usuario.Image.Dispose();
                Pbx_usuario.Image = null;
            }

            // Cargar imagen si existe
            if (File.Exists(rutaFisica))
            {
                using (var stream = new FileStream(rutaFisica, FileMode.Open, FileAccess.Read))
                {
                    Pbx_usuario.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Si no existe, carga el placeholder por defecto
                string rutaDefault = Path.GetFullPath(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios\default.jpg")
                );

                if (File.Exists(rutaDefault))
                {
                    using (var stream = new FileStream(rutaDefault, FileMode.Open, FileAccess.Read))
                    {
                        Pbx_usuario.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    Pbx_usuario.Image = null;
                }
            }

            Pbx_usuario.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void UserFuncion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome userHome = new UserHome(Usuario);
            userHome.Show();
        }
    }
}
