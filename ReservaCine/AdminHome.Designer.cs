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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.Pnl_AdminHome = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_menu_left = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_menu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Tmr_menu = new System.Windows.Forms.Timer(this.components);
            this.Btn_salir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Dgv_pelis = new System.Windows.Forms.DataGridView();
            this.Pnl_AdminHome.SuspendLayout();
            this.Pnl_menu_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pelis)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_AdminHome
            // 
            this.Pnl_AdminHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_AdminHome.Controls.Add(this.Dgv_pelis);
            this.Pnl_AdminHome.Location = new System.Drawing.Point(106, 12);
            this.Pnl_AdminHome.Name = "Pnl_AdminHome";
            this.Pnl_AdminHome.Size = new System.Drawing.Size(676, 479);
            this.Pnl_AdminHome.TabIndex = 0;
            // 
            // Pnl_menu_left
            // 
            this.Pnl_menu_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_menu_left.Controls.Add(this.Btn_salir);
            this.Pnl_menu_left.Controls.Add(this.Btn_menu);
            this.Pnl_menu_left.Location = new System.Drawing.Point(0, 1);
            this.Pnl_menu_left.Name = "Pnl_menu_left";
            this.Pnl_menu_left.Size = new System.Drawing.Size(100, 502);
            this.Pnl_menu_left.TabIndex = 1;
            // 
            // Btn_menu
            // 
            this.Btn_menu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_menu.Image")));
            this.Btn_menu.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_menu.ImageRotate = 0F;
            this.Btn_menu.Location = new System.Drawing.Point(21, 11);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_menu.Size = new System.Drawing.Size(51, 39);
            this.Btn_menu.TabIndex = 0;
            this.Btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // Tmr_menu
            // 
            this.Tmr_menu.Interval = 10;
            this.Tmr_menu.Tick += new System.EventHandler(this.Tmr_menu_Tick);
            // 
            // Btn_salir
            // 
            this.Btn_salir.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_salir.ImageRotate = 0F;
            this.Btn_salir.Location = new System.Drawing.Point(12, 383);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_salir.Size = new System.Drawing.Size(64, 54);
            this.Btn_salir.TabIndex = 1;
            // 
            // Dgv_pelis
            // 
            this.Dgv_pelis.AllowUserToAddRows = false;
            this.Dgv_pelis.AllowUserToDeleteRows = false;
            this.Dgv_pelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pelis.Location = new System.Drawing.Point(63, 351);
            this.Dgv_pelis.Name = "Dgv_pelis";
            this.Dgv_pelis.ReadOnly = true;
            this.Dgv_pelis.Size = new System.Drawing.Size(556, 105);
            this.Dgv_pelis.TabIndex = 0;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(794, 503);
            this.Controls.Add(this.Pnl_menu_left);
            this.Controls.Add(this.Pnl_AdminHome);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.Pnl_AdminHome.ResumeLayout(false);
            this.Pnl_menu_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pelis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pnl_AdminHome;
        private Guna.UI2.WinForms.Guna2Panel Pnl_menu_left;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_menu;
        private System.Windows.Forms.Timer Tmr_menu;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_salir;
        private System.Windows.Forms.DataGridView Dgv_pelis;
    }
}