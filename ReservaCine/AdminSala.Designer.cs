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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSala));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_pelicula = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_pelicula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_pelicula = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Pnl_btnSalas = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_btnSala = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_sala = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Pnl_btnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_salir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Pnl_sala = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dgv_sala = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_actualizar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Rb_no = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Rb_si = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_tipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_columnas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_filas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_capacidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_sala = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Tmr_sala = new System.Windows.Forms.Timer(this.components);
            this.Pnl_menu_left.SuspendLayout();
            this.Pnl_pelicula.SuspendLayout();
            this.Pnl_btnSalas.SuspendLayout();
            this.Pnl_btnMenu.SuspendLayout();
            this.Pnl_sala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sala)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Pnl_pelicula);
            this.Pnl_menu_left.Controls.Add(this.Pnl_btnSalas);
            this.Pnl_menu_left.Controls.Add(this.Pnl_btnMenu);
            this.Pnl_menu_left.Controls.Add(this.Btn_salir);
            this.Pnl_menu_left.Location = new System.Drawing.Point(1, 7);
            this.Pnl_menu_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(212, 615);
            this.Pnl_menu_left.TabIndex = 2;
            // 
            // Pnl_pelicula
            // 
            this.Pnl_pelicula.Controls.Add(this.Lbl_pelicula);
            this.Pnl_pelicula.Controls.Add(this.Btn_pelicula);
            this.Pnl_pelicula.Location = new System.Drawing.Point(0, 231);
            this.Pnl_pelicula.Name = "Pnl_pelicula";
            this.Pnl_pelicula.Size = new System.Drawing.Size(206, 79);
            this.Pnl_pelicula.TabIndex = 4;
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
            this.Btn_pelicula.Location = new System.Drawing.Point(10, 10);
            this.Btn_pelicula.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_pelicula.Name = "Btn_pelicula";
            this.Btn_pelicula.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_pelicula.Size = new System.Drawing.Size(83, 65);
            this.Btn_pelicula.TabIndex = 1;
            this.Btn_pelicula.Click += new System.EventHandler(this.Btn_pelicula_Click);
            // 
            // Pnl_btnSalas
            // 
            this.Pnl_btnSalas.Controls.Add(this.Lbl_btnSala);
            this.Pnl_btnSalas.Controls.Add(this.Btn_sala);
            this.Pnl_btnSalas.Location = new System.Drawing.Point(0, 316);
            this.Pnl_btnSalas.Name = "Pnl_btnSalas";
            this.Pnl_btnSalas.Size = new System.Drawing.Size(206, 79);
            this.Pnl_btnSalas.TabIndex = 3;
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
            // Pnl_sala
            // 
            this.Pnl_sala.Controls.Add(this.Lbl_error);
            this.Pnl_sala.Controls.Add(this.Dgv_sala);
            this.Pnl_sala.Controls.Add(this.Btn_eliminar);
            this.Pnl_sala.Controls.Add(this.Btn_actualizar);
            this.Pnl_sala.Controls.Add(this.Btn_buscar);
            this.Pnl_sala.Controls.Add(this.Btn_guardar);
            this.Pnl_sala.Controls.Add(this.Rb_no);
            this.Pnl_sala.Controls.Add(this.Rb_si);
            this.Pnl_sala.Controls.Add(this.guna2HtmlLabel1);
            this.Pnl_sala.Controls.Add(this.Txt_tipo);
            this.Pnl_sala.Controls.Add(this.Txt_columnas);
            this.Pnl_sala.Controls.Add(this.Txt_filas);
            this.Pnl_sala.Controls.Add(this.Txt_capacidad);
            this.Pnl_sala.Controls.Add(this.Txt_nombre);
            this.Pnl_sala.Controls.Add(this.Lbl_sala);
            this.Pnl_sala.Location = new System.Drawing.Point(97, 7);
            this.Pnl_sala.Name = "Pnl_sala";
            this.Pnl_sala.Size = new System.Drawing.Size(1068, 615);
            this.Pnl_sala.TabIndex = 3;
            // 
            // Lbl_error
            // 
            this.Lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.Location = new System.Drawing.Point(267, 281);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(7, 25);
            this.Lbl_error.TabIndex = 20;
            this.Lbl_error.Text = ".";
            // 
            // Dgv_sala
            // 
            this.Dgv_sala.AllowUserToAddRows = false;
            this.Dgv_sala.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_sala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_sala.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.Dgv_sala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_sala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_sala.ColumnHeadersHeight = 4;
            this.Dgv_sala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_sala.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_sala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_sala.Location = new System.Drawing.Point(95, 413);
            this.Dgv_sala.Name = "Dgv_sala";
            this.Dgv_sala.ReadOnly = true;
            this.Dgv_sala.RowHeadersVisible = false;
            this.Dgv_sala.RowHeadersWidth = 51;
            this.Dgv_sala.RowTemplate.Height = 24;
            this.Dgv_sala.Size = new System.Drawing.Size(966, 150);
            this.Dgv_sala.TabIndex = 19;
            this.Dgv_sala.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_sala.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv_sala.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv_sala.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv_sala.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv_sala.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Dgv_sala.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_sala.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dgv_sala.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_sala.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_sala.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv_sala.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_sala.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv_sala.ThemeStyle.ReadOnly = true;
            this.Dgv_sala.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_sala.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_sala.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_sala.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_sala.ThemeStyle.RowsStyle.Height = 24;
            this.Dgv_sala.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_sala.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Btn_eliminar.Location = new System.Drawing.Point(727, 323);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(152, 35);
            this.Btn_eliminar.TabIndex = 18;
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
            this.Btn_actualizar.Location = new System.Drawing.Point(545, 323);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(152, 35);
            this.Btn_actualizar.TabIndex = 17;
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
            this.Btn_buscar.Location = new System.Drawing.Point(363, 323);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(152, 35);
            this.Btn_buscar.TabIndex = 16;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
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
            this.Btn_guardar.Location = new System.Drawing.Point(187, 323);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(152, 35);
            this.Btn_guardar.TabIndex = 15;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
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
            this.Rb_no.Location = new System.Drawing.Point(693, 231);
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
            this.Rb_si.Location = new System.Drawing.Point(693, 198);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(609, 168);
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
            this.Txt_tipo.Location = new System.Drawing.Point(415, 188);
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
            this.Txt_columnas.Location = new System.Drawing.Point(220, 188);
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
            this.Txt_filas.Location = new System.Drawing.Point(609, 89);
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
            this.Txt_capacidad.Location = new System.Drawing.Point(415, 89);
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
            this.Txt_nombre.Location = new System.Drawing.Point(220, 89);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_nombre.PlaceholderText = "Nombre";
            this.Txt_nombre.SelectedText = "";
            this.Txt_nombre.Size = new System.Drawing.Size(172, 38);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Lbl_sala
            // 
            this.Lbl_sala.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_sala.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sala.Location = new System.Drawing.Point(479, 17);
            this.Lbl_sala.Name = "Lbl_sala";
            this.Lbl_sala.Size = new System.Drawing.Size(108, 52);
            this.Lbl_sala.TabIndex = 0;
            this.Lbl_sala.Text = "SALAS";
            // 
            // Tmr_sala
            // 
            this.Tmr_sala.Tick += new System.EventHandler(this.Tmr_sala_Tick);
            // 
            // AdminSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1170, 625);
            this.Controls.Add(this.Pnl_menu_left);
            this.Controls.Add(this.Pnl_sala);
            this.Name = "AdminSala";
            this.Text = "AdminSala";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSala_FormClosing);
            this.Pnl_menu_left.ResumeLayout(false);
            this.Pnl_pelicula.ResumeLayout(false);
            this.Pnl_pelicula.PerformLayout();
            this.Pnl_btnSalas.ResumeLayout(false);
            this.Pnl_btnSalas.PerformLayout();
            this.Pnl_btnMenu.ResumeLayout(false);
            this.Pnl_sala.ResumeLayout(false);
            this.Pnl_sala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2Panel Pnl_btnSalas;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_btnSala;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_sala;
        private Guna.UI2.WinForms.Guna2Panel Pnl_btnMenu;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_menu;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_salir;
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
        private Guna.UI2.WinForms.Guna2DataGridView Dgv_sala;
        private Guna.UI2.WinForms.Guna2Button Btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button Btn_actualizar;
        private Guna.UI2.WinForms.Guna2Button Btn_buscar;
        private Guna.UI2.WinForms.Guna2Button Btn_guardar;
        private Guna.UI2.WinForms.Guna2Panel Pnl_pelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_pelicula;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_pelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_error;
        private System.Windows.Forms.Timer Tmr_sala;
    }
}