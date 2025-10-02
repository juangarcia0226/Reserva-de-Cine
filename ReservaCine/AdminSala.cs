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
    public partial class AdminSala: Form
    {
        private CrudSala dbSala;
        List<Sala> salas;
        private bool menuExpandido = true;
        private const int MAX_ANCHO = 212, MIN_ANCHO = 40;
        int idSalaSearch = 0;
        public AdminSala()
        {
            InitializeComponent();

            dbSala = new CrudSala();
            LoadSalas();

            Lbl_sala.Text = "SALAS";
            Lbl_btnSala.Text = "Salas";
            Lbl_pelicula.Text = "Películas";
        }

        private void LoadSalas()
        {
            salas = dbSala.GetSalas();
            Dgv_sala.DataSource = salas;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_nombre.Text))
            {
                if (!int.TryParse(Txt_capacidad.Text, out int capacidad))
                {
                    Lbl_error.Text = "Ingrese una capacidad valida (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (!int.TryParse(Txt_filas.Text, out int filas))
                {
                    Lbl_error.Text = "Ingrese filas validas (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (!int.TryParse(Txt_columnas.Text, out int columnas))
                {
                    Lbl_error.Text = "Ingrese columnas validas (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }

                Sala newSala = new Sala(0, Txt_nombre.Text, capacidad, filas, columnas, Txt_tipo.Text, Rb_si.Checked);
                dbSala.AddSala(newSala);

                Lbl_error.Text = "Sala guardada correctamente";
                Lbl_error.ForeColor = Color.SeaGreen;
                LoadSalas();
            }
            else
            {
                Lbl_error.Text = "No se ingresó el título de la sala";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_nombre.Text))
            {
                string salaBusacada = Txt_nombre.Text.Trim();

                Sala sala = salas.FirstOrDefault(s => s.Nombre.Equals(salaBusacada, StringComparison.OrdinalIgnoreCase));

                if (sala != null)
                {
                    Txt_nombre.Text = sala.Nombre;
                    Txt_capacidad.Text = Convert.ToString(sala.Capacidad);
                    Txt_filas.Text = Convert.ToString(sala.Filas);
                    Txt_columnas.Text = Convert.ToString(sala.Columnas);
                    Txt_tipo.Text = sala.Tipo;
                    Rb_si.Checked = sala.Estado == true ? true : false;
                    Rb_no.Checked = sala.Estado == false ? true : false;

                    idSalaSearch = sala.IdSala;
                    Lbl_error.Text = "";
                }
                else
                {
                    Lbl_error.Text = "La sala no está guardada";
                    Lbl_error.ForeColor = Color.Crimson;
                }
            }
            else
            {
                Lbl_error.Text = "No se ingresó el nombre de la sala";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_nombre.Text))
            {
                if (!int.TryParse(Txt_capacidad.Text, out int capacidad))
                {
                    Lbl_error.Text = "Ingrese una capacidad valida (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (!int.TryParse(Txt_filas.Text, out int filas))
                {
                    Lbl_error.Text = "Ingrese filas validas (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (!int.TryParse(Txt_columnas.Text, out int columnas))
                {
                    Lbl_error.Text = "Ingrese columnas validas (Número)";
                    Lbl_error.ForeColor = Color.Crimson;
                    return;
                }
                if (idSalaSearch != 0)
                {
                    Sala updateSala = new Sala(idSalaSearch, Txt_nombre.Text, capacidad, filas, columnas, Txt_tipo.Text, Rb_si.Checked);
                    dbSala.UpdateSala(updateSala);

                    Lbl_error.Text = $"Sala {updateSala.Nombre} actualizada correctamente";
                    Lbl_error.ForeColor = Color.SeaGreen;
                    LoadSalas();
                }
                else
                {
                    Lbl_error.Text = "Para actualizar primero tiene que buscar una sala";
                    Lbl_error.ForeColor = Color.Crimson;
                }
            }
            else
            {
                Lbl_error.Text = "No se ingresó el nombre de la sala";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idSalaSearch != 0)
            {
                dbSala.DeleteSala(idSalaSearch);

                Lbl_error.Text = $"Sala {Txt_nombre.Text} ELIMINADA correctamente";
                Lbl_error.ForeColor = Color.SeaGreen;
                LoadSalas();
            }
            else
            {
                Lbl_error.Text = "Para eliminar primero tiene que buscar una sala";
                Lbl_error.ForeColor = Color.Crimson;
            }
        }

        private void Btn_pelicula_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void AdminSala_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Tmr_sala.Start();
        }

        private void Tmr_sala_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                Pnl_menu_left.Width -= 10;
                if (Pnl_menu_left.Width <= MIN_ANCHO)
                {
                    Tmr_sala.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                Pnl_menu_left.Width += 10;
                if (Pnl_menu_left.Width >= MAX_ANCHO)
                {
                    Tmr_sala.Stop();
                    menuExpandido = true;
                }
            }
        }
    }
}
