namespace ReservaCine
{
    partial class UserHome
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
            this.Btn_salir = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_salas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_peliculas = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.Pbx_usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Lbl_usuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Flp_peliculas = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_peliculas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_menu_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_usuario)).BeginInit();
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
            this.Pnl_menu_left.Location = new System.Drawing.Point(-5, -5);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(176, 681);
            this.Pnl_menu_left.TabIndex = 2;
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
            this.Btn_salir.Location = new System.Drawing.Point(0, 602);
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
            // Lbl_usuario
            // 
            this.Lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(50, 213);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(61, 25);
            this.Lbl_usuario.TabIndex = 5;
            this.Lbl_usuario.Text = "Usuario";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Lbl_peliculas);
            this.guna2Panel1.Controls.Add(this.Flp_peliculas);
            this.guna2Panel1.Controls.Add(this.Txt_buscar);
            this.guna2Panel1.Location = new System.Drawing.Point(178, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(973, 639);
            this.guna2Panel1.TabIndex = 4;
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
            this.Txt_buscar.Location = new System.Drawing.Point(241, 61);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Txt_buscar.PlaceholderText = "Ingrese el título de una película";
            this.Txt_buscar.SelectedText = "";
            this.Txt_buscar.Size = new System.Drawing.Size(506, 55);
            this.Txt_buscar.TabIndex = 17;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // Flp_peliculas
            // 
            this.Flp_peliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flp_peliculas.AutoScroll = true;
            this.Flp_peliculas.Location = new System.Drawing.Point(9, 124);
            this.Flp_peliculas.Name = "Flp_peliculas";
            this.Flp_peliculas.Size = new System.Drawing.Size(951, 506);
            this.Flp_peliculas.TabIndex = 18;
            // 
            // Lbl_peliculas
            // 
            this.Lbl_peliculas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_peliculas.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculas.Location = new System.Drawing.Point(9, 3);
            this.Lbl_peliculas.Name = "Lbl_peliculas";
            this.Lbl_peliculas.Size = new System.Drawing.Size(179, 52);
            this.Lbl_peliculas.TabIndex = 19;
            this.Lbl_peliculas.Text = "PELÍCULAS";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 663);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Pnl_menu_left);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserHome_FormClosing);
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.Pnl_menu_left.ResumeLayout(false);
            this.Pnl_menu_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_usuario)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2Button Btn_salir;
        private Guna.UI2.WinForms.Guna2Button Btn_salas;
        private Guna.UI2.WinForms.Guna2Button Btn_peliculas;
        private Guna.UI2.WinForms.Guna2Button Btn_menu;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_usuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Pbx_usuario;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar;
        private System.Windows.Forms.FlowLayoutPanel Flp_peliculas;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_peliculas;
    }
}