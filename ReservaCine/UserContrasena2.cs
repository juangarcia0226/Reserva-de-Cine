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
    public partial class UserContrasena2: Form
    {
        private Usuario usuario;
        public UserContrasena2(Usuario usuario)
        {
            InitializeComponent();

            Lbl_titulo.Text = "Ingrese una nueva contraseña:";
            Lbl_contrasena.Text = "Nueva contraseña:";
            Lbl_nueva.Text = "Confirme la nueva contraseña:";

            this.usuario = usuario;
        }

        private void Btn_ver1_Click(object sender, EventArgs e)
        {
            if (Txt_contrasena.UseSystemPasswordChar == true)
            {
                Txt_contrasena.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_contrasena.UseSystemPasswordChar = true;
            }
        }

        private void Btn_ver2_Click(object sender, EventArgs e)
        {
            if (Txt_confirmar.UseSystemPasswordChar == true)
            {
                Txt_confirmar.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_confirmar.UseSystemPasswordChar = true;
            }
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formLogin = new Form1();
            formLogin.Show();
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_contrasena.Text))
            {
                MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_confirmar.Text))
            {
                MessageBox.Show("Ingrese la confirmación de la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que la contraseña tenga un número, simbolo y que sea mínimo de 8 caracteres
            bool tieneNumero = Txt_contrasena.Text.Trim().Any(char.IsDigit);
            bool tieneSimbolo = Txt_contrasena.Text.Trim().Any(ch => !char.IsLetterOrDigit(ch));

            if (Txt_contrasena.Text.Trim().Length < 8 || !tieneNumero || !tieneSimbolo)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, un número y un símbolo.", "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Txt_contrasena.Text.Trim() != Txt_confirmar.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Contrasena = Txt_contrasena.Text.Trim();

            try
            {
                CrudUsuario dbUsuario = new CrudUsuario();
                dbUsuario.UpdateUsuario(usuario);

                MessageBox.Show("Cambio de contraseña exitoso. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Txt_contrasena.Clear();
                Txt_confirmar.Clear();
                this.Hide();
                Form1 formLogin = new Form1();
                formLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserContrasena2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
