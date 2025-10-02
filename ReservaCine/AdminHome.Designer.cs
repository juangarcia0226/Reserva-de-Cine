namespace ReservaCine
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.Pnl_AdminHome = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_actualizar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_fecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Txt_reparto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_director = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_genero = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_duracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_titulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_peliculas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dgv_pelis = new System.Windows.Forms.DataGridView();
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_btnSalas = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_sala = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Pnl_btnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_salir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Tmr_menu = new System.Windows.Forms.Timer(this.components);
            this.Lbl_btnSala = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_pelicula = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_pelicula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_pelicula = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Pnl_AdminHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pelis)).BeginInit();
            this.Pnl_menu_left.SuspendLayout();
            this.Pnl_btnSalas.SuspendLayout();
            this.Pnl_btnMenu.SuspendLayout();
            this.Pnl_pelicula.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_AdminHome
            // 
            this.Pnl_AdminHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_AdminHome.Controls.Add(this.Btn_eliminar);
            this.Pnl_AdminHome.Controls.Add(this.Btn_actualizar);
            this.Pnl_AdminHome.Controls.Add(this.Btn_buscar);
            this.Pnl_AdminHome.Controls.Add(this.Lbl_error);
            this.Pnl_AdminHome.Controls.Add(this.Btn_guardar);
            this.Pnl_AdminHome.Controls.Add(this.Lbl_fecha);
            this.Pnl_AdminHome.Controls.Add(this.Dtp_fecha);
            this.Pnl_AdminHome.Controls.Add(this.Txt_reparto);
            this.Pnl_AdminHome.Controls.Add(this.Txt_director);
            this.Pnl_AdminHome.Controls.Add(this.Txt_genero);
            this.Pnl_AdminHome.Controls.Add(this.Txt_duracion);
            this.Pnl_AdminHome.Controls.Add(this.Txt_descripcion);
            this.Pnl_AdminHome.Controls.Add(this.Txt_titulo);
            this.Pnl_AdminHome.Controls.Add(this.Lbl_peliculas);
            this.Pnl_AdminHome.Controls.Add(this.Dgv_pelis);
            this.Pnl_AdminHome.Location = new System.Drawing.Point(73, 13);
            this.Pnl_AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_AdminHome.Name = "Pnl_AdminHome";
            this.Pnl_AdminHome.Size = new System.Drawing.Size(1245, 596);
            this.Pnl_AdminHome.TabIndex = 0;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_eliminar.FillColor = System.Drawing.Color.Firebrick;
            this.Btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(792, 270);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(152, 35);
            this.Btn_eliminar.TabIndex = 14;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_actualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_actualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_actualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_actualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(140)))));
            this.Btn_actualizar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_actualizar.Location = new System.Drawing.Point(610, 270);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(152, 35);
            this.Btn_actualizar.TabIndex = 13;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_buscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(428, 270);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(152, 35);
            this.Btn_buscar.TabIndex = 12;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Lbl_error
            // 
            this.Lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl_error.Location = new System.Drawing.Point(404, 222);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error.TabIndex = 11;
            this.Lbl_error.Text = ".";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_guardar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_guardar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.Btn_guardar.Location = new System.Drawing.Point(252, 270);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(152, 35);
            this.Btn_guardar.TabIndex = 10;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(216, 136);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(137, 25);
            this.Lbl_fecha.TabIndex = 9;
            this.Lbl_fecha.Text = "Fecha de estreno:";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Checked = true;
            this.Dtp_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtp_fecha.Location = new System.Drawing.Point(216, 163);
            this.Dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(325, 38);
            this.Dtp_fecha.TabIndex = 8;
            this.Dtp_fecha.Value = new System.DateTime(2025, 10, 1, 21, 16, 38, 759);
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
            this.Txt_reparto.Location = new System.Drawing.Point(570, 163);
            this.Txt_reparto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_reparto.Name = "Txt_reparto";
            this.Txt_reparto.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_reparto.PlaceholderText = "Director";
            this.Txt_reparto.SelectedText = "";
            this.Txt_reparto.Size = new System.Drawing.Size(172, 38);
            this.Txt_reparto.TabIndex = 7;
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
            this.Txt_director.Location = new System.Drawing.Point(772, 163);
            this.Txt_director.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_director.Name = "Txt_director";
            this.Txt_director.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_director.PlaceholderText = "Reparto";
            this.Txt_director.SelectedText = "";
            this.Txt_director.Size = new System.Drawing.Size(172, 38);
            this.Txt_director.TabIndex = 6;
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
            this.Txt_genero.Location = new System.Drawing.Point(610, 80);
            this.Txt_genero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_genero.Name = "Txt_genero";
            this.Txt_genero.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_genero.PlaceholderText = "Genero";
            this.Txt_genero.SelectedText = "";
            this.Txt_genero.Size = new System.Drawing.Size(172, 38);
            this.Txt_genero.TabIndex = 5;
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
            this.Txt_duracion.Location = new System.Drawing.Point(806, 80);
            this.Txt_duracion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_duracion.Name = "Txt_duracion";
            this.Txt_duracion.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_duracion.PlaceholderText = "Duración";
            this.Txt_duracion.SelectedText = "";
            this.Txt_duracion.Size = new System.Drawing.Size(172, 38);
            this.Txt_duracion.TabIndex = 4;
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
            this.Txt_descripcion.Location = new System.Drawing.Point(417, 80);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_descripcion.PlaceholderText = "Descripción";
            this.Txt_descripcion.SelectedText = "";
            this.Txt_descripcion.Size = new System.Drawing.Size(172, 38);
            this.Txt_descripcion.TabIndex = 3;
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
            this.Txt_titulo.Location = new System.Drawing.Point(216, 80);
            this.Txt_titulo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_titulo.PlaceholderText = "Título";
            this.Txt_titulo.SelectedText = "";
            this.Txt_titulo.Size = new System.Drawing.Size(172, 38);
            this.Txt_titulo.TabIndex = 2;
            // 
            // Lbl_peliculas
            // 
            this.Lbl_peliculas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_peliculas.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculas.Location = new System.Drawing.Point(493, 17);
            this.Lbl_peliculas.Name = "Lbl_peliculas";
            this.Lbl_peliculas.Size = new System.Drawing.Size(179, 52);
            this.Lbl_peliculas.TabIndex = 1;
            this.Lbl_peliculas.Text = "PELÍCULAS";
            // 
            // Dgv_pelis
            // 
            this.Dgv_pelis.AllowUserToAddRows = false;
            this.Dgv_pelis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_pelis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_pelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_pelis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_pelis.Location = new System.Drawing.Point(122, 357);
            this.Dgv_pelis.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_pelis.Name = "Dgv_pelis";
            this.Dgv_pelis.ReadOnly = true;
            this.Dgv_pelis.RowHeadersWidth = 51;
            this.Dgv_pelis.Size = new System.Drawing.Size(1119, 206);
            this.Dgv_pelis.TabIndex = 0;
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Pnl_pelicula);
            this.Pnl_menu_left.Controls.Add(this.Pnl_btnSalas);
            this.Pnl_menu_left.Controls.Add(this.Pnl_btnMenu);
            this.Pnl_menu_left.Controls.Add(this.Btn_salir);
            this.Pnl_menu_left.Location = new System.Drawing.Point(0, 13);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(212, 609);
            this.Pnl_menu_left.TabIndex = 1;
            // 
            // Pnl_btnSalas
            // 
            this.Pnl_btnSalas.Controls.Add(this.Lbl_btnSala);
            this.Pnl_btnSalas.Controls.Add(this.Btn_sala);
            this.Pnl_btnSalas.Location = new System.Drawing.Point(3, 325);
            this.Pnl_btnSalas.Name = "Pnl_btnSalas";
            this.Pnl_btnSalas.Size = new System.Drawing.Size(206, 79);
            this.Pnl_btnSalas.TabIndex = 3;
            // 
            // Btn_sala
            // 
            this.Btn_sala.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_sala.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_sala.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sala.Image")));
            this.Btn_sala.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_sala.ImageRotate = 0F;
            this.Btn_sala.Location = new System.Drawing.Point(10, 10);
            this.Btn_sala.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sala.Name = "Btn_sala";
            this.Btn_sala.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_sala.Size = new System.Drawing.Size(83, 65);
            this.Btn_sala.TabIndex = 1;
            this.Btn_sala.Click += new System.EventHandler(this.Btn_sala_Click);
            // 
            // Pnl_btnMenu
            // 
            this.Pnl_btnMenu.Controls.Add(this.Btn_menu);
            this.Pnl_btnMenu.Location = new System.Drawing.Point(3, 17);
            this.Pnl_btnMenu.Name = "Pnl_btnMenu";
            this.Pnl_btnMenu.Size = new System.Drawing.Size(206, 79);
            this.Pnl_btnMenu.TabIndex = 2;
            // 
            // Btn_menu
            // 
            this.Btn_menu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_menu.Image")));
            this.Btn_menu.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_menu.ImageRotate = 0F;
            this.Btn_menu.Location = new System.Drawing.Point(3, 4);
            this.Btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.Size = new System.Drawing.Size(83, 65);
            this.Btn_menu.TabIndex = 0;
            this.Btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_salir.ImageRotate = 0F;
            this.Btn_salir.Location = new System.Drawing.Point(4, 497);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.Size = new System.Drawing.Size(85, 66);
            this.Btn_salir.TabIndex = 1;
            // 
            // Tmr_menu
            // 
            this.Tmr_menu.Interval = 10;
            this.Tmr_menu.Tick += new System.EventHandler(this.Tmr_menu_Tick);
            // 
            // Lbl_btnSala
            // 
            this.Lbl_btnSala.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_btnSala.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_btnSala.Location = new System.Drawing.Point(100, 26);
            this.Lbl_btnSala.Name = "Lbl_btnSala";
            this.Lbl_btnSala.Size = new System.Drawing.Size(55, 33);
            this.Lbl_btnSala.TabIndex = 2;
            this.Lbl_btnSala.Text = "Salas";
            // 
            // Pnl_pelicula
            // 
            this.Pnl_pelicula.Controls.Add(this.Lbl_pelicula);
            this.Pnl_pelicula.Controls.Add(this.Btn_pelicula);
            this.Pnl_pelicula.Location = new System.Drawing.Point(3, 240);
            this.Pnl_pelicula.Name = "Pnl_pelicula";
            this.Pnl_pelicula.Size = new System.Drawing.Size(206, 79);
            this.Pnl_pelicula.TabIndex = 5;
            // 
            // Lbl_pelicula
            // 
            this.Lbl_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_pelicula.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pelicula.Location = new System.Drawing.Point(100, 26);
            this.Lbl_pelicula.Name = "Lbl_pelicula";
            this.Lbl_pelicula.Size = new System.Drawing.Size(92, 33);
            this.Lbl_pelicula.TabIndex = 2;
            this.Lbl_pelicula.Text = "Películas";
            // 
            // Btn_pelicula
            // 
            this.Btn_pelicula.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_pelicula.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_pelicula.Image = ((System.Drawing.Image)(resources.GetObject("Btn_pelicula.Image")));
            this.Btn_pelicula.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_pelicula.ImageRotate = 0F;
            this.Btn_pelicula.Location = new System.Drawing.Point(7, 10);
            this.Btn_pelicula.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_pelicula.Name = "Btn_pelicula";
            this.Btn_pelicula.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_pelicula.Size = new System.Drawing.Size(83, 65);
            this.Btn_pelicula.TabIndex = 1;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1352, 621);
            this.Controls.Add(this.Pnl_menu_left);
            this.Controls.Add(this.Pnl_AdminHome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.Pnl_AdminHome.ResumeLayout(false);
            this.Pnl_AdminHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pelis)).EndInit();
            this.Pnl_menu_left.ResumeLayout(false);
            this.Pnl_btnSalas.ResumeLayout(false);
            this.Pnl_btnSalas.PerformLayout();
            this.Pnl_btnMenu.ResumeLayout(false);
            this.Pnl_pelicula.ResumeLayout(false);
            this.Pnl_pelicula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_AdminHome;
        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_menu;
        private System.Windows.Forms.Timer Tmr_menu;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_salir;
        private System.Windows.Forms.DataGridView Dgv_pelis;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_peliculas;
        private Guna.UI2.WinForms.Guna2DateTimePicker Dtp_fecha;
        private Guna.UI2.WinForms.Guna2TextBox Txt_reparto;
        private Guna.UI2.WinForms.Guna2TextBox Txt_director;
        private Guna.UI2.WinForms.Guna2TextBox Txt_genero;
        private Guna.UI2.WinForms.Guna2TextBox Txt_duracion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox Txt_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_fecha;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
        private Guna.UI2.WinForms.Guna2Button Btn_buscar;
        private Guna.UI2.WinForms.Guna2Button Btn_actualizar;
        private Guna.UI2.WinForms.Guna2Button Btn_eliminar;
        private Guna.UI2.WinForms.Guna2Panel Pnl_btnMenu;
        private Guna.UI2.WinForms.Guna2Panel Pnl_btnSalas;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_sala;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_btnSala;
        private Guna.UI2.WinForms.Guna2Panel Pnl_pelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_pelicula;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_pelicula;
    }
}