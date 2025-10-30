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
    public partial class UC_FormSala: UserControl
    {
        private string accion; //"agregar" o "editar"
        private CrudSala dbSala;
        private int idSala;

        public event Action VolverListado;
        public UC_FormSala(string accion)
        {
            InitializeComponent();
            this.accion = accion;
            this.BorderStyle = BorderStyle.FixedSingle;
            dbSala = new CrudSala();
        }

        public void CargarDatos(Sala sala)
        {
            idSala = sala.IdSala;
            Txt_nombre.Text = sala.Nombre;
            Txt_capacidad.Text = sala.Estado.ToString();
            Txt_filas.Text = sala.Filas.ToString();
            Txt_columnas.Text = sala.Columnas.ToString();
            Txt_tipo.Text = sala.Tipo.ToString();
            Rb_si.Checked = sala.Estado ? true : false;
            Rb_no.Checked = sala.Estado ? false : true;
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_nombre.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe ingresar un nombre para la sala";
                return;
            }

            if (!int.TryParse(Txt_capacidad.Text, out int capacidad))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Capacidad inválida. Ingrese un número entero.";
                return;
            }
            if (!int.TryParse(Txt_filas.Text, out int filas))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Filas inválida. Ingrese un número entero.";
                return;
            }
            if (!int.TryParse(Txt_columnas.Text, out int columnas))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Columnas inválida. Ingrese un número entero.";
                return;
            }

            if (!Rb_si.Checked && !Rb_no.Checked)
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Marque la disponibilidad de la sala";
                return;
            }

            if (accion == "agregar")
            {
                Sala newSala = new Sala(
                    0,
                    Txt_nombre.Text.Trim(),
                    capacidad,
                    filas,
                    columnas,
                    Txt_tipo.Text.Trim(),
                    Rb_si.Checked ? true : false
                );
                dbSala.AddSala(newSala);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Sala {newSala.Nombre} agregada correctamente.";
            }
            else if (accion == "editar")
            {
                Sala updateSala = new Sala(
                    idSala,
                    Txt_nombre.Text.Trim(),
                    capacidad,
                    filas,
                    columnas,
                    Txt_tipo.Text.Trim(),
                    Rb_si.Checked ? true : false
                );
                dbSala.UpdateSala(updateSala);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Sala {updateSala.Nombre} actualizada correctamente.";
            }
            VolverListado?.Invoke();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            VolverListado?.Invoke();
        }
    }
}
