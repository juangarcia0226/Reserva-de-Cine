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
    public partial class UC_FormFuncion: UserControl
    {
        private string accion; //agregar o editar
        private CrudFuncion dbFuncion;
        private int idFuncion;

        private CrudPelicula dbPelicula;
        private CrudSala dbSala;
        private List<Pelicula> peliculas;
        private List<Sala> salas;

        public event Action VolverListado;
        public UC_FormFuncion(string accion)
        {
            InitializeComponent();

            this.accion = accion;
            this.BorderStyle = BorderStyle.FixedSingle;

            dbFuncion = new CrudFuncion();
            dbPelicula = new CrudPelicula();
            dbSala = new CrudSala();

            Lbl_descripcion.Text = "Descripción:";
            Lbl_pelicula.Text = "Película:";
            Lbl_sala.Text = "Sala:";
            Lbl_fecha.Text = "Fecha:";
            Lbl_hora.Text = "Hora:";

            peliculas = dbPelicula.GetPeliculas();
            salas = dbSala.GetSalas();

            Cbx_pelicula.DataSource = peliculas;
            Cbx_pelicula.DisplayMember = "Titulo";
            Cbx_pelicula.ValueMember = "IdPelicula";

            Cbx_sala.DataSource = salas;
            Cbx_sala.DisplayMember = "Nombre";
            Cbx_sala.ValueMember = "IdSala";

            if (accion == "agregar")
            {
                Dtp_fecha.MinDate = DateTime.Today; 
                Dtp_fecha.Value = DateTime.Today;
                Cbx_pelicula.SelectedIndex = -1;
                Cbx_sala.SelectedIndex = -1;
            }
            else if (accion == "editar")
            {
                Dtp_fecha.MinDate = new DateTime(1753, 1, 1);
            }
        }

        public void CargarDatos(Funcion funcion)
        {
            idFuncion = funcion.IdFuncion;
            Txt_descripcion.Text = funcion.Descripcion;
            Cbx_pelicula.SelectedValue = funcion.IdPelicula;
            Cbx_sala.SelectedValue = funcion.IdSala;
            Dtp_fecha.Value = funcion.Fecha;
            Txt_hora.Text = funcion.Horario;
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_descripcion.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(220, 53, 69);
                Lbl_error.Text = "Debe ingresar una descripción para la función.";
                return;
            }
            if (Cbx_pelicula.SelectedItem == null || (int)Cbx_pelicula.SelectedValue == -1)
            {
                Lbl_error.ForeColor = Color.FromArgb(220, 53, 69);
                Lbl_error.Text = "Debe seleccionar una película para la función.";
                return;
            }
            if (Cbx_sala.SelectedItem == null || (int)Cbx_sala.SelectedValue == -1)
            {
                Lbl_error.ForeColor = Color.FromArgb(220, 53, 69);
                Lbl_error.Text = "Debe seleccionar una sala para la función.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_hora.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(220, 53, 69);
                Lbl_error.Text = "Debe ingresar una hora para la función.";
                return;
            }

            if(accion == "agregar")
            {
                Funcion newFuncion = new Funcion(
                    0,
                    Txt_descripcion.Text.Trim(),
                    (int)Cbx_pelicula.SelectedValue,
                    (int)Cbx_sala.SelectedValue,
                    Dtp_fecha.Value,
                    Txt_hora.Text.Trim()
                );
                dbFuncion.AddFuncion( newFuncion );
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Nueva función '{newFuncion.Descripcion}' agregada correctamente.";
            }
            else if (accion == "editar")
            {
                Funcion updateFuncion = new Funcion(
                    idFuncion,
                    Txt_descripcion.Text.Trim(),
                    (int)Cbx_pelicula.SelectedValue,
                    (int)Cbx_sala.SelectedValue,
                    Dtp_fecha.Value,
                    Txt_hora.Text.Trim()
                );
                dbFuncion.UpdateFuncion(updateFuncion);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"La función '{updateFuncion.Descripcion}' actualizada correctamente";
            }
            VolverListado?.Invoke();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            VolverListado?.Invoke();
        }
    }
}
