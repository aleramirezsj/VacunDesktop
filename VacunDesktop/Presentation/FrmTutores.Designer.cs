namespace VacunDesktop.Presentation
{
    partial class FrmTutores
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
            this.gridTutores = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEditarPaciente = new System.Windows.Forms.Button();
            this.BtnAgregarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTutores
            // 
            this.gridTutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTutores.Location = new System.Drawing.Point(60, 31);
            this.gridTutores.Name = "gridTutores";
            this.gridTutores.ReadOnly = true;
            this.gridTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTutores.Size = new System.Drawing.Size(658, 182);
            this.gridTutores.TabIndex = 0;
            this.gridTutores.Text = "dataGridView1";
            this.gridTutores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTutores_CellEnter);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(813, 43);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(77, 29);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(813, 78);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(77, 29);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "&Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(813, 113);
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
            this.label1.Location = new System.Drawing.Point(830, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(760, 167);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(185, 23);
            this.TxtBusqueda.TabIndex = 3;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // GridPacientes
            // 
            this.GridPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(60, 253);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.ReadOnly = true;
            this.GridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPacientes.Size = new System.Drawing.Size(658, 160);
            this.GridPacientes.TabIndex = 0;
            this.GridPacientes.Text = "dataGridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Eliminar paciente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPaciente
            // 
            this.BtnEditarPaciente.Location = new System.Drawing.Point(329, 219);
            this.BtnEditarPaciente.Name = "BtnEditarPaciente";
            this.BtnEditarPaciente.Size = new System.Drawing.Size(136, 29);
            this.BtnEditarPaciente.TabIndex = 1;
            this.BtnEditarPaciente.Text = "&Editar paciente";
            this.BtnEditarPaciente.UseVisualStyleBackColor = true;
            this.BtnEditarPaciente.Click += new System.EventHandler(this.BtnEditarPaciente_Click);
            // 
            // BtnAgregarPaciente
            // 
            this.BtnAgregarPaciente.Location = new System.Drawing.Point(150, 219);
            this.BtnAgregarPaciente.Name = "BtnAgregarPaciente";
            this.BtnAgregarPaciente.Size = new System.Drawing.Size(141, 29);
            this.BtnAgregarPaciente.TabIndex = 1;
            this.BtnAgregarPaciente.Text = "&Agregar Paciente";
            this.BtnAgregarPaciente.UseVisualStyleBackColor = true;
            this.BtnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
            // 
            // FrmTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.BtnAgregarPaciente);
            this.Controls.Add(this.BtnEditarPaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridPacientes);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.gridTutores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTutores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            ((System.ComponentModel.ISupportInitialize)(this.gridTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTutores;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEditarPaciente;
        private System.Windows.Forms.Button BtnAgregarPaciente;
    }
}