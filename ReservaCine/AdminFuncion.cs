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
    public partial class AdminFuncion: Form
    {
        private CrudFuncion dbFuncion;
        List<Funcion> funciones;
        public AdminFuncion()
        {
            InitializeComponent();

            dbFuncion = new CrudFuncion();
            Lbl_funcion.Text = "FUNCIONES";
        
            LoadFunciones();
        }

        private void LoadFunciones ()
        {
            funciones = dbFuncion.GetFuncion();

            Flp_funciones.Controls.Clear();

            foreach (var funcion in funciones)
            {
                var card = new UC_ListFuncion();
                card.IdFuncion = funcion.IdFuncion;
                card.Configurar(funcion.Descripcion, funcion.IdPelicula, funcion.IdSala, funcion.Fecha, funcion.Horario);

                card.EditarClicked += (s, e) => MostrarFormulario("editar", funcion);
                card.EliminarClicked += (s, e) => EliminarFuncion(funcion);

                Flp_funciones.Controls.Add(card);
            }
        }

        private void MostrarFormulario(string accion, Funcion funcion = null)
        {
            Pnl_formFuncion.Controls.Clear();

            var formFuncion = new UC_FormFuncion(accion);

            if(accion == "editar" && funcion != null)
            {
                formFuncion.CargarDatos(funcion);
            }

            formFuncion.VolverListado += () =>
            {
                Pnl_formFuncion.Visible = false;
                Pnl_formFuncion.Controls.Clear();
                LoadFunciones();
            };

            Pnl_formFuncion.Controls.Add(formFuncion);
            Pnl_formFuncion.Location = new Point(126, 173);
            Pnl_formFuncion.Visible = true;
            Pnl_formFuncion.BringToFront();
        }

        private void EliminarFuncion(Funcion funcion)
        {
            var confirm = MessageBox.Show($"¿Desea eliminar la función '{funcion.Descripcion}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) 
            {
                dbFuncion.DeleteFuncion(funcion.IdFuncion);
                LoadFunciones();
            }
        }

        private void AdminFuncion_Load(object sender, EventArgs e)
        {
            LoadFunciones();
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

        private void Btn_salas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSala adminSala = new AdminSala();
            adminSala.Show();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsuario adminUsuario = new AdminUsuario();
            adminUsuario.Show();
        }

        private void AdminFuncion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = NormalizarTexto(Txt_buscar.Text);   
            
            if (string.IsNullOrWhiteSpace(filtro))
            {
                LoadFunciones();
                return;
            }

            List<Funcion> filtradas = funciones.Where(s => NormalizarTexto(s.Descripcion).Contains(filtro)).ToList();

            Flp_funciones.Controls.Clear();
            foreach (var funcion  in filtradas)
            {
                var card = new UC_ListFuncion();
                card.IdFuncion = funcion.IdFuncion;
                card.Configurar(funcion.Descripcion, funcion.IdPelicula, funcion.IdSala, funcion.Fecha, funcion.Horario);

                card.EditarClicked += (s, e2) => MostrarFormulario("editar", funcion);
                card.EliminarClicked += (s, e2) => EliminarFuncion(funcion);

                Flp_funciones.Controls.Add(card);
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
