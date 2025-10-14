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
    public partial class AdminSala: Form
    {
        private CrudSala dbSala;
        List<Sala> salas;
        public AdminSala()
        {
            InitializeComponent();

            dbSala = new CrudSala();
            LoadSalas();

            Lbl_sala.Text = "SALAS";
        }

        private void LoadSalas()
        {
            salas = dbSala.GetSalas();
            
            Flp_salas.Controls.Clear();

            foreach (var sala in salas)
            {
                var card = new UC_ListSala();
                card.IdSala = sala.IdSala;
                card.Configurar(sala.Nombre, sala.Capacidad, sala.Filas, sala.Columnas, sala.Tipo, sala.Estado);

                card.EditarClicked += (s, e) => MostrarFormulario("editar", sala);
                card.EliminarClicked += (s, e) => EliminarSala(sala);

                Flp_salas.Controls.Add(card);
            }
        }

        private void MostrarFormulario(string accion, Sala sala = null)
        {

        }

        private void EliminarSala(Sala sala)
        {

        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void AdminSala_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
