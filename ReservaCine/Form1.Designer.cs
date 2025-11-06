namespace ReservaCine
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Img_login = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Txt_pass_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_iniciar_login = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_register_login = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_login = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_contrasena = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_correo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_error_login = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_user_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pnl_form = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Img_login
            // 
            this.Img_login.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.Image = global::ReservaCine.Properties.Resources._5127040;
            this.Img_login.ImageOffset = new System.Drawing.Point(0, 0);
            this.Img_login.ImageRotate = 0F;
            this.Img_login.Location = new System.Drawing.Point(378, 64);
            this.Img_login.Name = "Img_login";
            this.Img_login.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.Size = new System.Drawing.Size(149, 84);
            this.Img_login.TabIndex = 0;
            // 
            // Txt_pass_login
            // 
            this.Txt_pass_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_pass_login.DefaultText = "";
            this.Txt_pass_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_pass_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_pass_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_pass_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_pass_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_pass_login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pass_login.ForeColor = System.Drawing.Color.Black;
            this.Txt_pass_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_pass_login.Location = new System.Drawing.Point(326, 268);
            this.Txt_pass_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_pass_login.Name = "Txt_pass_login";
            this.Txt_pass_login.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_pass_login.PlaceholderText = "Contraseña";
            this.Txt_pass_login.SelectedText = "";
            this.Txt_pass_login.Size = new System.Drawing.Size(258, 55);
            this.Txt_pass_login.TabIndex = 2;
            // 
            // Btn_iniciar_login
            // 
            this.Btn_iniciar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iniciar_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_iniciar_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_iniciar_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_iniciar_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_iniciar_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_iniciar_login.ForeColor = System.Drawing.Color.White;
            this.Btn_iniciar_login.Location = new System.Drawing.Point(307, 383);
            this.Btn_iniciar_login.Name = "Btn_iniciar_login";
            this.Btn_iniciar_login.Size = new System.Drawing.Size(133, 49);
            this.Btn_iniciar_login.TabIndex = 3;
            this.Btn_iniciar_login.Text = "Iniciar sesión";
            this.Btn_iniciar_login.Click += new System.EventHandler(this.Btn_iniciar_login_Click);
            // 
            // Btn_register_login
            // 
            this.Btn_register_login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_register_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_register_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_register_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_register_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_register_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_register_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_register_login.ForeColor = System.Drawing.Color.White;
            this.Btn_register_login.Location = new System.Drawing.Point(469, 383);
            this.Btn_register_login.Name = "Btn_register_login";
            this.Btn_register_login.Size = new System.Drawing.Size(133, 49);
            this.Btn_register_login.TabIndex = 4;
            this.Btn_register_login.Text = "Registrarse";
            this.Btn_register_login.Click += new System.EventHandler(this.Btn_register_login_Click);
            // 
            // Pnl_login
            // 
            this.Pnl_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pnl_login.BorderRadius = 10;
            this.Pnl_login.Controls.Add(this.Lbl_contrasena);
            this.Pnl_login.Controls.Add(this.Lbl_correo);
            this.Pnl_login.Controls.Add(this.Txt_pass_login);
            this.Pnl_login.Controls.Add(this.Lbl_error_login);
            this.Pnl_login.Controls.Add(this.Img_login);
            this.Pnl_login.Controls.Add(this.Btn_register_login);
            this.Pnl_login.Controls.Add(this.Txt_user_login);
            this.Pnl_login.Controls.Add(this.Btn_iniciar_login);
            this.Pnl_login.Controls.Add(this.Pnl_form);
            this.Pnl_login.Location = new System.Drawing.Point(12, 12);
            this.Pnl_login.Name = "Pnl_login";
            this.Pnl_login.Size = new System.Drawing.Size(941, 500);
            this.Pnl_login.TabIndex = 5;
            // 
            // Lbl_contrasena
            // 
            this.Lbl_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_contrasena.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contrasena.Location = new System.Drawing.Point(326, 236);
            this.Lbl_contrasena.Name = "Lbl_contrasena";
            this.Lbl_contrasena.Size = new System.Drawing.Size(90, 25);
            this.Lbl_contrasena.TabIndex = 8;
            this.Lbl_contrasena.Text = "Contrasena";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_correo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(326, 142);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(59, 25);
            this.Lbl_correo.TabIndex = 7;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_error_login
            // 
            this.Lbl_error_login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error_login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error_login.Location = new System.Drawing.Point(360, 341);
            this.Lbl_error_login.Name = "Lbl_error_login";
            this.Lbl_error_login.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error_login.TabIndex = 5;
            this.Lbl_error_login.Text = ".";
            // 
            // Txt_user_login
            // 
            this.Txt_user_login.Animated = true;
            this.Txt_user_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_user_login.DefaultText = "";
            this.Txt_user_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_user_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_user_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_user_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_user_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_user_login.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_user_login.ForeColor = System.Drawing.Color.Black;
            this.Txt_user_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_user_login.Location = new System.Drawing.Point(326, 174);
            this.Txt_user_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_user_login.Name = "Txt_user_login";
            this.Txt_user_login.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_user_login.PlaceholderText = "correo@ejemplo.com";
            this.Txt_user_login.SelectedText = "";
            this.Txt_user_login.Size = new System.Drawing.Size(258, 55);
            this.Txt_user_login.TabIndex = 1;
            // 
            // Pnl_form
            // 
            this.Pnl_form.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_form.BorderRadius = 10;
            this.Pnl_form.Location = new System.Drawing.Point(782, 103);
            this.Pnl_form.Name = "Pnl_form";
            this.Pnl_form.Size = new System.Drawing.Size(752, 369);
            this.Pnl_form.TabIndex = 6;
            this.Pnl_form.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(965, 524);
            this.Controls.Add(this.Pnl_login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pnl_login.ResumeLayout(false);
            this.Pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton Img_login;
        private Guna.UI2.WinForms.Guna2TextBox Txt_pass_login;
        private Guna.UI2.WinForms.Guna2Button Btn_iniciar_login;
        private Guna.UI2.WinForms.Guna2Button Btn_register_login;
        private Guna.UI2.WinForms.Guna2Panel Pnl_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error_login;
        private Guna.UI2.WinForms.Guna2Panel Pnl_form;
        private Guna.UI2.WinForms.Guna2TextBox Txt_user_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_contrasena;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_correo;
    }
}

