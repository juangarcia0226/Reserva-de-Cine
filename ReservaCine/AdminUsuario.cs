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
    public partial class AdminUsuario : Form
    {
        private CrudUsuario dbUsuario;
        List<Usuario> usuarios;
        public AdminUsuario()
        {
            InitializeComponent();
            dbUsuario = new CrudUsuario();
            LoadUsuarios();
            Lbl_usuario.Text = "USUARIOS";
        }

        private void LoadUsuarios()
        {
            usuarios = dbUsuario.GetUsuarios();

            Flp_usuarios.Controls.Clear();

            foreach (var usuario in usuarios)
            {
                var card = new UC_ListUsuario();
                card.IdUsuario = usuario.IdUsuario;
                card.Configurar(usuario.Nombre, usuario.Correo, usuario.IdRol);

                card.EditarClicked += (s, e) => MostrarFormulario("editar", usuario);
                card.EliminarClicked += (s, e) => EliminarUsuario(usuario);

                Flp_usuarios.Controls.Add(card);
            }
        }
        private void MostrarFormulario(string accion, Usuario usuario = null)
        {
            Pnl_formUsuarios.Controls.Clear();

            var formUsuario = new UC_FormUsuario(accion);

            if (accion == "editar" && usuario != null)
            {
                formUsuario.CargarDatos(usuario);
            }

            formUsuario.VolverListado += () =>
            {
                Pnl_formUsuarios.Visible = false;
                Pnl_formUsuarios.Controls.Clear();
                LoadUsuarios();
            };

            Pnl_formUsuarios.Controls.Add(formUsuario);
            Pnl_formUsuarios.Location = new Point(73, 182);
            Pnl_formUsuarios.Visible = true;
            Pnl_formUsuarios.BringToFront();
        }

        private void EliminarUsuario(Usuario usuario)
        {
            var confirm = MessageBox.Show($"¿Deseas eliminar el usuario: '{usuario.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                dbUsuario.DeleteUsuario(usuario.IdUsuario);
                LoadUsuarios();
            }
        }

        private void AdminUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void Btn_salas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSala adminSala = new AdminSala();
            adminSala.Show();
        }

        private void Btn_funciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFuncion adminFuncion = new AdminFuncion();
            adminFuncion.Show();
        }

        private void AdminUsuario_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MostrarFormulario("agregar");
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = NormalizarTexto(Txt_buscar.Text);

            if (string.IsNullOrWhiteSpace(Txt_buscar.Text))
            {
                LoadUsuarios();
                return;
            }
            
            usuarios = dbUsuario.GetUsuarios();
            List<Usuario> filtrados = usuarios.Where(u => NormalizarTexto(u.Correo).Contains(filtro)).ToList();

            Flp_usuarios.Controls.Clear();
            foreach (var user in filtrados)
            {
                var card = new UC_ListUsuario();
                card.IdUsuario = user.IdUsuario;
                card.Configurar(user.Nombre, user.Correo, user.IdRol);

                card.EditarClicked += (s, e2) => MostrarFormulario("editar", user);
                card.EliminarClicked += (s, e2) => EliminarUsuario(user);

                Flp_usuarios.Controls.Add(card);
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
