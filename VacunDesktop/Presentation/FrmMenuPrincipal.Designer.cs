namespace VacunDesktop.Presentation
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuItemPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTutores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemListados = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoCalendariosYVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoTutoresyPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnTutores = new System.Windows.Forms.ToolStripButton();
            this.BtnCalendarios = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipal.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPrincipal,
            this.mnuItemListados,
            this.configuraciónToolStripMenuItem,
            this.mnuSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuItemPrincipal
            // 
            this.mnuItemPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTutores,
            this.MnuItemCalendarios,
            this.MnuItemVacunas,
            this.MnuItemPacientes});
            this.mnuItemPrincipal.Name = "mnuItemPrincipal";
            this.mnuItemPrincipal.Size = new System.Drawing.Size(65, 20);
            this.mnuItemPrincipal.Text = "Principal";
            // 
            // mnuItemTutores
            // 
            this.mnuItemTutores.Name = "mnuItemTutores";
            this.mnuItemTutores.Size = new System.Drawing.Size(136, 22);
            this.mnuItemTutores.Text = "Tutores";
            this.mnuItemTutores.Click += new System.EventHandler(this.mnuItemTutores_Click);
            // 
            // MnuItemCalendarios
            // 
            this.MnuItemCalendarios.Name = "MnuItemCalendarios";
            this.MnuItemCalendarios.Size = new System.Drawing.Size(136, 22);
            this.MnuItemCalendarios.Text = "Calendarios";
            this.MnuItemCalendarios.Click += new System.EventHandler(this.MnuItemCalendarios_Click);
            // 
            // MnuItemVacunas
            // 
            this.MnuItemVacunas.Name = "MnuItemVacunas";
            this.MnuItemVacunas.Size = new System.Drawing.Size(136, 22);
            this.MnuItemVacunas.Text = "Vacunas";
            this.MnuItemVacunas.Click += new System.EventHandler(this.MnuItemVacunas_Click);
            // 
            // MnuItemPacientes
            // 
            this.MnuItemPacientes.Name = "MnuItemPacientes";
            this.MnuItemPacientes.Size = new System.Drawing.Size(136, 22);
            this.MnuItemPacientes.Text = "Pacientes";
            this.MnuItemPacientes.Click += new System.EventHandler(this.MnuItemPacientes_Click);
            // 
            // mnuItemListados
            // 
            this.mnuItemListados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuListadoVacunas,
            this.MnuListadoCalendarios,
            this.MnuListadoCalendariosYVacunas,
            this.MnuListadoTutoresyPacientes});
            this.mnuItemListados.Name = "mnuItemListados";
            this.mnuItemListados.Size = new System.Drawing.Size(62, 20);
            this.mnuItemListados.Text = "Listados";
            // 
            // MnuListadoVacunas
            // 
            this.MnuListadoVacunas.Name = "MnuListadoVacunas";
            this.MnuListadoVacunas.Size = new System.Drawing.Size(232, 22);
            this.MnuListadoVacunas.Text = "Listado Vacunas";
            this.MnuListadoVacunas.Click += new System.EventHandler(this.MnuListadoVacunas_Click);
            // 
            // MnuListadoCalendarios
            // 
            this.MnuListadoCalendarios.Name = "MnuListadoCalendarios";
            this.MnuListadoCalendarios.Size = new System.Drawing.Size(232, 22);
            this.MnuListadoCalendarios.Text = "Listado de calendarios";
            this.MnuListadoCalendarios.Click += new System.EventHandler(this.MnuListadoCalendarios_Click);
            // 
            // MnuListadoCalendariosYVacunas
            // 
            this.MnuListadoCalendariosYVacunas.Name = "MnuListadoCalendariosYVacunas";
            this.MnuListadoCalendariosYVacunas.Size = new System.Drawing.Size(232, 22);
            this.MnuListadoCalendariosYVacunas.Text = "Listado Calendarios y Vacunas";
            this.MnuListadoCalendariosYVacunas.Click += new System.EventHandler(this.MnuListadoCalendariosYVacunas_Click);
            // 
            // MnuListadoTutoresyPacientes
            // 
            this.MnuListadoTutoresyPacientes.Name = "MnuListadoTutoresyPacientes";
            this.MnuListadoTutoresyPacientes.Size = new System.Drawing.Size(232, 22);
            this.MnuListadoTutoresyPacientes.Text = "Listado de tutores y pacientes";
            this.MnuListadoTutoresyPacientes.Click += new System.EventHandler(this.MnuListadoTutoresyPacientes_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parámetrosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parámetrosToolStripMenuItem.Text = "Parámetros";
            this.parámetrosToolStripMenuItem.Click += new System.EventHandler(this.parámetrosToolStripMenuItem_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTutores,
            this.BtnCalendarios});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(800, 54);
            this.BarraHerramientas.TabIndex = 1;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // BtnTutores
            // 
            this.BtnTutores.Image = ((System.Drawing.Image)(resources.GetObject("BtnTutores.Image")));
            this.BtnTutores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTutores.Name = "BtnTutores";
            this.BtnTutores.Size = new System.Drawing.Size(50, 51);
            this.BtnTutores.Text = "Tutores";
            this.BtnTutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTutores.ToolTipText = "Gestión de tutores";
            this.BtnTutores.Click += new System.EventHandler(this.BtnTutores_Click);
            // 
            // BtnCalendarios
            // 
            this.BtnCalendarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalendarios.Image")));
            this.BtnCalendarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCalendarios.Name = "BtnCalendarios";
            this.BtnCalendarios.Size = new System.Drawing.Size(73, 51);
            this.BtnCalendarios.Text = "Calendarios";
            this.BtnCalendarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCalendarios.ToolTipText = "Gestión de calendarios";
            this.BtnCalendarios.Click += new System.EventHandler(this.BtnCalendarios_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VacunDesktop.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.menuPrincipal);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Aplicación de escritorio de Vacunas :: ISP20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuItemListados;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTutores;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCalendarios;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVacunas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemPacientes;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton BtnTutores;
        private System.Windows.Forms.ToolStripButton BtnCalendarios;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoVacunas;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoCalendarios;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoCalendariosYVacunas;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoTutoresyPacientes;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
    }
}

