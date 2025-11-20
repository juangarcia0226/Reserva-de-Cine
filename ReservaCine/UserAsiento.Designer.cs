namespace ReservaCine
{
    partial class UserAsiento
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
            this.Lbl_usuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pbx_usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_salir = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_principal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_pantalla = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_reservar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_seleccionados = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Flp_seleccionados = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_leyenda = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_asientos = new System.Windows.Forms.FlowLayoutPanel();
            this.Pnl_funcionInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_asientos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_menu_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_usuario)).BeginInit();
            this.Pnl_principal.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Lbl_usuario);
            this.Pnl_menu_left.Controls.Add(this.Pbx_usuario);
            this.Pnl_menu_left.Controls.Add(this.Btn_salir);
            this.Pnl_menu_left.Controls.Add(this.Btn_salas);
            this.Pnl_menu_left.Controls.Add(this.Btn_peliculas);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(-3, -5);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(179, 800);
            this.Pnl_menu_left.TabIndex = 4;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(53, 208);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(61, 25);
            this.Lbl_usuario.TabIndex = 5;
            this.Lbl_usuario.Text = "Usuario";
            // 
            // Pbx_usuario
            // 
            this.Pbx_usuario.ImageRotate = 0F;
            this.Pbx_usuario.Location = new System.Drawing.Point(38, 102);
            this.Pbx_usuario.Name = "Pbx_usuario";
            this.Pbx_usuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Pbx_usuario.Size = new System.Drawing.Size(94, 87);
            this.Pbx_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_usuario.TabIndex = 4;
            this.Pbx_usuario.TabStop = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_salir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_salir.ForeColor = System.Drawing.Color.White;
            this.Btn_salir.Location = new System.Drawing.Point(0, 736);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(180, 45);
            this.Btn_salir.TabIndex = 3;
            this.Btn_salir.Text = "Cerrar sesión";
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_salas
            // 
            this.Btn_salas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_salas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_salas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_salas.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_salas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_salas.ForeColor = System.Drawing.Color.White;
            this.Btn_salas.Location = new System.Drawing.Point(0, 344);
            this.Btn_salas.Name = "Btn_salas";
            this.Btn_salas.Size = new System.Drawing.Size(180, 45);
            this.Btn_salas.TabIndex = 2;
            this.Btn_salas.Text = "Mis reservas";
            // 
            // Btn_peliculas
            // 
            this.Btn_peliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_peliculas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_peliculas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_peliculas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_peliculas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_peliculas.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_peliculas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_peliculas.ForeColor = System.Drawing.Color.White;
            this.Btn_peliculas.Location = new System.Drawing.Point(0, 284);
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
            // Pnl_principal
            // 
            this.Pnl_principal.Controls.Add(this.guna2Panel1);
            this.Pnl_principal.Controls.Add(this.Btn_reservar);
            this.Pnl_principal.Controls.Add(this.Lbl_seleccionados);
            this.Pnl_principal.Controls.Add(this.Flp_seleccionados);
            this.Pnl_principal.Controls.Add(this.Flp_leyenda);
            this.Pnl_principal.Controls.Add(this.Flp_asientos);
            this.Pnl_principal.Controls.Add(this.Pnl_funcionInfo);
            this.Pnl_principal.Controls.Add(this.Lbl_asientos);
            this.Pnl_principal.Location = new System.Drawing.Point(183, 12);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(973, 770);
            this.Pnl_principal.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Controls.Add(this.Lbl_pantalla);
            this.guna2Panel1.Location = new System.Drawing.Point(9, 392);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(678, 33);
            this.guna2Panel1.TabIndex = 26;
            // 
            // Lbl_pantalla
            // 
            this.Lbl_pantalla.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_pantalla.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pantalla.Location = new System.Drawing.Point(303, 0);
            this.Lbl_pantalla.Name = "Lbl_pantalla";
            this.Lbl_pantalla.Size = new System.Drawing.Size(85, 33);
            this.Lbl_pantalla.TabIndex = 22;
            this.Lbl_pantalla.Text = "Pantalla";
            // 
            // Btn_reservar
            // 
            this.Btn_reservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reservar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_reservar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_reservar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_reservar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_reservar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_reservar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_reservar.ForeColor = System.Drawing.Color.White;
            this.Btn_reservar.Location = new System.Drawing.Point(771, 595);
            this.Btn_reservar.Name = "Btn_reservar";
            this.Btn_reservar.Size = new System.Drawing.Size(125, 38);
            this.Btn_reservar.TabIndex = 6;
            this.Btn_reservar.Text = "Reservar";
            this.Btn_reservar.Visible = false;
            this.Btn_reservar.Click += new System.EventHandler(this.Btn_reservar_Click);
            // 
            // Lbl_seleccionados
            // 
            this.Lbl_seleccionados.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_seleccionados.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionados.Location = new System.Drawing.Point(694, 400);
            this.Lbl_seleccionados.Name = "Lbl_seleccionados";
            this.Lbl_seleccionados.Size = new System.Drawing.Size(181, 25);
            this.Lbl_seleccionados.TabIndex = 25;
            this.Lbl_seleccionados.Text = "Asientos seleccionados:";
            this.Lbl_seleccionados.Visible = false;
            // 
            // Flp_seleccionados
            // 
            this.Flp_seleccionados.AutoScroll = true;
            this.Flp_seleccionados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp_seleccionados.Location = new System.Drawing.Point(694, 431);
            this.Flp_seleccionados.Name = "Flp_seleccionados";
            this.Flp_seleccionados.Padding = new System.Windows.Forms.Padding(10);
            this.Flp_seleccionados.Size = new System.Drawing.Size(276, 158);
            this.Flp_seleccionados.TabIndex = 24;
            this.Flp_seleccionados.WrapContents = false;
            // 
            // Flp_leyenda
            // 
            this.Flp_leyenda.Location = new System.Drawing.Point(9, 327);
            this.Flp_leyenda.Name = "Flp_leyenda";
            this.Flp_leyenda.Size = new System.Drawing.Size(678, 59);
            this.Flp_leyenda.TabIndex = 23;
            // 
            // Flp_asientos
            // 
            this.Flp_asientos.AutoScroll = true;
            this.Flp_asientos.Location = new System.Drawing.Point(9, 431);
            this.Flp_asientos.Name = "Flp_asientos";
            this.Flp_asientos.Size = new System.Drawing.Size(678, 333);
            this.Flp_asientos.TabIndex = 21;
            // 
            // Pnl_funcionInfo
            // 
            this.Pnl_funcionInfo.Location = new System.Drawing.Point(157, 61);
            this.Pnl_funcionInfo.Name = "Pnl_funcionInfo";
            this.Pnl_funcionInfo.Size = new System.Drawing.Size(643, 225);
            this.Pnl_funcionInfo.TabIndex = 20;
            // 
            // Lbl_asientos
            // 
            this.Lbl_asientos.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_asientos.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asientos.Location = new System.Drawing.Point(9, 3);
            this.Lbl_asientos.Name = "Lbl_asientos";
            this.Lbl_asientos.Size = new System.Drawing.Size(171, 52);
            this.Lbl_asientos.TabIndex = 19;
            this.Lbl_asientos.Text = "ASIENTOS";
            // 
            // UserAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 788);
            this.Controls.Add(this.Pnl_principal);
            this.Controls.Add(this.Pnl_menu_left);
            this.Name = "UserAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAsiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAsiento_FormClosing);
            this.Pnl_menu_left.ResumeLayout(false);
            this.Pnl_menu_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_usuario)).EndInit();
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_usuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Pbx_usuario;
        private Guna.UI2.WinForms.Guna2Button Btn_salir;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private Guna.UI2.WinForms.Guna2Panel Pnl_principal;
        private Guna.UI2.WinForms.Guna2Panel Pnl_funcionInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_asientos;
        private System.Windows.Forms.FlowLayoutPanel Flp_asientos;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_pantalla;
        private System.Windows.Forms.FlowLayoutPanel Flp_leyenda;
        private System.Windows.Forms.FlowLayoutPanel Flp_seleccionados;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_seleccionados;
        private Guna.UI2.WinForms.Guna2Button Btn_reservar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}