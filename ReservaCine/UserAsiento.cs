using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservaCine
{
    public partial class UserAsiento: Form
    {
        private int idPelicula;
        private Funcion funcion;
        private Usuario usuario;
        private List<UC_UserAsiento> asientosSeleccionados = new List<UC_UserAsiento>();

        public UserAsiento(int idPelicula, Funcion funcion, Usuario usuario)
        {
            InitializeComponent();

            this.idPelicula = idPelicula;
            this.funcion = funcion;
            this.usuario = usuario;

            Lbl_asientos.Text = "Asientos";
            Lbl_pantalla.Text = "Pantalla";
            Lbl_pantalla.Size = new Size(675, 33);
            Lbl_pantalla.BackColor = Color.Gray;
            Lbl_seleccionados.Text = "Asientos seleccionados:";
            Lbl_usuario.Text = usuario.Nombre;

            MostrarInfoPelicula();
            MostrarAsientos();
            CrearLeyenda();
            CargarFotoUsuario(usuario);

            Flp_leyenda.FlowDirection = FlowDirection.LeftToRight;
            Flp_leyenda.WrapContents = false;
            Flp_leyenda.AutoSize = true;
            Flp_leyenda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flp_leyenda.Padding = new Padding(10, 0, 0, 0);
        }

        private void MostrarInfoPelicula()
        {
            Pnl_funcionInfo.Controls.Clear();
            var infoPelicula = new UC_UserFuncionInfo(idPelicula);
            infoPelicula.Configurar(idPelicula);
            Pnl_funcionInfo.Controls.Add(infoPelicula);
        }

        private void MostrarAsientos()
        {
            Flp_asientos.Controls.Clear();

            CrudAsiento dbAsiento = new CrudAsiento();

            // Solo los asientos de esta función
            List<Asiento> listaAsientos = dbAsiento.GetAsientos(funcion.IdFuncion);

            // Agrupar por fila (parte alfabética del código)
            var filas = listaAsientos.GroupBy(a => new string(a.Codigo.TakeWhile(char.IsLetter).ToArray())).OrderBy(g => g.Key); // Orden A, B, C...

            foreach (var filaGrupo in filas)
            {
                FlowLayoutPanel panelFila = new FlowLayoutPanel();
                panelFila.FlowDirection = FlowDirection.LeftToRight;
                panelFila.WrapContents = false;
                panelFila.AutoSize = true;
                panelFila.Margin = new Padding(0, 8, 0, 8);
                panelFila.Padding = new Padding(0);
                panelFila.Anchor = AnchorStyles.Top;
                panelFila.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                foreach (var asiento in filaGrupo
                        .OrderBy(a => int.Parse(new string(a.Codigo.SkipWhile(char.IsLetter).ToArray()))))
                {
                    UC_UserAsiento uc = new UC_UserAsiento();

                    uc.IdAsiento = asiento.IdAsiento;
                    uc.CodigoAsiento = asiento.Codigo;

                    uc.Estado = asiento.Disponible
                        ? UC_UserAsiento.EstadoAsiento.Disponible
                        : UC_UserAsiento.EstadoAsiento.Ocupado;

                    uc.OnSeleccionar += Asiento_OnSeleccionar;

                    panelFila.Controls.Add(uc);
                }

                Flp_asientos.Controls.Add(panelFila);
            }
        }

        private void Asiento_OnSeleccionar(object sender, EventArgs e)
        {
            UC_UserAsiento asiento = sender as UC_UserAsiento;

            if (asiento.Estado == UC_UserAsiento.EstadoAsiento.Seleccionado)
            {
                // Añadir a lista si no está
                if (!asientosSeleccionados.Contains(asiento))
                {
                    asientosSeleccionados.Add(asiento);
                }
            }
            else
            {
                // Quitar si se deselecciona
                if (asientosSeleccionados.Contains(asiento))
                {
                    asientosSeleccionados.Remove(asiento);
                }
            }

            ActualizarListaAsientos();
        }

        private void ActualizarListaAsientos()
        {
            Flp_seleccionados.Controls.Clear();

            Lbl_seleccionados.Visible = asientosSeleccionados.Count > 0;
            Btn_reservar.Visible = asientosSeleccionados.Count > 0;

            foreach (var asiento in asientosSeleccionados.OrderBy(a => a.CodigoAsiento))
            {
                Label lbl = new Label();
                lbl.Text = asiento.CodigoAsiento;
                lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                lbl.AutoSize = true;
                lbl.Margin = new Padding(5);

                Flp_seleccionados.Controls.Add(lbl);
            }
        }


        private void CrearLeyenda()
        {
            Flp_leyenda.Controls.Clear();
            Flp_leyenda.FlowDirection = FlowDirection.LeftToRight;
            Flp_leyenda.WrapContents = false;

            // Disponible
            Flp_leyenda.Controls.Add(CrearItemLeyenda("Disponible", UC_UserAsiento.EstadoAsiento.Disponible));

            // Ocupado
            Flp_leyenda.Controls.Add(CrearItemLeyenda("Ocupado", UC_UserAsiento.EstadoAsiento.Ocupado));

            // Seleccionado
            Flp_leyenda.Controls.Add(CrearItemLeyenda("Seleccionado",UC_UserAsiento.EstadoAsiento.Seleccionado));
        }

        private FlowLayoutPanel CrearItemLeyenda(string texto, UC_UserAsiento.EstadoAsiento estado)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.FlowDirection = FlowDirection.LeftToRight;
            flp.AutoSize = true;
            flp.WrapContents = false;
            flp.BackColor = Color.Transparent;
            flp.Margin = new Padding(20, 3, 20, 3);

            // Mini asiento
            UC_UserAsiento asiento = new UC_UserAsiento();
            asiento.Estado = estado;
            asiento.Size = new Size(22, 22);
            asiento.Enabled = false;
            asiento.CodigoAsiento = "";
            asiento.Margin = new Padding(0, 0, 8, 0);

            // Texto legible
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lbl.AutoSize = true;
            lbl.ForeColor = Color.Black;

            flp.Controls.Add(asiento);
            flp.Controls.Add(lbl);

            return flp;
        }

        private void Btn_reservar_Click(object sender, EventArgs e)
        {
            //Validar que hay asientos seleccionados
            if (asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un asiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Confirmar con el usuario
            var confirmacion = MessageBox.Show("¿Está seguro de realizar la reserva?", "Confirmar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            //Crear la reserva en DB
            try
            {               
                CrudReserva dbReserva = new CrudReserva();

                Reserva nuevaReserva = new Reserva(
                    0,
                    usuario.IdUsuario,
                    funcion.IdFuncion,
                    DateTime.Now
                );

                int idReserva = dbReserva.AddReserva(nuevaReserva);

                if (idReserva <= 0)
                {
                    MessageBox.Show("No se pudo crear la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Guardar asientos en reserva_asiento
                foreach (var uc in asientosSeleccionados)
                {
                    dbReserva.AddReservaAsiento(idReserva, uc.IdAsiento);
                }

                //Cambiar disponibilidad de los asientos a false
                CrudAsiento dbAsiento = new CrudAsiento();

                foreach (var uc in asientosSeleccionados)
                {
                    Asiento asientoActualizado = new Asiento(
                        uc.IdAsiento,
                        funcion.IdFuncion,
                        uc.CodigoAsiento,
                        false
                    );

                    dbAsiento.UpdateAsiento(asientoActualizado);
                }

                //Enviar correo
                try
                {
                    string correoDestino = usuario.Correo; 
                    CrudPelicula dbPelicula = new CrudPelicula();
                    List<Pelicula> peliculas = dbPelicula.GetPeliculas();
                    Pelicula pelicula = peliculas.FirstOrDefault(p=> p.IdPelicula == idPelicula);

                    CrudSala dbSala = new CrudSala();
                    List<Sala> salas = dbSala.GetSalas();
                    Sala sala = salas.FirstOrDefault(s=> s.IdSala == funcion.IdSala);

                    if (string.IsNullOrEmpty(correoDestino))
                    {
                        MessageBox.Show("El usuario no tiene un correo registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Construir texto de los asientos seleccionados
                    string listaAsientos = string.Join(", ", asientosSeleccionados.Select(a => a.CodigoAsiento));
                    

                    // Armar el cuerpo del mensaje
                    string cuerpo =
                        "¡Reserva confirmada!\n\n" +
                        "Detalles de tu reserva:\n\n" +
                        $"Asientos: {listaAsientos}\n" +
                        $"Sala: {sala.Nombre}\n" + 
                        $"Película: {pelicula.Titulo}\n" +
                        $"Fecha: {funcion.Fecha.ToString("dd/MM/yyyy")}\n" +
                        $"Hora: {funcion.Horario}\n\n" +
                        "Gracias por usar ReservaCine.";

                    // Crear el mensaje
                    MailMessage mensaje = new MailMessage();
                    mensaje.From = new MailAddress("reservacine.app@gmail.com", "ReservaCine");
                    mensaje.To.Add(correoDestino);
                    mensaje.Subject = "Confirmación de reserva - ReservaCine";
                    mensaje.Body = cuerpo;
                    mensaje.IsBodyHtml = false;

                    // Configurar cliente SMTP (igual que en UserContrasena.cs)
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("reservacine.app@gmail.com", "raxxykrswkhqmbyn");
                    smtp.EnableSsl = true;

                    // Enviar
                    smtp.Send(mensaje);

                    MessageBox.Show("Reserva realizada. Se envió la información a tu correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizar la interfaz
                    asientosSeleccionados.Clear();
                    ActualizarListaAsientos();
                    MostrarAsientos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La reserva se guardó, pero ocurrió un error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la reserva:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserAsiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome userHome = new UserHome(usuario);
            userHome.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void CargarFotoUsuario(Usuario usuario)
        {
            // Si no hay imagen, usar una ruta relativa por defecto
            string rutaRelativa = string.IsNullOrEmpty(usuario.Imagen)
                ? "ImagenesUsuarios\\default.jpg"
                : usuario.Imagen;

            // Construir la ruta física completa a partir del directorio base del proyecto
            string rutaFisica = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", rutaRelativa)
            );

            // Liberar imagen previa para evitar bloqueo
            if (Pbx_usuario.Image != null)
            {
                Pbx_usuario.Image.Dispose();
                Pbx_usuario.Image = null;
            }

            // Cargar imagen si existe
            if (File.Exists(rutaFisica))
            {
                using (var stream = new FileStream(rutaFisica, FileMode.Open, FileAccess.Read))
                {
                    Pbx_usuario.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Si no existe, carga el placeholder por defecto
                string rutaDefault = Path.GetFullPath(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios\default.jpg")
                );

                if (File.Exists(rutaDefault))
                {
                    using (var stream = new FileStream(rutaDefault, FileMode.Open, FileAccess.Read))
                    {
                        Pbx_usuario.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    Pbx_usuario.Image = null;
                }
            }

            Pbx_usuario.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
