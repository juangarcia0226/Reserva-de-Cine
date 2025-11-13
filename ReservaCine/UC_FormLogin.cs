using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ReservaCine
{
    public partial class UC_FormLogin: UserControl
    {
        public string ImagenSeleccionada { get; set; }
        public event Action VolverLogin;
        public UC_FormLogin()
        {
            InitializeComponent();
            Lbl_nombre.Text = "Nombre:";
            Lbl_correo.Text = "Correo:";
            Lbl_correoConfi.Text = "Confirmar correo:";
            Lbl_contrasena.Text = "Contraseña:";
            Lbl_confirmar.Text = "Confirmar contraseña";
            Lbl_imagen.Text = "Imagen para la foto de perfil:";

            this.BorderStyle = BorderStyle.FixedSingle;

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

                // Ruta base del proyecto (no del bin)
                string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string carpetaDestino = Path.Combine(rutaProyecto, "ImagenesUsuarios");

                // Crear carpeta si no existe
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
                    // Limpiar el correo para usarlo como nombre de archivo
                    string correoLimpio = Txt_correo.Text.Trim()
                        .Replace("@", "_at_")
                        .Replace(".", "_dot_");

                    // Reemplazar caracteres inválidos del sistema de archivos
                    foreach (char c in Path.GetInvalidFileNameChars())
                        correoLimpio = correoLimpio.Replace(c, '_');

                    // Mantener extensión original
                    string extension = Path.GetExtension(ofd.FileName).ToLower();

                    // Nombre final del archivo
                    string nombreArchivo = $"{correoLimpio}{extension}";

                    // Ruta completa de destino
                    string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                    // Copiar la imagen al proyecto (sobrescribe si ya existe)
                    File.Copy(ofd.FileName, rutaDestino, true);

                    // Mostrar la imagen sin bloquear el archivo
                    using (var stream = new FileStream(rutaDestino, FileMode.Open, FileAccess.Read))
                    {
                        using (var ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            ms.Position = 0;
                            Pbx_imagen.Image = Image.FromStream(ms);
                        }
                    }

                    // Guardar la ruta relativa para luego cargarla correctamente
                    this.ImagenSeleccionada = Path.Combine("ImagenesUsuarios", nombreArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            //Validar los Txt 
            if (string.IsNullOrWhiteSpace(Txt_nombre.Text))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Ingrese un nombre.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_correo.Text))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Ingrese un correo.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_correoConfi.Text))
            {
                Lbl_error.ForeColor= Color.Red;
                Lbl_error.Text = "Ingrese la confimación del correo.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_contrasena.Text))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Ingrese una contraseña.";
                return;
            }
            if (string.IsNullOrWhiteSpace(Txt_comfirmar.Text))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Confirme la contraseña ingresada.";
                return;
            }
            if (!Txt_correo.Text.Trim().Contains("@") || !Txt_correo.Text.Trim().Contains("."))
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "El correo tiene una estructura inválida.";
                return;
            }

            if (Txt_correo.Text.Trim() != Txt_correoConfi.Text.Trim())
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "Los correos no coinciden";
                return;
            }
            if (Txt_contrasena.Text != Txt_comfirmar.Text)
            {
                Lbl_error.ForeColor = Color.Red;
                Lbl_error.Text = "La contraseña NO coincide.";
            }

            //Validar que la contraseña tenga un número, simbolo y que sea mínimo de 8 caracteres
            bool tieneNumero = Txt_contrasena.Text.Trim().Any(char.IsDigit);
            bool tieneSimbolo = Txt_contrasena.Text.Trim().Any(ch => !char.IsLetterOrDigit(ch));

            if (Txt_contrasena.Text.Trim().Length < 8 || !tieneNumero || !tieneSimbolo)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, un número y un símbolo.", "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar si el correo ya está registrado
            CrudUsuario crudUsuario = new CrudUsuario();
            var usuarios = crudUsuario.GetUsuarios();

            if (usuarios.Any(u => u.Correo.Equals(Txt_correo.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El correo ya está registrado. Intente con otro", "Correo registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Sino se ingreso imagen por defecto es 'default.png'
            string imagen = string.IsNullOrEmpty(ImagenSeleccionada) ? Path.Combine("ImagenesUsuarios", "default.jpg") : ImagenSeleccionada;

            //Crear nuevo usuario
            Usuario newUsuario = new Usuario(
                0,
                Txt_nombre.Text.Trim(),
                Txt_correo.Text.Trim(),
                Txt_contrasena.Text.Trim(),
                imagen,
                2
            );

            //Try para el registro del nuevo usuario
            try
            {
                CrudUsuario crud = new CrudUsuario();
                crud.AddUsuario(newUsuario);

                MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpiar campos del form
                Txt_nombre.Clear();
                Txt_correo.Clear();
                Txt_correoConfi.Clear();
                Txt_contrasena.Clear();
                Pbx_imagen.Image = null;
                ImagenSeleccionada = null;

                VolverLogin?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            // Limpia los campos
            Txt_nombre.Clear();
            Txt_correo.Clear();
            Txt_correoConfi.Clear();
            Txt_contrasena.Clear();
            Pbx_imagen.Image = null;
            ImagenSeleccionada = null;

            
            VolverLogin?.Invoke();
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
            if (Txt_comfirmar.UseSystemPasswordChar == true)
            {
                Txt_comfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_comfirmar.UseSystemPasswordChar= true;
            }
        }
    }
}
