namespace ReservaCine
{
    partial class AdminUsuario
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
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_usuario = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Flp_usuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_usuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_formUsuarios = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_menu_left.SuspendLayout();
            this.Pnl_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Btn_usuarios);
            this.Pnl_menu_left.Controls.Add(this.Btn_salas);
            this.Pnl_menu_left.Controls.Add(this.Btn_peliculas);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(-4, 0);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(183, 672);
            this.Pnl_menu_left.TabIndex = 22;
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
            this.Btn_salas.Click += new System.EventHandler(this.Btn_salas_Click);
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
            // Pnl_usuario
            // 
            this.Pnl_usuario.Controls.Add(this.Txt_buscar);
            this.Pnl_usuario.Controls.Add(this.Flp_usuarios);
            this.Pnl_usuario.Controls.Add(this.Btn_guardar);
            this.Pnl_usuario.Controls.Add(this.Lbl_usuario);
            this.Pnl_usuario.Controls.Add(this.Pnl_formUsuarios);
            this.Pnl_usuario.Location = new System.Drawing.Point(186, 12);
            this.Pnl_usuario.Name = "Pnl_usuario";
            this.Pnl_usuario.Size = new System.Drawing.Size(944, 639);
            this.Pnl_usuario.TabIndex = 23;
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
            this.Txt_buscar.PlaceholderText = "Ingrese el correo de un usuario";
            this.Txt_buscar.SelectedText = "";
            this.Txt_buscar.Size = new System.Drawing.Size(506, 55);
            this.Txt_buscar.TabIndex = 22;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // Flp_usuarios
            // 
            this.Flp_usuarios.AutoScroll = true;
            this.Flp_usuarios.Location = new System.Drawing.Point(20, 155);
            this.Flp_usuarios.Name = "Flp_usuarios";
            this.Flp_usuarios.Size = new System.Drawing.Size(902, 375);
            this.Flp_usuarios.TabIndex = 16;
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
            // Lbl_usuario
            // 
            this.Lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(3, 5);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(177, 52);
            this.Lbl_usuario.TabIndex = 0;
            this.Lbl_usuario.Text = "USUARIOS";
            // 
            // Pnl_formUsuarios
            // 
            this.Pnl_formUsuarios.Location = new System.Drawing.Point(3, 168);
            this.Pnl_formUsuarios.Name = "Pnl_formUsuarios";
            this.Pnl_formUsuarios.Size = new System.Drawing.Size(776, 323);
            this.Pnl_formUsuarios.TabIndex = 21;
            this.Pnl_formUsuarios.Visible = false;
            // 
            // Btn_usuarios
            // 
            this.Btn_usuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_usuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_usuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_usuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_usuarios.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.Btn_usuarios.Location = new System.Drawing.Point(3, 446);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(180, 45);
            this.Btn_usuarios.TabIndex = 24;
            this.Btn_usuarios.Text = "Usuarios";
            // 
            // AdminUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 667);
            this.Controls.Add(this.Pnl_usuario);
            this.Controls.Add(this.Pnl_menu_left);
            this.Name = "AdminUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUsuario_FormClosing);
            this.Load += new System.EventHandler(this.AdminUsuario_Load);
            this.Pnl_menu_left.ResumeLayout(false);
            this.Pnl_usuario.ResumeLayout(false);
            this.Pnl_usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private Guna.UI2.WinForms.Guna2Panel Pnl_usuario;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar;
        private System.Windows.Forms.FlowLayoutPanel Flp_usuarios;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_usuario;
        private Guna.UI2.WinForms.Guna2Panel Pnl_formUsuarios;
        private Guna.UI2.WinForms.Guna2Button Btn_usuarios;
    }
}