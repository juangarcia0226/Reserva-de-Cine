using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCine
{
    public partial class UC_FormPelicula: UserControl
    {
        private string accion; //"agregar" o "editar"
        private CrudPelicula dbPelicula;
        private int idPelicula;

        public event Action VolverListado;
        public UC_FormPelicula(string accion)
        {
            InitializeComponent();
            this.accion = accion;
            dbPelicula = new CrudPelicula();
            this.BorderStyle = BorderStyle.FixedSingle;
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
            Txt_reparto.Text = pelicula.Reparto;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_titulo.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe ingresar un título para la película.";
                return;               
            }

            if (!int.TryParse(Txt_duracion.Text, out int duracion))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Duración inválida. Ingrese un número entero.";
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
                    Txt_reparto.Text.Trim()
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
                    Txt_reparto.Text.Trim()
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
    }
}
