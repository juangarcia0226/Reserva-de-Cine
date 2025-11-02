namespace ReservaCine
{
    partial class UC_FormSala
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
            this.Pnl_formSala = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_capacidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_filas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rb_no = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Txt_columnas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rb_si = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Txt_tipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_disponible = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_nombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_capacidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_filas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_columnas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_tipo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_formSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_formSala
            // 
            this.Pnl_formSala.Controls.Add(this.Lbl_tipo);
            this.Pnl_formSala.Controls.Add(this.Lbl_columnas);
            this.Pnl_formSala.Controls.Add(this.Lbl_filas);
            this.Pnl_formSala.Controls.Add(this.Lbl_capacidad);
            this.Pnl_formSala.Controls.Add(this.Lbl_nombre);
            this.Pnl_formSala.Controls.Add(this.Btn_cancelar);
            this.Pnl_formSala.Controls.Add(this.Btn_agregar);
            this.Pnl_formSala.Controls.Add(this.Txt_nombre);
            this.Pnl_formSala.Controls.Add(this.Lbl_error);
            this.Pnl_formSala.Controls.Add(this.Txt_capacidad);
            this.Pnl_formSala.Controls.Add(this.Txt_filas);
            this.Pnl_formSala.Controls.Add(this.Rb_no);
            this.Pnl_formSala.Controls.Add(this.Txt_columnas);
            this.Pnl_formSala.Controls.Add(this.Rb_si);
            this.Pnl_formSala.Controls.Add(this.Txt_tipo);
            this.Pnl_formSala.Controls.Add(this.Lbl_disponible);
            this.Pnl_formSala.Location = new System.Drawing.Point(3, 3);
            this.Pnl_formSala.Name = "Pnl_formSala";
            this.Pnl_formSala.Size = new System.Drawing.Size(637, 322);
            this.Pnl_formSala.TabIndex = 22;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(325, 267);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(180, 45);
            this.Btn_cancelar.TabIndex = 22;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_agregar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_agregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregar.Location = new System.Drawing.Point(107, 267);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(180, 45);
            this.Btn_agregar.TabIndex = 21;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_nombre.DefaultText = "";
            this.Txt_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nombre.Location = new System.Drawing.Point(39, 49);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_nombre.PlaceholderText = "Nombre";
            this.Txt_nombre.SelectedText = "";
            this.Txt_nombre.Size = new System.Drawing.Size(172, 38);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Lbl_error
            // 
            this.Lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.Location = new System.Drawing.Point(85, 206);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error.TabIndex = 20;
            this.Lbl_error.Text = ".";
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_capacidad.DefaultText = "";
            this.Txt_capacidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_capacidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_capacidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_capacidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_capacidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_capacidad.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_capacidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_capacidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_capacidad.Location = new System.Drawing.Point(234, 49);
            this.Txt_capacidad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_capacidad.PlaceholderText = "Capacidad";
            this.Txt_capacidad.SelectedText = "";
            this.Txt_capacidad.Size = new System.Drawing.Size(172, 38);
            this.Txt_capacidad.TabIndex = 4;
            // 
            // Txt_filas
            // 
            this.Txt_filas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_filas.DefaultText = "";
            this.Txt_filas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_filas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_filas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_filas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_filas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_filas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_filas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_filas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_filas.Location = new System.Drawing.Point(428, 49);
            this.Txt_filas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_filas.Name = "Txt_filas";
            this.Txt_filas.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_filas.PlaceholderText = "Filas";
            this.Txt_filas.SelectedText = "";
            this.Txt_filas.Size = new System.Drawing.Size(172, 38);
            this.Txt_filas.TabIndex = 5;
            // 
            // Rb_no
            // 
            this.Rb_no.AutoSize = true;
            this.Rb_no.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_no.CheckedState.BorderThickness = 0;
            this.Rb_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_no.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rb_no.CheckedState.InnerOffset = -4;
            this.Rb_no.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Rb_no.Location = new System.Drawing.Point(512, 174);
            this.Rb_no.Name = "Rb_no";
            this.Rb_no.Size = new System.Drawing.Size(54, 27);
            this.Rb_no.TabIndex = 10;
            this.Rb_no.Text = "No";
            this.Rb_no.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rb_no.UncheckedState.BorderThickness = 2;
            this.Rb_no.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rb_no.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Txt_columnas
            // 
            this.Txt_columnas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_columnas.DefaultText = "";
            this.Txt_columnas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_columnas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_columnas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_columnas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_columnas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_columnas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_columnas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_columnas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_columnas.Location = new System.Drawing.Point(39, 130);
            this.Txt_columnas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_columnas.Name = "Txt_columnas";
            this.Txt_columnas.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_columnas.PlaceholderText = "Columnas";
            this.Txt_columnas.SelectedText = "";
            this.Txt_columnas.Size = new System.Drawing.Size(172, 38);
            this.Txt_columnas.TabIndex = 6;
            // 
            // Rb_si
            // 
            this.Rb_si.AutoSize = true;
            this.Rb_si.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_si.CheckedState.BorderThickness = 0;
            this.Rb_si.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_si.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rb_si.CheckedState.InnerOffset = -4;
            this.Rb_si.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Rb_si.Location = new System.Drawing.Point(512, 141);
            this.Rb_si.Name = "Rb_si";
            this.Rb_si.Size = new System.Drawing.Size(44, 27);
            this.Rb_si.TabIndex = 9;
            this.Rb_si.Text = "Sí";
            this.Rb_si.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rb_si.UncheckedState.BorderThickness = 2;
            this.Rb_si.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rb_si.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Txt_tipo
            // 
            this.Txt_tipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_tipo.DefaultText = "";
            this.Txt_tipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_tipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_tipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_tipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_tipo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_tipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_tipo.Location = new System.Drawing.Point(234, 130);
            this.Txt_tipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_tipo.PlaceholderText = "Tipo";
            this.Txt_tipo.SelectedText = "";
            this.Txt_tipo.Size = new System.Drawing.Size(172, 38);
            this.Txt_tipo.TabIndex = 7;
            // 
            // Lbl_disponible
            // 
            this.Lbl_disponible.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_disponible.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_disponible.Location = new System.Drawing.Point(428, 110);
            this.Lbl_disponible.Name = "Lbl_disponible";
            this.Lbl_disponible.Size = new System.Drawing.Size(87, 25);
            this.Lbl_disponible.TabIndex = 8;
            this.Lbl_disponible.Text = "Disponible:";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(39, 16);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(70, 25);
            this.Lbl_nombre.TabIndex = 23;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Lbl_capacidad
            // 
            this.Lbl_capacidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_capacidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_capacidad.Location = new System.Drawing.Point(234, 16);
            this.Lbl_capacidad.Name = "Lbl_capacidad";
            this.Lbl_capacidad.Size = new System.Drawing.Size(87, 25);
            this.Lbl_capacidad.TabIndex = 24;
            this.Lbl_capacidad.Text = "Capacidad:";
            // 
            // Lbl_filas
            // 
            this.Lbl_filas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_filas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_filas.Location = new System.Drawing.Point(428, 16);
            this.Lbl_filas.Name = "Lbl_filas";
            this.Lbl_filas.Size = new System.Drawing.Size(39, 25);
            this.Lbl_filas.TabIndex = 25;
            this.Lbl_filas.Text = "Filas:";
            // 
            // Lbl_columnas
            // 
            this.Lbl_columnas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_columnas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_columnas.Location = new System.Drawing.Point(39, 97);
            this.Lbl_columnas.Name = "Lbl_columnas";
            this.Lbl_columnas.Size = new System.Drawing.Size(83, 25);
            this.Lbl_columnas.TabIndex = 26;
            this.Lbl_columnas.Text = "Columnas:";
            // 
            // Lbl_tipo
            // 
            this.Lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_tipo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipo.Location = new System.Drawing.Point(238, 97);
            this.Lbl_tipo.Name = "Lbl_tipo";
            this.Lbl_tipo.Size = new System.Drawing.Size(40, 25);
            this.Lbl_tipo.TabIndex = 27;
            this.Lbl_tipo.Text = "Tipo:";
            // 
            // UC_FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_formSala);
            this.Name = "UC_FormSala";
            this.Size = new System.Drawing.Size(643, 328);
            this.Pnl_formSala.ResumeLayout(false);
            this.Pnl_formSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_formSala;
        private Guna.UI2.WinForms.Guna2Button Btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button Btn_agregar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_nombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
        private Guna.UI2.WinForms.Guna2TextBox Txt_capacidad;
        private Guna.UI2.WinForms.Guna2TextBox Txt_filas;
        private Guna.UI2.WinForms.Guna2RadioButton Rb_no;
        private Guna.UI2.WinForms.Guna2TextBox Txt_columnas;
        private Guna.UI2.WinForms.Guna2RadioButton Rb_si;
        private Guna.UI2.WinForms.Guna2TextBox Txt_tipo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_disponible;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_tipo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_columnas;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_filas;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_capacidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_nombre;
    }
}
