﻿namespace VacunDesktop.Presentation
{
    partial class FrmNuevoEditarPaciente
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudDni = new System.Windows.Forms.NumericUpDown();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CboTutor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboCalendario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NudPeso = new System.Windows.Forms.NumericUpDown();
            this.ChkPrematuro = new System.Windows.Forms.CheckBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(334, 54);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(181, 23);
            this.TxtApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(334, 17);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(181, 23);
            this.TxtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // NudDni
            // 
            this.NudDni.Location = new System.Drawing.Point(334, 134);
            this.NudDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NudDni.Name = "NudDni";
            this.NudDni.Size = new System.Drawing.Size(181, 23);
            this.NudDni.TabIndex = 2;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(333, 210);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(182, 23);
            this.DtpFechaNacimiento.TabIndex = 3;
            // 
            // CboTutor
            // 
            this.CboTutor.FormattingEnabled = true;
            this.CboTutor.Location = new System.Drawing.Point(333, 322);
            this.CboTutor.Name = "CboTutor";
            this.CboTutor.Size = new System.Drawing.Size(182, 23);
            this.CboTutor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tutor:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(333, 404);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(439, 404);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(333, 177);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(181, 23);
            this.CboSexo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sexo:";
            // 
            // CboCalendario
            // 
            this.CboCalendario.FormattingEnabled = true;
            this.CboCalendario.Location = new System.Drawing.Point(334, 360);
            this.CboCalendario.Name = "CboCalendario";
            this.CboCalendario.Size = new System.Drawing.Size(182, 23);
            this.CboCalendario.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Calendario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Peso:";
            // 
            // NudPeso
            // 
            this.NudPeso.DecimalPlaces = 3;
            this.NudPeso.Location = new System.Drawing.Point(333, 259);
            this.NudPeso.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudPeso.Name = "NudPeso";
            this.NudPeso.Size = new System.Drawing.Size(181, 23);
            this.NudPeso.TabIndex = 2;
            // 
            // ChkPrematuro
            // 
            this.ChkPrematuro.AutoSize = true;
            this.ChkPrematuro.Location = new System.Drawing.Point(334, 297);
            this.ChkPrematuro.Name = "ChkPrematuro";
            this.ChkPrematuro.Size = new System.Drawing.Size(82, 19);
            this.ChkPrematuro.TabIndex = 6;
            this.ChkPrematuro.Text = "Prematuro";
            this.ChkPrematuro.UseVisualStyleBackColor = true;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(333, 90);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(181, 23);
            this.TxtDomicilio.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Domicilio:";
            // 
            // FrmNuevoEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.ChkPrematuro);
            this.Controls.Add(this.NudPeso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboCalendario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CboTutor);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.NudDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Name = "FrmNuevoEditarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoEditarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudDni;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.ComboBox CboTutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboCalendario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudPeso;
        private System.Windows.Forms.CheckBox ChkPrematuro;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label9;
    }
}