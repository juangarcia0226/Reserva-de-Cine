using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCine
{
    public partial class UC_UserAsiento: UserControl
    {
        public string CodigoAsiento { get; set; }
        public int IdAsiento { get; set; }

        public enum EstadoAsiento
        {
            Disponible,
            Ocupado,
            Seleccionado
        }

        private EstadoAsiento estado;
        public EstadoAsiento Estado
        {
            get => estado;
            set
            {
                estado = value;
                Invalidate(); // Redibuja con el nuevo color
            }
        }

        public event EventHandler OnSeleccionar;
        public UC_UserAsiento()
        {
            InitializeComponent();

            this.Size = new Size(40, 40);
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            this.Click += UC_UserAsiento_Click;
        }

        private void UC_UserAsiento_Click(object sender, EventArgs e)
        {
            if (Estado == EstadoAsiento.Ocupado)
                return;

            if (Estado == EstadoAsiento.Disponible)
                Estado = EstadoAsiento.Seleccionado;
            else if (Estado == EstadoAsiento.Seleccionado)
                Estado = EstadoAsiento.Disponible;

            OnSeleccionar?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Colores según estado
            Color color = Color.White;

            if (Estado == EstadoAsiento.Ocupado)
                color = Color.Red;
            else if (Estado == EstadoAsiento.Seleccionado)
                color = Color.Green;

            // Dibuja círculo
            using (SolidBrush sb = new SolidBrush(color))
            {
                g.FillEllipse(sb, 2, 2, this.Width - 4, this.Height - 4);
            }

            // Borde gris
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                g.DrawEllipse(pen, 2, 2, this.Width - 4, this.Height - 4);
            }

            // Código del asiento
            using (Font f = new Font("Segoe UI", 8, FontStyle.Bold))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString(CodigoAsiento, f, Brushes.Black, this.ClientRectangle, sf);
            }
        }
    }
}
