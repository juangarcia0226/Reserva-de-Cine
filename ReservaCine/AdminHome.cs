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
    public partial class AdminHome: Form
    {
        private bool menuExpandido = true;
        private const int MAX_ANCHO = 100;
        private const int MIN_ANCHO = 40;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void Tmr_menu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                Pnl_menu_left.Width -= 10;
                if (Pnl_menu_left.Width <= MIN_ANCHO)
                {
                    Tmr_menu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                Pnl_menu_left.Width += 10;
                if (Pnl_menu_left.Width >= MAX_ANCHO)
                {
                    Tmr_menu.Stop();
                    menuExpandido = true;
                }
            }
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            Tmr_menu.Start();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
