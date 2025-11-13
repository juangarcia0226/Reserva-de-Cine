using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ReservaCine
{
    public partial class UserContrasena: Form
    {
        private CrudUsuario dbUsuario;
        List<Usuario> usuarios;
        private int codigoVerificacion;
        private Usuario usuarioEncontrado;
        public UserContrasena()
        {
            InitializeComponent();

            Lbl_titulo.Text = "Ingrese su correo registrado para enviar un código de verificación.";
            Lbl_correo.Text = "Correo:";
            Lbl_codigo.Text = "Código:";

            dbUsuario = new CrudUsuario();
            usuarios = dbUsuario.GetUsuarios();
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                string correoDestino = Txt_correo.Text.Trim();

                if (string.IsNullOrEmpty(correoDestino))
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                usuarioEncontrado = usuarios.FirstOrDefault(u => u.Correo == correoDestino); 

                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Correo electrónico no registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar código aleatorio de 6 dígitos
                Random rnd = new Random();
                int codigo = rnd.Next(100000, 999999);

                // Guardar el código 
                codigoVerificacion = codigo;

                // Configurar mensaje
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("reservacine.app@gmail.com", "ReservaCine");
                mensaje.To.Add(correoDestino);
                mensaje.Subject = "Código de verificación - ReservaCine";
                mensaje.Body = $"Tu código de verificación es: {codigo}";
                mensaje.IsBodyHtml = false;

                // Configurar cliente SMTP de Gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("reservacine.app@gmail.com", "raxxykrswkhqmbyn"); 
                smtp.EnableSsl = true;

                // Enviar el correo
                smtp.Send(mensaje);

                MessageBox.Show("Se ha enviado un código de verificación a tu correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //mostrar el TextBox para ingresar el código
                Lbl_codigo.Visible = true;
                Txt_codigo.Visible = true;
                Btn_verificar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            if (Txt_codigo.Text == codigoVerificacion.ToString())
            {
                this.Hide();
                UserContrasena2 userContrasena2 = new UserContrasena2(usuarioEncontrado);
                userContrasena2.Show();
                Txt_codigo.Clear();
                Txt_correo.Clear();
            }
            else
            {
                MessageBox.Show("Código invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formLogin = new Form1();
            formLogin.Show();
        }
    }
}
