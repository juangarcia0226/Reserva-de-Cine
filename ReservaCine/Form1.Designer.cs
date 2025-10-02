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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Img_login = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Txt_user_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_pass_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_iniciar_login = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_register_login = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_login = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_error_login = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Img_login
            // 
            this.Img_login.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.Image = ((System.Drawing.Image)(resources.GetObject("Img_login.Image")));
            this.Img_login.ImageOffset = new System.Drawing.Point(0, 0);
            this.Img_login.ImageRotate = 0F;
            this.Img_login.Location = new System.Drawing.Point(298, 40);
            this.Img_login.Name = "Img_login";
            this.Img_login.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Img_login.Size = new System.Drawing.Size(149, 84);
            this.Img_login.TabIndex = 0;
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
            this.Txt_user_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_user_login.ForeColor = System.Drawing.Color.Black;
            this.Txt_user_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_user_login.Location = new System.Drawing.Point(262, 150);
            this.Txt_user_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_user_login.Name = "Txt_user_login";
            this.Txt_user_login.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txt_user_login.PlaceholderText = "usuario";
            this.Txt_user_login.SelectedText = "";
            this.Txt_user_login.Size = new System.Drawing.Size(229, 48);
            this.Txt_user_login.TabIndex = 1;
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
            this.Txt_pass_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_pass_login.ForeColor = System.Drawing.Color.Black;
            this.Txt_pass_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_pass_login.Location = new System.Drawing.Point(262, 225);
            this.Txt_pass_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_pass_login.Name = "Txt_pass_login";
            this.Txt_pass_login.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txt_pass_login.PlaceholderText = "contraseña";
            this.Txt_pass_login.SelectedText = "";
            this.Txt_pass_login.Size = new System.Drawing.Size(229, 48);
            this.Txt_pass_login.TabIndex = 2;
            // 
            // Btn_iniciar_login
            // 
            this.Btn_iniciar_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_iniciar_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_iniciar_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_iniciar_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_iniciar_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_iniciar_login.ForeColor = System.Drawing.Color.White;
            this.Btn_iniciar_login.Location = new System.Drawing.Point(227, 324);
            this.Btn_iniciar_login.Name = "Btn_iniciar_login";
            this.Btn_iniciar_login.Size = new System.Drawing.Size(133, 49);
            this.Btn_iniciar_login.TabIndex = 3;
            this.Btn_iniciar_login.Text = "Iniciar sesión";
            this.Btn_iniciar_login.Click += new System.EventHandler(this.Btn_iniciar_login_Click);
            // 
            // Btn_register_login
            // 
            this.Btn_register_login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_register_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_register_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_register_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_register_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_register_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_register_login.ForeColor = System.Drawing.Color.White;
            this.Btn_register_login.Location = new System.Drawing.Point(389, 324);
            this.Btn_register_login.Name = "Btn_register_login";
            this.Btn_register_login.Size = new System.Drawing.Size(133, 49);
            this.Btn_register_login.TabIndex = 4;
            this.Btn_register_login.Text = "Registrarse";
            // 
            // Pnl_login
            // 
            this.Pnl_login.Controls.Add(this.Lbl_error_login);
            this.Pnl_login.Controls.Add(this.Img_login);
            this.Pnl_login.Controls.Add(this.Btn_register_login);
            this.Pnl_login.Controls.Add(this.Txt_user_login);
            this.Pnl_login.Controls.Add(this.Btn_iniciar_login);
            this.Pnl_login.Controls.Add(this.Txt_pass_login);
            this.Pnl_login.Location = new System.Drawing.Point(12, 12);
            this.Pnl_login.Name = "Pnl_login";
            this.Pnl_login.Size = new System.Drawing.Size(776, 426);
            this.Pnl_login.TabIndex = 5;
            // 
            // Lbl_error_login
            // 
            this.Lbl_error_login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error_login.Location = new System.Drawing.Point(319, 291);
            this.Lbl_error_login.Name = "Lbl_error_login";
            this.Lbl_error_login.Size = new System.Drawing.Size(6, 18);
            this.Lbl_error_login.TabIndex = 5;
            this.Lbl_error_login.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private Guna.UI2.WinForms.Guna2TextBox Txt_user_login;
        private Guna.UI2.WinForms.Guna2TextBox Txt_pass_login;
        private Guna.UI2.WinForms.Guna2Button Btn_iniciar_login;
        private Guna.UI2.WinForms.Guna2Button Btn_register_login;
        private Guna.UI2.WinForms.Guna2Panel Pnl_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error_login;
    }
}

