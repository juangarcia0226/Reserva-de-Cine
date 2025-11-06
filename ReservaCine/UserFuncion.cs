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
        private int idFuncion;
        private CrudFuncion dbFuncion;
        List<Funcion> funciones;
        public UserFuncion(int idPeli, Usuario usuario)
        {
            InitializeComponent();
            dbFuncion = new CrudFuncion();
            Lbl_funciones.Text = "Funciones";
            LoadFunciones();
            this.idPelicula = idPeli;
            MostrarInfoPelicula();
            CargarFotoUsuario(usuario);
            Lbl_usuario.Text = usuario.Nombre;
        }
        private void LoadFunciones()
        {
            funciones = dbFuncion.GetFuncion();

            var funcionesFiltradas = funciones.Where(f => f.IdPelicula == idFuncion).OrderBy(f => f.IdFuncion);

            Flp_funciones.Controls.Clear();

            foreach (var funcion in funciones)
            {
                var card = new UC_UserFuncion();
                card.IdFuncion = idFuncion;
                card.Configurar(funcion.Fecha, funcion.Horario, funcion.IdFuncion);

                Flp_funciones.Controls.Add(card);
            }
        }
        private void MostrarFunciones(List<Funcion> funcionesPeliculas, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();

            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(2); // Hoy + 2 días

            // Filtrar funciones entre hoy y límite
            var funcionesFiltradas = funcionesPeliculas
                .Where(f => f.Fecha >= hoy && f.Fecha <= limite)
                .OrderBy(f => f.Fecha)
                .ThenBy(f => f.Horario) // ordena por hora
                .ToList();

            // Agrupar por día
            var funcionesPorDia = funcionesFiltradas
                .GroupBy(f => f.Fecha)
                .OrderBy(g => g.Key);

            foreach (var grupo in funcionesPorDia)
            {
                // Label con el día
                Label lblDia = new Label
                {
                    Text = grupo.Key.ToString("dddd, dd MMMM"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(10, 10, 0, 5)
                };
                flp.Controls.Add(lblDia);

                // Cards de cada función
                foreach (var funcion in grupo)
                {
                    UC_UserFuncion card = new UC_UserFuncion();
                    card.Configurar(funcion.Fecha, funcion.Horario, funcion.IdFuncion);
                    card.SeleccionarClicked += (s, e) => SeleccionarFuncion(funcion);
                    flp.Controls.Add(card);
                }
            }
        }

        private void SeleccionarFuncion(Funcion funcion)
        {

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
                ? "ImagenesUsuarios\\default.png"
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
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios\default.png")
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
    }
}
