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
    public partial class Form1: Form
    {
        //Generar variable de la clase CrudUsuario
        private CrudUsuario DbUsuario;
        //Lista para guardar los usuarios
        List<Usuario> Usuarios;
        public Form1()
        {
            InitializeComponent();

            //Crear objeto/instanciar
            DbUsuario = new CrudUsuario();
            Usuarios = DbUsuario.GetUsuarios();

            Lbl_correo.Text = "Correo:";
            Lbl_contrasena.Text = "Contraseña: ";
            Lbl_error_login.ForeColor = Color.DarkGray;

            /*Usuario admin = new Usuario(0, "Admin", "admin@a.com", "admin123", "default.png", 1);
            CrudUsuario dbUsuario = new CrudUsuario();
            dbUsuario.AddUsuario(admin);*/
        }

        private void Btn_iniciar_login_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();

            this.Hide();
            UserHome userHome = new UserHome();
            userHome.Show(); */

            if (string.IsNullOrWhiteSpace(Txt_user_login.Text))
            {
                Lbl_error_login.Text = "Ingrese un correo.";
                Lbl_error_login.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_pass_login.Text))
            {
                Lbl_error_login.Text = "Ingrese una contraseña.";
                Lbl_error_login.ForeColor = Color.Red;
                return;
            }

            Usuario usuarioEncontrado = Usuarios.FirstOrDefault(u => u.Correo == Txt_user_login.Text);

            if (usuarioEncontrado != null && CifradoPSW.VerificarPassword(Txt_pass_login.Text, usuarioEncontrado.Contrasena))
            {
                if (usuarioEncontrado.IdRol == 1) // admin
                {
                    this.Hide();
                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                }
                else
                {
                    this.Hide();
                    UserHome userHome = new UserHome(usuarioEncontrado);
                    userHome.Show();
                }
            }
            else
            {
                Lbl_error_login.Text = "Correo o contraseña inválida";
                Lbl_error_login.ForeColor = Color.Red;
            }
        }

        private void Btn_register_login_Click(object sender, EventArgs e)
        {
            MostrarFormulario();
        }

        //Este método muestra el formulario para editar o agregar una película
        private void MostrarFormulario()
        {
            // Limpia cualquier formulario anterior
            Pnl_form.Controls.Clear();

            var formUsuario = new UC_FormLogin();

            formUsuario.VolverLogin += () =>
            {
                Pnl_form.Visible = false;
                Pnl_form.Controls.Clear();
                Usuarios = DbUsuario.GetUsuarios();
            };

            Pnl_form.Controls.Add(formUsuario);
            Pnl_form.Location = new Point(82, 64);
            Pnl_form.Visible = true;
            Pnl_form.BringToFront();
        }
    }
}
