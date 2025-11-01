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
            this.Txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Flp_salas = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_sala = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_formSala = new Guna.UI2.WinForms.Guna2Panel();
            this.Tmr_sala = new System.Windows.Forms.Timer(this.components);
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_funciones = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_sala.SuspendLayout();
            this.Pnl_menu_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_sala
            // 
            this.Pnl_sala.Controls.Add(this.Txt_buscar);
            this.Pnl_sala.Controls.Add(this.Flp_salas);
            this.Pnl_sala.Controls.Add(this.Btn_guardar);
            this.Pnl_sala.Controls.Add(this.Lbl_sala);
            this.Pnl_sala.Controls.Add(this.Pnl_formSala);
            this.Pnl_sala.Location = new System.Drawing.Point(185, 7);
            this.Pnl_sala.Name = "Pnl_sala";
            this.Pnl_sala.Size = new System.Drawing.Size(924, 639);
            this.Pnl_sala.TabIndex = 3;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.BorderRadius = 22;
            this.Txt_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_buscar.DefaultText = "";
            this.Txt_buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_buscar.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar.Location = new System.Drawing.Point(204, 60);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_buscar.PlaceholderText = "Ingrese el nombre de una sala";
            this.Txt_buscar.SelectedText = "";
            this.Txt_buscar.Size = new System.Drawing.Size(506, 55);
            this.Txt_buscar.TabIndex = 22;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // Flp_salas
            // 
            this.Flp_salas.AutoScroll = true;
            this.Flp_salas.Location = new System.Drawing.Point(22, 123);
            this.Flp_salas.Name = "Flp_salas";
            this.Flp_salas.Size = new System.Drawing.Size(902, 375);
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
            this.Btn_guardar.Location = new System.Drawing.Point(90, 545);
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
            // Pnl_formSala
            // 
            this.Pnl_formSala.Location = new System.Drawing.Point(3, 172);
            this.Pnl_formSala.Name = "Pnl_formSala";
            this.Pnl_formSala.Size = new System.Drawing.Size(644, 329);
            this.Pnl_formSala.TabIndex = 21;
            this.Pnl_formSala.Visible = false;
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Btn_usuarios);
            this.Pnl_menu_left.Controls.Add(this.Btn_funciones);
            this.Pnl_menu_left.Controls.Add(this.Btn_salas);
            this.Pnl_menu_left.Controls.Add(this.Btn_peliculas);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(-1, 0);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(179, 668);
            this.Pnl_menu_left.TabIndex = 21;
            // 
            // Btn_salas
            // 
            this.Btn_salas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_salas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_salas.FillColor = System.Drawing.Color.DeepSkyBlue;
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
            this.Btn_peliculas.FillColor = System.Drawing.Color.DeepSkyBlue;
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
            // Btn_usuarios
            // Btn_funciones
            // 
            this.Btn_usuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_usuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_usuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_usuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_usuarios.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.Btn_usuarios.Location = new System.Drawing.Point(0, 408);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(180, 45);
            this.Btn_usuarios.TabIndex = 23;
            this.Btn_usuarios.Text = "Usuarios";
            this.Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            this.Btn_funciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_funciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_funciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_funciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_funciones.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_funciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_funciones.ForeColor = System.Drawing.Color.White;
            this.Btn_funciones.Location = new System.Drawing.Point(0, 340);
            this.Btn_funciones.Name = "Btn_funciones";
            this.Btn_funciones.Size = new System.Drawing.Size(180, 45);
            this.Btn_funciones.TabIndex = 4;
            this.Btn_funciones.Text = "Funciones";
            this.Btn_funciones.Click += new System.EventHandler(this.Btn_funciones_Click);
            // 
            // AdminSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 667);
            this.Controls.Add(this.Pnl_menu_left);
            this.Controls.Add(this.Pnl_sala);
            this.Name = "AdminSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSala";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSala_FormClosing);
            this.Load += new System.EventHandler(this.AdminSala_Load);
            this.Pnl_sala.ResumeLayout(false);
            this.Pnl_sala.PerformLayout();
            this.Pnl_menu_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Pnl_sala;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_sala;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private System.Windows.Forms.Timer Tmr_sala;
        private Guna.UI2.WinForms.Guna2Panel Pnl_formSala;
        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private System.Windows.Forms.FlowLayoutPanel Flp_salas;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar;
        private Guna.UI2.WinForms.Guna2Button Btn_usuarios;
        private Guna.UI2.WinForms.Guna2Button Btn_funciones;
    }
}