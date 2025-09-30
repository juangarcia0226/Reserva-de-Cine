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
            DbUsuario.GetUsuarios();
        }

        private void Btn_iniciar_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Txt_user_login.Text) || string.IsNullOrWhiteSpace(Txt_pass_login.Text))
            {
                Lbl_error_login.Text = "Complete los campos";
                Lbl_error_login.ForeColor = Color.Red;
            }
            else
            {
                for (int i = 0; i < Usuarios.Count; i++)
                {
                    
                }
            }
        }
    }
}
