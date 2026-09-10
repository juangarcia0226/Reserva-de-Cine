namespace ReservaCine
{
    partial class UC_UserFuncionInfo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_descripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_duracion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_genero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_director = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pbx_imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(37, 20);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(64, 30);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Título:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(37, 67);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(95, 25);
            this.Lbl_descripcion.TabIndex = 1;
            this.Lbl_descripcion.Text = "Descripción:";
            // 
            // Lbl_duracion
            // 
            this.Lbl_duracion.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_duracion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_duracion.Location = new System.Drawing.Point(37, 107);
            this.Lbl_duracion.Name = "Lbl_duracion";
            this.Lbl_duracion.Size = new System.Drawing.Size(76, 25);
            this.Lbl_duracion.TabIndex = 2;
            this.Lbl_duracion.Text = "Duración:";
            // 
            // Lbl_genero
            // 
            this.Lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_genero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_genero.Location = new System.Drawing.Point(38, 147);
            this.Lbl_genero.Name = "Lbl_genero";
            this.Lbl_genero.Size = new System.Drawing.Size(63, 25);
            this.Lbl_genero.TabIndex = 3;
            this.Lbl_genero.Text = "Genero:";
            // 
            // Lbl_director
            // 
            this.Lbl_director.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_director.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_director.Location = new System.Drawing.Point(38, 187);
            this.Lbl_director.Name = "Lbl_director";
            this.Lbl_director.Size = new System.Drawing.Size(68, 25);
            this.Lbl_director.TabIndex = 4;
            this.Lbl_director.Text = "Director:";
            // 
            // Pbx_imagen
            // 
            this.Pbx_imagen.ImageRotate = 0F;
            this.Pbx_imagen.Location = new System.Drawing.Point(424, 20);
            this.Pbx_imagen.Name = "Pbx_imagen";
            this.Pbx_imagen.Size = new System.Drawing.Size(206, 174);
            this.Pbx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_imagen.TabIndex = 5;
            this.Pbx_imagen.TabStop = false;
            // 
            // UC_UserFuncionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pbx_imagen);
            this.Controls.Add(this.Lbl_director);
            this.Controls.Add(this.Lbl_genero);
            this.Controls.Add(this.Lbl_duracion);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "UC_UserFuncionInfo";
            this.Size = new System.Drawing.Size(643, 225);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_descripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_duracion;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_genero;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_director;
        private Guna.UI2.WinForms.Guna2PictureBox Pbx_imagen;
    }
}
