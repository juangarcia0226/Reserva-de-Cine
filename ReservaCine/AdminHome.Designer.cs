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
            this.Pnl_AdminHome = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Flp_peliculas = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_peliculas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_form = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.Tmr_menu = new System.Windows.Forms.Timer(this.components);
            this.Btn_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_funciones = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_AdminHome.SuspendLayout();
            this.Pnl_menu_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_AdminHome
            // 
            this.Pnl_AdminHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_AdminHome.Controls.Add(this.Txt_buscar);
            this.Pnl_AdminHome.Controls.Add(this.Flp_peliculas);
            this.Pnl_AdminHome.Controls.Add(this.Lbl_peliculas);
            this.Pnl_AdminHome.Controls.Add(this.Btn_guardar);
            this.Pnl_AdminHome.Controls.Add(this.Pnl_form);
            this.Pnl_AdminHome.Location = new System.Drawing.Point(189, 13);
            this.Pnl_AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_AdminHome.Name = "Pnl_AdminHome";
            this.Pnl_AdminHome.Size = new System.Drawing.Size(928, 643);
            this.Pnl_AdminHome.TabIndex = 0;
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
            this.Txt_buscar.Location = new System.Drawing.Point(217, 49);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_buscar.PlaceholderText = "Ingrese el título de una película";
            this.Txt_buscar.SelectedText = "";
            this.Txt_buscar.Size = new System.Drawing.Size(506, 55);
            this.Txt_buscar.TabIndex = 16;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // Flp_peliculas
            // 
            this.Flp_peliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flp_peliculas.AutoScroll = true;
            this.Flp_peliculas.Location = new System.Drawing.Point(43, 112);
            this.Flp_peliculas.Name = "Flp_peliculas";
            this.Flp_peliculas.Size = new System.Drawing.Size(877, 428);
            this.Flp_peliculas.TabIndex = 15;
            // 
            // Lbl_peliculas
            // 
            this.Lbl_peliculas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_peliculas.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculas.Location = new System.Drawing.Point(3, 3);
            this.Lbl_peliculas.Name = "Lbl_peliculas";
            this.Lbl_peliculas.Size = new System.Drawing.Size(179, 52);
            this.Lbl_peliculas.TabIndex = 1;
            this.Lbl_peliculas.Text = "PELÍCULAS";
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
            this.Btn_guardar.Location = new System.Drawing.Point(145, 564);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(190, 60);
            this.Btn_guardar.TabIndex = 10;
            this.Btn_guardar.Text = "Agregar Película";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Pnl_form
            // 
            this.Pnl_form.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_form.Location = new System.Drawing.Point(32, 179);
            this.Pnl_form.Name = "Pnl_form";
            this.Pnl_form.Size = new System.Drawing.Size(798, 266);
            this.Pnl_form.TabIndex = 17;
            this.Pnl_form.Visible = false;
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Btn_usuarios);
            this.Pnl_menu_left.Controls.Add(this.Btn_funciones);
            this.Pnl_menu_left.Controls.Add(this.Btn_salas);
            this.Pnl_menu_left.Controls.Add(this.Btn_peliculas);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(0, 1);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(181, 668);
            this.Pnl_menu_left.TabIndex = 1;
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
            // Tmr_menu
            // 
            this.Tmr_menu.Interval = 10;
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
            this.Btn_usuarios.Location = new System.Drawing.Point(0, 412);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(180, 45);
            this.Btn_usuarios.TabIndex = 3;
            this.Btn_usuarios.Text = "Usuarios";
            this.Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // Btn_funciones
            // 
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
            this.Btn_funciones.TabIndex = 3;
            this.Btn_funciones.Text = "Funciones";
            this.Btn_funciones.Click += new System.EventHandler(this.Btn_funciones_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 663);
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
            this.Pnl_menu_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_AdminHome;
        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private System.Windows.Forms.Timer Tmr_menu;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private System.Windows.Forms.FlowLayoutPanel Flp_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar;
        private Guna.UI2.WinForms.Guna2Panel Pnl_form;
        private Guna.UI2.WinForms.Guna2Button Btn_usuarios;
        private Guna.UI2.WinForms.Guna2Button Btn_funciones;
    }
}