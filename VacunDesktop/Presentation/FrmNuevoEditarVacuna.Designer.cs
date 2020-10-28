namespace VacunDesktop.Presentation
{
    partial class FrmNuevoEditarVacuna
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
            this.LblNombreV = new System.Windows.Forms.Label();
            this.LblPeriodoDeAplicacion = new System.Windows.Forms.Label();
            this.LblBeneficios = new System.Windows.Forms.Label();
            this.TxtNombreV = new System.Windows.Forms.TextBox();
            this.TxtBeneficios = new System.Windows.Forms.TextBox();
            this.BtnGuardarV = new System.Windows.Forms.Button();
            this.BtnCancelarV = new System.Windows.Forms.Button();
            this.NUpDownPeriodo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreV
            // 
            this.LblNombreV.AutoSize = true;
            this.LblNombreV.Location = new System.Drawing.Point(58, 89);
            this.LblNombreV.Name = "LblNombreV";
            this.LblNombreV.Size = new System.Drawing.Size(54, 15);
            this.LblNombreV.TabIndex = 0;
            this.LblNombreV.Text = "Nombre:";
            // 
            // LblPeriodoDeAplicacion
            // 
            this.LblPeriodoDeAplicacion.AutoSize = true;
            this.LblPeriodoDeAplicacion.Location = new System.Drawing.Point(58, 129);
            this.LblPeriodoDeAplicacion.Name = "LblPeriodoDeAplicacion";
            this.LblPeriodoDeAplicacion.Size = new System.Drawing.Size(129, 15);
            this.LblPeriodoDeAplicacion.TabIndex = 0;
            this.LblPeriodoDeAplicacion.Text = "Periodo de Aplicacion: ";
            // 
            // LblBeneficios
            // 
            this.LblBeneficios.AutoSize = true;
            this.LblBeneficios.Location = new System.Drawing.Point(58, 171);
            this.LblBeneficios.Name = "LblBeneficios";
            this.LblBeneficios.Size = new System.Drawing.Size(67, 15);
            this.LblBeneficios.TabIndex = 0;
            this.LblBeneficios.Text = "Beneficios: ";
            // 
            // TxtNombreV
            // 
            this.TxtNombreV.Location = new System.Drawing.Point(211, 89);
            this.TxtNombreV.Name = "TxtNombreV";
            this.TxtNombreV.Size = new System.Drawing.Size(249, 23);
            this.TxtNombreV.TabIndex = 0;
            // 
            // TxtBeneficios
            // 
            this.TxtBeneficios.Location = new System.Drawing.Point(211, 168);
            this.TxtBeneficios.Name = "TxtBeneficios";
            this.TxtBeneficios.Size = new System.Drawing.Size(249, 23);
            this.TxtBeneficios.TabIndex = 2;
            // 
            // BtnGuardarV
            // 
            this.BtnGuardarV.Location = new System.Drawing.Point(49, 248);
            this.BtnGuardarV.Name = "BtnGuardarV";
            this.BtnGuardarV.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarV.TabIndex = 4;
            this.BtnGuardarV.Text = "Guardar";
            this.BtnGuardarV.UseVisualStyleBackColor = true;
            this.BtnGuardarV.Click += new System.EventHandler(this.BtnGuardarV_Click);
            // 
            // BtnCancelarV
            // 
            this.BtnCancelarV.Location = new System.Drawing.Point(179, 248);
            this.BtnCancelarV.Name = "BtnCancelarV";
            this.BtnCancelarV.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarV.TabIndex = 5;
            this.BtnCancelarV.Text = "Cancelar";
            this.BtnCancelarV.UseVisualStyleBackColor = true;
            this.BtnCancelarV.Click += new System.EventHandler(this.BtnCancelarV_Click);
            // 
            // NUpDownPeriodo
            // 
            this.NUpDownPeriodo.Location = new System.Drawing.Point(211, 127);
            this.NUpDownPeriodo.Name = "NUpDownPeriodo";
            this.NUpDownPeriodo.Size = new System.Drawing.Size(120, 23);
            this.NUpDownPeriodo.TabIndex = 6;
            // 
            // FrmNuevoEditarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 349);
            this.Controls.Add(this.NUpDownPeriodo);
            this.Controls.Add(this.BtnCancelarV);
            this.Controls.Add(this.BtnGuardarV);
            this.Controls.Add(this.TxtBeneficios);
            this.Controls.Add(this.TxtNombreV);
            this.Controls.Add(this.LblBeneficios);
            this.Controls.Add(this.LblPeriodoDeAplicacion);
            this.Controls.Add(this.LblNombreV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoEditarVacuna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva / Editar Vacuna";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombreV;
        private System.Windows.Forms.Label LblPeriodoDeAplicacion;
        private System.Windows.Forms.Label LblBeneficios;
        private System.Windows.Forms.TextBox TxtNombreV;
        private System.Windows.Forms.TextBox TxtBeneficios;
        private System.Windows.Forms.Button BtnGuardarV;
        private System.Windows.Forms.Button BtnCancelarV;
        private System.Windows.Forms.NumericUpDown NUpDownPeriodo;
    }
}