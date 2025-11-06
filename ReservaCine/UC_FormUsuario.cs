using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string ImagenSeleccionada { get; set; }

        public event Action VolverListado;
        public UC_FormUsuario(string accion)
        {
            InitializeComponent();
            Lbl_tipoUsuario.Text = "Tipo de usuario:";
            Lbl_nombre.Text = "Nombre:";
            Lbl_correo.Text = "Correo:";
            Lbl_contrasena.Text = "Contraseña:";
            Lbl_imagen.Text = "Imagen";

            this.accion = accion;
            dbUsuario = new CrudUsuario();
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void CargarDatos(Usuario usuario)
        {
            idUsuario = usuario.IdUsuario;
            Txt_name_user.Text = usuario.Nombre;
            Txt_correo.Text = usuario.Correo;
            Txt_pass_register.Text = usuario.Contrasena;

            //Asignar el tipo de usuario al ComboBox
            if (usuario.IdRol == 1) 
            { 
                Cbx_usuario.SelectedIndex = Cbx_usuario.Items.IndexOf("Administrador"); 
            }
            else if (usuario.IdRol == 2) 
            { 
                Cbx_usuario.SelectedIndex = Cbx_usuario.Items.IndexOf("Usuario"); 
            }

            // Guardar la ruta de imagen existente o usar una por defecto
            ImagenSeleccionada = string.IsNullOrEmpty(usuario.Imagen)
                ? "ImagenesUsuarios\\default.png"
                : usuario.Imagen;

            // Construir la ruta física real desde el proyecto
            string rutaFisica = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", ImagenSeleccionada)
            );

            // Mostrar la imagen si existe
            if (File.Exists(rutaFisica))
            {
                // Liberar cualquier imagen previamente cargada
                if (Pbx_imagen.Image != null)
                {
                    Pbx_imagen.Image.Dispose();
                    Pbx_imagen.Image = null;
                }

                // Cargar sin bloquear el archivo
                using (var stream = new FileStream(rutaFisica, FileMode.Open, FileAccess.Read))
                {
                    Pbx_imagen.Image = Image.FromStream(stream);
                }
                Pbx_imagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Si no existe, carga un placeholder o limpia
                Pbx_imagen.Image = null;
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

            if (string.IsNullOrWhiteSpace(Txt_correo.Text))
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

            //Sino se ingreso imagen por defecto es 'default.png'
            string imagen = string.IsNullOrEmpty(ImagenSeleccionada) ? "default.png" : ImagenSeleccionada;

            if (accion == "agregar")
            {
                Usuario newUsuario = new Usuario(
                    0,
                    Txt_name_user.Text.Trim(),
                    Txt_correo.Text.Trim(),
                    Txt_pass_register.Text.Trim(),
                    imagen,
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
                    Txt_correo.Text.Trim(),
                    Txt_pass_register.Text.Trim(),
                    imagen,
                    (Cbx_usuario.SelectedItem.ToString() == "Administrador" ? 1 : 2)
                );
                dbUsuario.UpdateUsuario(updateUsuario);
                Lbl_error.ForeColor = Color.FromArgb(40, 167, 69);
                Lbl_error.Text = $"Usuario {updateUsuario.IdUsuario} actualizado correctamente.";
            }
            VolverListado?.Invoke();
        }

        private void Btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Verificar que el usuario haya escrito un correo antes
                if (string.IsNullOrWhiteSpace(Txt_correo.Text))
                {
                    MessageBox.Show("Por favor, ingrese su correo antes de seleccionar la imagen.",
                                    "Correo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ruta de la carpeta de destino dentro del proyecto
                string carpetaDestino = Path.GetFullPath(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ImagenesUsuarios")
                );

                // Crear la carpeta si no existe
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                // Validar tamaño del archivo (< 2 MB)
                FileInfo infoArchivo = new FileInfo(ofd.FileName);
                long maxBytes = 2 * 1024 * 1024; // 2 MB
                if (infoArchivo.Length > maxBytes)
                {
                    MessageBox.Show("El tamaño máximo permitido es de 2 MB.",
                                    "Archivo demasiado grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Limpiar correo para usarlo como nombre de archivo (sin caracteres inválidos)
                    string correoLimpio = Txt_correo.Text.Trim()
                        .Replace("@", "_at_")
                        .Replace(".", "_dot_");

                    // Reemplazar caracteres no válidos por guion bajo
                    char[] invalidChars = Path.GetInvalidFileNameChars();
                    foreach (char c in invalidChars)
                        correoLimpio = correoLimpio.Replace(c, '_');

                    // Conservar extensión original
                    string extension = Path.GetExtension(ofd.FileName).ToLower();

                    // Crear nombre único: correo_limpio.extensión
                    string nombreArchivo = $"{correoLimpio}{extension}";

                    // Construir ruta completa de destino
                    string destino = Path.Combine(carpetaDestino, nombreArchivo);

                    // Copiar imagen a la carpeta del proyecto (sobrescribe si ya existe)
                    File.Copy(ofd.FileName, destino, true);

                    // Mostrar imagen sin bloquear el archivo
                    using (var stream = new FileStream(destino, FileMode.Open, FileAccess.Read))
                    {
                        Pbx_imagen.Image = Image.FromStream(stream);
                    }

                    // Guardar la ruta relativa (incluye carpeta)
                    this.ImagenSeleccionada = Path.Combine("ImagenesUsuarios", nombreArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
