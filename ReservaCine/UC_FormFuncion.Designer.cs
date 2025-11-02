namespace ReservaCine
{
    partial class UC_FormFuncion
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
            this.Pnl_formFuncion = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cbx_pelicula = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cbx_sala = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Txt_hora = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_pelicula = new System.Windows.Forms.Label();
            this.Lbl_sala = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_formFuncion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_formFuncion
            // 
            this.Pnl_formFuncion.Controls.Add(this.Lbl_error);
            this.Pnl_formFuncion.Controls.Add(this.Btn_cancelar);
            this.Pnl_formFuncion.Controls.Add(this.Btn_agregar);
            this.Pnl_formFuncion.Controls.Add(this.Lbl_hora);
            this.Pnl_formFuncion.Controls.Add(this.Lbl_fecha);
            this.Pnl_formFuncion.Controls.Add(this.Lbl_sala);
            this.Pnl_formFuncion.Controls.Add(this.Lbl_pelicula);
            this.Pnl_formFuncion.Controls.Add(this.Lbl_descripcion);
            this.Pnl_formFuncion.Controls.Add(this.Txt_hora);
            this.Pnl_formFuncion.Controls.Add(this.Dtp_fecha);
            this.Pnl_formFuncion.Controls.Add(this.Cbx_sala);
            this.Pnl_formFuncion.Controls.Add(this.Cbx_pelicula);
            this.Pnl_formFuncion.Controls.Add(this.Txt_descripcion);
            this.Pnl_formFuncion.Location = new System.Drawing.Point(4, 4);
            this.Pnl_formFuncion.Name = "Pnl_formFuncion";
            this.Pnl_formFuncion.Size = new System.Drawing.Size(647, 310);
            this.Pnl_formFuncion.TabIndex = 0;
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
            this.Txt_descripcion.ForeColor = System.Drawing.Color.Black;
            this.Txt_descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_descripcion.Location = new System.Drawing.Point(28, 47);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_descripcion.PlaceholderText = "Descripción";
            this.Txt_descripcion.SelectedText = "";
            this.Txt_descripcion.Size = new System.Drawing.Size(172, 38);
            this.Txt_descripcion.TabIndex = 0;
            // 
            // Cbx_pelicula
            // 
            this.Cbx_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.Cbx_pelicula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbx_pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_pelicula.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbx_pelicula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbx_pelicula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbx_pelicula.ForeColor = System.Drawing.Color.Black;
            this.Cbx_pelicula.ItemHeight = 30;
            this.Cbx_pelicula.Location = new System.Drawing.Point(241, 47);
            this.Cbx_pelicula.Name = "Cbx_pelicula";
            this.Cbx_pelicula.Size = new System.Drawing.Size(170, 36);
            this.Cbx_pelicula.TabIndex = 1;
            // 
            // Cbx_sala
            // 
            this.Cbx_sala.BackColor = System.Drawing.Color.Transparent;
            this.Cbx_sala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbx_sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_sala.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbx_sala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbx_sala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbx_sala.ForeColor = System.Drawing.Color.Black;
            this.Cbx_sala.ItemHeight = 30;
            this.Cbx_sala.Location = new System.Drawing.Point(452, 47);
            this.Cbx_sala.Name = "Cbx_sala";
            this.Cbx_sala.Size = new System.Drawing.Size(170, 36);
            this.Cbx_sala.TabIndex = 2;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Checked = true;
            this.Dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha.Location = new System.Drawing.Point(28, 137);
            this.Dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(172, 36);
            this.Dtp_fecha.TabIndex = 3;
            this.Dtp_fecha.Value = new System.DateTime(2025, 11, 1, 23, 56, 53, 0);
            // 
            // Txt_hora
            // 
            this.Txt_hora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_hora.DefaultText = "";
            this.Txt_hora.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_hora.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_hora.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_hora.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_hora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_hora.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_hora.ForeColor = System.Drawing.Color.Black;
            this.Txt_hora.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_hora.Location = new System.Drawing.Point(241, 137);
            this.Txt_hora.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_hora.Name = "Txt_hora";
            this.Txt_hora.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_hora.PlaceholderText = "Hora";
            this.Txt_hora.SelectedText = "";
            this.Txt_hora.Size = new System.Drawing.Size(172, 38);
            this.Txt_hora.TabIndex = 4;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(24, 19);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(102, 23);
            this.Lbl_descripcion.TabIndex = 5;
            this.Lbl_descripcion.Text = "Descripción:";
            // 
            // Lbl_pelicula
            // 
            this.Lbl_pelicula.AutoSize = true;
            this.Lbl_pelicula.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pelicula.Location = new System.Drawing.Point(237, 19);
            this.Lbl_pelicula.Name = "Lbl_pelicula";
            this.Lbl_pelicula.Size = new System.Drawing.Size(71, 23);
            this.Lbl_pelicula.TabIndex = 6;
            this.Lbl_pelicula.Text = "Película:";
            // 
            // Lbl_sala
            // 
            this.Lbl_sala.AutoSize = true;
            this.Lbl_sala.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sala.Location = new System.Drawing.Point(448, 19);
            this.Lbl_sala.Name = "Lbl_sala";
            this.Lbl_sala.Size = new System.Drawing.Size(45, 23);
            this.Lbl_sala.TabIndex = 7;
            this.Lbl_sala.Text = "Sala:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(24, 111);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(58, 23);
            this.Lbl_fecha.TabIndex = 8;
            this.Lbl_fecha.Text = "Fecha:";
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(237, 111);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(51, 23);
            this.Lbl_hora.TabIndex = 9;
            this.Lbl_hora.Text = "Hora:";
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
            this.Btn_cancelar.Location = new System.Drawing.Point(332, 249);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(180, 45);
            this.Btn_cancelar.TabIndex = 24;
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
            this.Btn_agregar.Location = new System.Drawing.Point(114, 249);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(180, 45);
            this.Btn_agregar.TabIndex = 23;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Lbl_error
            // 
            this.Lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.Location = new System.Drawing.Point(165, 198);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error.TabIndex = 25;
            this.Lbl_error.Text = ".";
            // 
            // UC_FormFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_formFuncion);
            this.Name = "UC_FormFuncion";
            this.Size = new System.Drawing.Size(654, 317);
            this.Pnl_formFuncion.ResumeLayout(false);
            this.Pnl_formFuncion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_formFuncion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_descripcion;
        private Guna.UI2.WinForms.Guna2DateTimePicker Dtp_fecha;
        private Guna.UI2.WinForms.Guna2ComboBox Cbx_sala;
        private Guna.UI2.WinForms.Guna2ComboBox Cbx_pelicula;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_sala;
        private System.Windows.Forms.Label Lbl_pelicula;
        private System.Windows.Forms.Label Lbl_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_hora;
        private Guna.UI2.WinForms.Guna2Button Btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button Btn_agregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
    }
}
