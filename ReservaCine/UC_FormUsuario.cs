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
    public partial class UC_FormUsuario : UserControl
    {
        private string accion; //"agregar" o "editar"
        private CrudUsuario dbUsuario;
        private int idUsuario;

        public event Action VolverListado;
        public UC_FormUsuario(string accion)
        {
            InitializeComponent();
            Lbl_tipoUsuario.Text = "Tipo de usuario:";
            Lbl_nombre.Text = "Nombre:";
            Lbl_correo.Text = "Correo:";
            Lbl_contrasena.Text = "Contraseña:";
            
            this.accion = accion;
            dbUsuario = new CrudUsuario();
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void CargarDatos(Usuario usuario)
        {
            idUsuario = usuario.IdUsuario;
            Txt_name_user.Text = usuario.Nombre;
            Txt_mail.Text = usuario.Correo;
            Txt_pass_register.Text = usuario.Contrasena; 

            if (usuario.IdRol == 1)
            {
                Cbx_usuario.SelectedIndex = Cbx_usuario.Items.IndexOf("Administrador");
            }
            else if (usuario.IdRol == 2)
            {
                Cbx_usuario.SelectedIndex = Cbx_usuario.Items.IndexOf("Usuario");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            VolverListado?.Invoke();   
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_name_user.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe ingresar un nombre para el usuario.";
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_mail.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe ingresar un correo.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_pass_register.Text))
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe ingresar una contraseña.";
                return;
            }
            if (Cbx_usuario.SelectedItem == null || (Cbx_usuario.SelectedItem.ToString() != "Administrador" && Cbx_usuario.SelectedItem.ToString() != "Usuario") )
            {
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Debe elegir un tipo de usuario.";
                return;
            }

            if (accion == "agregar")
            {
                Usuario newUsuario = new Usuario(
                    0,
                    Txt_name_user.Text.Trim(),
                    Txt_pass_register.Text.Trim(),
                    Txt_mail.Text.Trim(),
                    (Cbx_usuario.SelectedItem.ToString() == "Administrador" ? 1 : 2)
                );
                dbUsuario.AddUsuario(newUsuario);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Usuario {newUsuario.Nombre} agregado correctamente.";
            }
            else if (accion == "editar")
            {
                Usuario updateUsuario = new Usuario(
                    idUsuario,
                    Txt_name_user.Text.Trim(),
                    Txt_pass_register.Text.Trim(),
                    Txt_mail.Text.Trim(),
                    (Cbx_usuario.SelectedItem.ToString() == "Administrador" ? 1 : 2)
                );
                dbUsuario.UpdateUsuario(updateUsuario);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Usuario {updateUsuario.IdUsuario} actualizado correctamente.";
            }
            VolverListado?.Invoke();
        }
    }
}
