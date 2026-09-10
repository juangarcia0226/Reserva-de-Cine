namespace ReservaCine
{
    partial class UserContrasena
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
            this.Txt_correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_enviar = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_correo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_codigo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_verificar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_codigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Txt_correo
            // 
            this.Txt_correo.Animated = true;
            this.Txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_correo.DefaultText = "";
            this.Txt_correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_correo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_correo.ForeColor = System.Drawing.Color.Black;
            this.Txt_correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_correo.Location = new System.Drawing.Point(263, 137);
            this.Txt_correo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_correo.PlaceholderText = "correo@ejemplo.com";
            this.Txt_correo.SelectedText = "";
            this.Txt_correo.Size = new System.Drawing.Size(258, 55);
            this.Txt_correo.TabIndex = 2;
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_enviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_enviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_enviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_enviar.ForeColor = System.Drawing.Color.White;
            this.Btn_enviar.Location = new System.Drawing.Point(326, 199);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(133, 49);
            this.Btn_enviar.TabIndex = 4;
            this.Btn_enviar.Text = "Enviar código";
            this.Btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_correo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(263, 105);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(59, 25);
            this.Lbl_correo.TabIndex = 8;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(96, 67);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(578, 30);
            this.Lbl_titulo.TabIndex = 9;
            this.Lbl_titulo.Text = "Ingrese su correo registrado para enviar un código de verificación.";
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(263, 267);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(62, 25);
            this.Lbl_codigo.TabIndex = 12;
            this.Lbl_codigo.Text = "Código:";
            this.Lbl_codigo.Visible = false;
            // 
            // Btn_verificar
            // 
            this.Btn_verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_verificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_verificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_verificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_verificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_verificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_verificar.ForeColor = System.Drawing.Color.White;
            this.Btn_verificar.Location = new System.Drawing.Point(326, 361);
            this.Btn_verificar.Name = "Btn_verificar";
            this.Btn_verificar.Size = new System.Drawing.Size(142, 49);
            this.Btn_verificar.TabIndex = 11;
            this.Btn_verificar.Text = "Verificar código";
            this.Btn_verificar.Visible = false;
            this.Btn_verificar.Click += new System.EventHandler(this.Btn_verificar_Click);
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Animated = true;
            this.Txt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_codigo.DefaultText = "";
            this.Txt_codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Txt_codigo.ForeColor = System.Drawing.Color.Black;
            this.Txt_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_codigo.Location = new System.Drawing.Point(263, 299);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_codigo.PlaceholderText = "Ingrese el código";
            this.Txt_codigo.SelectedText = "";
            this.Txt_codigo.Size = new System.Drawing.Size(258, 55);
            this.Txt_codigo.TabIndex = 10;
            this.Txt_codigo.Visible = false;
            // 
            // Btn_volver
            // 
            this.Btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_volver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_volver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_volver.FillColor = System.Drawing.Color.Empty;
            this.Btn_volver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_volver.ForeColor = System.Drawing.Color.White;
            this.Btn_volver.Location = new System.Drawing.Point(12, 12);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(101, 32);
            this.Btn_volver.TabIndex = 13;
            this.Btn_volver.Text = "Volver";
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // UserContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.Lbl_codigo);
            this.Controls.Add(this.Btn_verificar);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.Txt_correo);
            this.Name = "UserContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserContrasena";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserContrasena_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Txt_correo;
        private Guna.UI2.WinForms.Guna2Button Btn_enviar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_correo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_codigo;
        private Guna.UI2.WinForms.Guna2Button Btn_verificar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_codigo;
        private Guna.UI2.WinForms.Guna2Button Btn_volver;
    }
}