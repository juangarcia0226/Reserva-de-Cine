namespace ReservaCine
{
    partial class AdminSala
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
            this.Pnl_sala = new Guna.UI2.WinForms.Guna2Panel();
            this.Flp_salas = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_sala = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Rb_no = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Rb_si = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_tipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_columnas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_filas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_capacidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Tmr_sala = new System.Windows.Forms.Timer(this.components);
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_sala.SuspendLayout();
            this.Pnl_menu_left.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_sala
            // 
            this.Pnl_sala.Controls.Add(this.Flp_salas);
            this.Pnl_sala.Controls.Add(this.Btn_guardar);
            this.Pnl_sala.Controls.Add(this.Lbl_sala);
            this.Pnl_sala.Location = new System.Drawing.Point(185, 7);
            this.Pnl_sala.Name = "Pnl_sala";
            this.Pnl_sala.Size = new System.Drawing.Size(924, 639);
            this.Pnl_sala.TabIndex = 3;
            // 
            // Flp_salas
            // 
            this.Flp_salas.AutoScroll = true;
            this.Flp_salas.Location = new System.Drawing.Point(22, 119);
            this.Flp_salas.Name = "Flp_salas";
            this.Flp_salas.Size = new System.Drawing.Size(902, 323);
            this.Flp_salas.TabIndex = 16;
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
            this.Btn_guardar.Location = new System.Drawing.Point(71, 491);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(178, 56);
            this.Btn_guardar.TabIndex = 15;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_sala
            // 
            this.Lbl_sala.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_sala.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sala.Location = new System.Drawing.Point(3, 5);
            this.Lbl_sala.Name = "Lbl_sala";
            this.Lbl_sala.Size = new System.Drawing.Size(108, 52);
            this.Lbl_sala.TabIndex = 0;
            this.Lbl_sala.Text = "SALAS";
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
            // Rb_no
            // 
            this.Rb_no.AutoSize = true;
            this.Rb_no.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_no.CheckedState.BorderThickness = 0;
            this.Rb_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_no.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rb_no.CheckedState.InnerOffset = -4;
            this.Rb_no.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Rb_no.Location = new System.Drawing.Point(512, 162);
            this.Rb_no.Name = "Rb_no";
            this.Rb_no.Size = new System.Drawing.Size(54, 27);
            this.Rb_no.TabIndex = 10;
            this.Rb_no.Text = "No";
            this.Rb_no.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rb_no.UncheckedState.BorderThickness = 2;
            this.Rb_no.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rb_no.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Rb_si
            // 
            this.Rb_si.AutoSize = true;
            this.Rb_si.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_si.CheckedState.BorderThickness = 0;
            this.Rb_si.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rb_si.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rb_si.CheckedState.InnerOffset = -4;
            this.Rb_si.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_si.Location = new System.Drawing.Point(512, 129);
            this.Rb_si.Name = "Rb_si";
            this.Rb_si.Size = new System.Drawing.Size(44, 27);
            this.Rb_si.TabIndex = 9;
            this.Rb_si.Text = "Sí";
            this.Rb_si.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rb_si.UncheckedState.BorderThickness = 2;
            this.Rb_si.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rb_si.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(428, 99);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 25);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Disponible:";
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
            this.Txt_tipo.Location = new System.Drawing.Point(234, 119);
            this.Txt_tipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_tipo.PlaceholderText = "Tipo";
            this.Txt_tipo.SelectedText = "";
            this.Txt_tipo.Size = new System.Drawing.Size(172, 38);
            this.Txt_tipo.TabIndex = 7;
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
            this.Txt_columnas.Location = new System.Drawing.Point(39, 119);
            this.Txt_columnas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_columnas.Name = "Txt_columnas";
            this.Txt_columnas.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_columnas.PlaceholderText = "Columnas";
            this.Txt_columnas.SelectedText = "";
            this.Txt_columnas.Size = new System.Drawing.Size(172, 38);
            this.Txt_columnas.TabIndex = 6;
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
            this.Txt_filas.Location = new System.Drawing.Point(428, 20);
            this.Txt_filas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_filas.Name = "Txt_filas";
            this.Txt_filas.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_filas.PlaceholderText = "Filas";
            this.Txt_filas.SelectedText = "";
            this.Txt_filas.Size = new System.Drawing.Size(172, 38);
            this.Txt_filas.TabIndex = 5;
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
            this.Txt_capacidad.Location = new System.Drawing.Point(234, 20);
            this.Txt_capacidad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_capacidad.PlaceholderText = "Capacidad";
            this.Txt_capacidad.SelectedText = "";
            this.Txt_capacidad.Size = new System.Drawing.Size(172, 38);
            this.Txt_capacidad.TabIndex = 4;
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
            this.Txt_nombre.Location = new System.Drawing.Point(39, 20);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_nombre.PlaceholderText = "Nombre";
            this.Txt_nombre.SelectedText = "";
            this.Txt_nombre.Size = new System.Drawing.Size(172, 38);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Btn_salas);
            this.Pnl_menu_left.Controls.Add(this.Btn_peliculas);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(-1, 0);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(177, 668);
            this.Pnl_menu_left.TabIndex = 21;
            // 
            // Btn_salas
            // 
            this.Btn_salas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_salas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_salas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_salas.ForeColor = System.Drawing.Color.White;
            this.Btn_salas.Location = new System.Drawing.Point(0, 278);
            this.Btn_salas.Name = "Btn_salas";
            this.Btn_salas.Size = new System.Drawing.Size(180, 45);
            this.Btn_salas.TabIndex = 2;
            this.Btn_salas.Text = "Salas";
            // 
            // Btn_peliculas
            // 
            this.Btn_peliculas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_peliculas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_peliculas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_peliculas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_peliculas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_peliculas.ForeColor = System.Drawing.Color.White;
            this.Btn_peliculas.Location = new System.Drawing.Point(0, 218);
            this.Btn_peliculas.Name = "Btn_peliculas";
            this.Btn_peliculas.Size = new System.Drawing.Size(180, 45);
            this.Btn_peliculas.TabIndex = 1;
            this.Btn_peliculas.Text = "Películas";
            this.Btn_peliculas.Click += new System.EventHandler(this.Btn_peliculas_Click);
            // 
            // Btn_menu
            // 
            this.Btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_menu.FillColor = System.Drawing.Color.Cyan;
            this.Btn_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_menu.ForeColor = System.Drawing.Color.Black;
            this.Btn_menu.Location = new System.Drawing.Point(0, 38);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.Size = new System.Drawing.Size(180, 45);
            this.Btn_menu.TabIndex = 0;
            this.Btn_menu.Text = "CineX";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.Txt_nombre);
            this.guna2Panel1.Controls.Add(this.Lbl_error);
            this.guna2Panel1.Controls.Add(this.Txt_capacidad);
            this.guna2Panel1.Controls.Add(this.Txt_filas);
            this.guna2Panel1.Controls.Add(this.Rb_no);
            this.guna2Panel1.Controls.Add(this.Txt_columnas);
            this.guna2Panel1.Controls.Add(this.Rb_si);
            this.guna2Panel1.Controls.Add(this.Txt_tipo);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(1129, 187);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(676, 347);
            this.guna2Panel1.TabIndex = 21;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(376, 274);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 22;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(134, 274);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // AdminSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 684);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Pnl_menu_left);
            this.Controls.Add(this.Pnl_sala);
            this.Name = "AdminSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSala";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSala_FormClosing);
            this.Pnl_sala.ResumeLayout(false);
            this.Pnl_sala.PerformLayout();
            this.Pnl_menu_left.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Pnl_sala;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_sala;
        private Guna.UI2.WinForms.Guna2TextBox Txt_capacidad;
        private Guna.UI2.WinForms.Guna2TextBox Txt_nombre;
        private Guna.UI2.WinForms.Guna2TextBox Txt_filas;
        private Guna.UI2.WinForms.Guna2TextBox Txt_tipo;
        private Guna.UI2.WinForms.Guna2TextBox Txt_columnas;
        private Guna.UI2.WinForms.Guna2RadioButton Rb_no;
        private Guna.UI2.WinForms.Guna2RadioButton Rb_si;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
        private System.Windows.Forms.Timer Tmr_sala;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel Flp_salas;
    }
}