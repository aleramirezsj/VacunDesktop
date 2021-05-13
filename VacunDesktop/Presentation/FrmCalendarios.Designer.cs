namespace VacunDesktop.Presentation
{
    partial class FrmCalendarios
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.GridDetalle = new System.Windows.Forms.DataGridView();
            this.CboVacuna = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminarVacuna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(60, 32);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 149);
            this.grid.TabIndex = 0;
            this.grid.Text = "dataGridView1";

            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(600, 143);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(77, 29);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(715, 143);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(77, 29);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "&Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(831, 143);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 29);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(651, 86);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(257, 23);
            this.TxtBusqueda.TabIndex = 3;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // GridDetalle
            // 
            this.GridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalle.Location = new System.Drawing.Point(60, 284);
            this.GridDetalle.Name = "GridDetalle";
            this.GridDetalle.ReadOnly = true;
            this.GridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDetalle.Size = new System.Drawing.Size(508, 107);
            this.GridDetalle.TabIndex = 0;
            this.GridDetalle.Text = "dataGridView1";
            // 
            // CboVacuna
            // 
            this.CboVacuna.FormattingEnabled = true;
            this.CboVacuna.Location = new System.Drawing.Point(60, 222);
            this.CboVacuna.Name = "CboVacuna";
            this.CboVacuna.Size = new System.Drawing.Size(330, 23);
            this.CboVacuna.TabIndex = 4;
            this.CboVacuna.SelectedIndexChanged += new System.EventHandler(this.CboVacuna_SelectedIndexChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.Location = new System.Drawing.Point(450, 222);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(110, 23);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar Vacuna";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminarVacuna
            // 
            this.BtnEliminarVacuna.Location = new System.Drawing.Point(589, 322);
            this.BtnEliminarVacuna.Name = "BtnEliminarVacuna";
            this.BtnEliminarVacuna.Size = new System.Drawing.Size(150, 23);
            this.BtnEliminarVacuna.TabIndex = 6;
            this.BtnEliminarVacuna.Text = "Eliminar vacuna";
            this.BtnEliminarVacuna.UseVisualStyleBackColor = true;
            this.BtnEliminarVacuna.Click += new System.EventHandler(this.BtnEliminarVacuna_Click);
            // 
            // FrmCalendarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.BtnEliminarVacuna);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboVacuna);
            this.Controls.Add(this.GridDetalle);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.grid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalendarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendarios";
            this.Activated += new System.EventHandler(this.FrmCalendarios_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView GridDetalle;
        private System.Windows.Forms.ComboBox CboVacuna;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminarVacuna;
    }
}