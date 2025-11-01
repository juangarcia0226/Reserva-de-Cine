using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public AdminSala()
        {
            InitializeComponent();

            dbSala = new CrudSala();
            LoadSalas();

            Lbl_sala.Text = "SALAS";
        }

        private void LoadSalas()
        {
            salas = dbSala.GetSalas();
            
            Flp_salas.Controls.Clear();

            foreach (var sala in salas)
            {
                var card = new UC_ListSala();
                card.IdSala = sala.IdSala;
                card.Configurar(sala.Nombre, sala.Capacidad, sala.Filas, sala.Columnas, sala.Tipo, sala.Estado);

                card.EditarClicked += (s, e) => MostrarFormulario("editar", sala);
                card.EliminarClicked += (s, e) => EliminarSala(sala);

                Flp_salas.Controls.Add(card);
            }
        }

        private void MostrarFormulario(string accion, Sala sala = null)
        {
            Pnl_formSala.Controls.Clear();

            var formSala = new UC_FormSala(accion);

            if (accion == "editar" && sala != null)
            {
                formSala.CargarDatos(sala);
            }

            formSala.VolverListado += () =>
            {
                Pnl_formSala.Visible = false;
                Pnl_formSala.Controls.Clear();
                LoadSalas();
            };

            Pnl_formSala.Controls.Add(formSala);
            Pnl_formSala.Location = new Point(135, 164);
            Pnl_formSala.Visible = true;
            Pnl_formSala.BringToFront();
        }

        private void EliminarSala(Sala sala)
        {
            var confirm = MessageBox.Show($"¿Deseas eliminar la sala '{sala.Nombre}'?","Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                dbSala.DeleteSala(sala.IdSala);
                LoadSalas();
            }
        }

        private void AdminSala_Load(object sender, EventArgs e)
        {
            LoadSalas();

        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MostrarFormulario("agregar");
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsuario adminUsuario = new AdminUsuario();
            adminUsuario.Show();
        }

        private void Btn_funciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFuncion adminFuncion = new AdminFuncion();
            adminFuncion.Show();
        }

        private void AdminSala_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = NormalizarTexto(Txt_buscar.Text);

            if (string.IsNullOrWhiteSpace(Txt_buscar.Text))
            {
                LoadSalas();
                return;
            }

            List<Sala> filtradas = salas.Where(s => NormalizarTexto(s.Nombre).Contains(filtro)).ToList();

            Flp_salas.Controls.Clear();
            foreach (var sala in filtradas)
            {
                var card = new UC_ListSala();
                card.IdSala = sala.IdSala;
                card.Configurar(sala.Nombre, sala.Capacidad, sala.Filas, sala.Columnas, sala.Tipo, sala.Estado);

                card.EditarClicked += (s, e2) => MostrarFormulario("editar", sala);
                card.EliminarClicked += (s, e2) => EliminarSala(sala);

                Flp_salas.Controls.Add(card);
            }
        }

        //Quita tildes y pasa a minusculas el texto ingresado
        private string NormalizarTexto(string texto)
        {
            return new string(texto
                .Normalize(NormalizationForm.FormD)
                .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray()
            ).ToLower();
        }
    }
}
