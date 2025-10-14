namespace ReservaCine
{
    partial class UC_FormPelicula
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
            this.Pnl_datos = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_titulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_duracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_genero = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_reparto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_director = new Guna.UI2.WinForms.Guna2TextBox();
            this.Dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Lbl_fecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.Controls.Add(this.Btn_cancelar);
            this.Pnl_datos.Controls.Add(this.Btn_aceptar);
            this.Pnl_datos.Controls.Add(this.Txt_titulo);
            this.Pnl_datos.Controls.Add(this.Txt_descripcion);
            this.Pnl_datos.Controls.Add(this.Txt_duracion);
            this.Pnl_datos.Controls.Add(this.Txt_genero);
            this.Pnl_datos.Controls.Add(this.Txt_reparto);
            this.Pnl_datos.Controls.Add(this.Lbl_error);
            this.Pnl_datos.Controls.Add(this.Txt_director);
            this.Pnl_datos.Controls.Add(this.Dtp_fecha);
            this.Pnl_datos.Controls.Add(this.Lbl_fecha);
            this.Pnl_datos.Location = new System.Drawing.Point(3, 3);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(787, 258);
            this.Pnl_datos.TabIndex = 17;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(408, 201);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(148, 45);
            this.Btn_cancelar.TabIndex = 18;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_aceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_aceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_aceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_aceptar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptar.Location = new System.Drawing.Point(215, 201);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(148, 45);
            this.Btn_aceptar.TabIndex = 17;
            this.Btn_aceptar.Text = "Guardar";
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_titulo.DefaultText = "";
            this.Txt_titulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_titulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_titulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_titulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_titulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_titulo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_titulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_titulo.Location = new System.Drawing.Point(14, 18);
            this.Txt_titulo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_titulo.PlaceholderText = "Título";
            this.Txt_titulo.SelectedText = "";
            this.Txt_titulo.Size = new System.Drawing.Size(172, 38);
            this.Txt_titulo.TabIndex = 2;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_descripcion.DefaultText = "";
            this.Txt_descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_descripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_descripcion.Location = new System.Drawing.Point(215, 18);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_descripcion.PlaceholderText = "Descripción";
            this.Txt_descripcion.SelectedText = "";
            this.Txt_descripcion.Size = new System.Drawing.Size(172, 38);
            this.Txt_descripcion.TabIndex = 3;
            // 
            // Txt_duracion
            // 
            this.Txt_duracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_duracion.DefaultText = "";
            this.Txt_duracion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_duracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_duracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_duracion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_duracion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_duracion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_duracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_duracion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_duracion.Location = new System.Drawing.Point(604, 18);
            this.Txt_duracion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_duracion.Name = "Txt_duracion";
            this.Txt_duracion.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_duracion.PlaceholderText = "Duración";
            this.Txt_duracion.SelectedText = "";
            this.Txt_duracion.Size = new System.Drawing.Size(172, 38);
            this.Txt_duracion.TabIndex = 4;
            // 
            // Txt_genero
            // 
            this.Txt_genero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_genero.DefaultText = "";
            this.Txt_genero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_genero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_genero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_genero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_genero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_genero.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_genero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_genero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_genero.Location = new System.Drawing.Point(408, 18);
            this.Txt_genero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_genero.Name = "Txt_genero";
            this.Txt_genero.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_genero.PlaceholderText = "Genero";
            this.Txt_genero.SelectedText = "";
            this.Txt_genero.Size = new System.Drawing.Size(172, 38);
            this.Txt_genero.TabIndex = 5;
            // 
            // Txt_reparto
            // 
            this.Txt_reparto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_reparto.DefaultText = "";
            this.Txt_reparto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_reparto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_reparto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_reparto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_reparto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_reparto.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_reparto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_reparto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_reparto.Location = new System.Drawing.Point(570, 101);
            this.Txt_reparto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_reparto.Name = "Txt_reparto";
            this.Txt_reparto.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_reparto.PlaceholderText = "Reparto";
            this.Txt_reparto.SelectedText = "";
            this.Txt_reparto.Size = new System.Drawing.Size(172, 38);
            this.Txt_reparto.TabIndex = 6;
            // 
            // Lbl_error
            // 
            this.Lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl_error.Location = new System.Drawing.Point(202, 160);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error.TabIndex = 11;
            this.Lbl_error.Text = ".";
            // 
            // Txt_director
            // 
            this.Txt_director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_director.DefaultText = "";
            this.Txt_director.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_director.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_director.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_director.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_director.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_director.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_director.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_director.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_director.Location = new System.Drawing.Point(368, 101);
            this.Txt_director.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_director.Name = "Txt_director";
            this.Txt_director.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_director.PlaceholderText = "Director";
            this.Txt_director.SelectedText = "";
            this.Txt_director.Size = new System.Drawing.Size(172, 38);
            this.Txt_director.TabIndex = 7;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Checked = true;
            this.Dtp_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_fecha.ForeColor = System.Drawing.Color.Black;
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtp_fecha.Location = new System.Drawing.Point(14, 101);
            this.Dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(325, 38);
            this.Dtp_fecha.TabIndex = 8;
            this.Dtp_fecha.Value = new System.DateTime(2025, 10, 1, 21, 16, 38, 759);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(14, 74);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(137, 25);
            this.Lbl_fecha.TabIndex = 9;
            this.Lbl_fecha.Text = "Fecha de estreno:";
            // 
            // UC_FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Pnl_datos);
            this.Name = "UC_FormPelicula";
            this.Size = new System.Drawing.Size(798, 266);
            this.Pnl_datos.ResumeLayout(false);
            this.Pnl_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_datos;
        private Guna.UI2.WinForms.Guna2Button Btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button Btn_aceptar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_titulo;
        private Guna.UI2.WinForms.Guna2TextBox Txt_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_duracion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_genero;
        private Guna.UI2.WinForms.Guna2TextBox Txt_reparto;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
        private Guna.UI2.WinForms.Guna2TextBox Txt_director;
        private Guna.UI2.WinForms.Guna2DateTimePicker Dtp_fecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_fecha;
    }
}
