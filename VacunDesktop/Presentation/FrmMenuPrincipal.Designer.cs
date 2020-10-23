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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuItemPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTutores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemListados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPrincipal,
            this.mnuItemListados,
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
            this.MnuItemCalendarios});
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
            // mnuItemListados
            // 
            this.mnuItemListados.Name = "mnuItemListados";
            this.mnuItemListados.Size = new System.Drawing.Size(62, 20);
            this.mnuItemListados.Text = "Listados";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            // 
            // MnuItemCalendarios
            // 
            this.MnuItemCalendarios.Name = "MnuItemCalendarios";
            this.MnuItemCalendarios.Size = new System.Drawing.Size(136, 22);
            this.MnuItemCalendarios.Text = "Calendarios";
            this.MnuItemCalendarios.Click += new System.EventHandler(this.MnuItemCalendarios_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Aplicación de escritorio de Vacunas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
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
    }
}

