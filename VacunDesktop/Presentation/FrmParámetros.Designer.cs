
namespace VacunDesktop.Presentation
{
    partial class FrmParámetros
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
            this.TxtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBbdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BtnGuardarModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtServidor
            // 
            this.TxtServidor.Enabled = false;
            this.TxtServidor.Location = new System.Drawing.Point(113, 25);
            this.TxtServidor.Name = "TxtServidor";
            this.TxtServidor.Size = new System.Drawing.Size(172, 23);
            this.TxtServidor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de datos:";
            // 
            // TxtBbdd
            // 
            this.TxtBbdd.Enabled = false;
            this.TxtBbdd.Location = new System.Drawing.Point(113, 72);
            this.TxtBbdd.Name = "TxtBbdd";
            this.TxtBbdd.Size = new System.Drawing.Size(172, 23);
            this.TxtBbdd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Location = new System.Drawing.Point(113, 118);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(172, 23);
            this.TxtUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Enabled = false;
            this.TxtContraseña.Location = new System.Drawing.Point(113, 165);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(172, 23);
            this.TxtContraseña.TabIndex = 6;
            // 
            // BtnGuardarModificar
            // 
            this.BtnGuardarModificar.Location = new System.Drawing.Point(156, 365);
            this.BtnGuardarModificar.Name = "BtnGuardarModificar";
            this.BtnGuardarModificar.Size = new System.Drawing.Size(86, 26);
            this.BtnGuardarModificar.TabIndex = 8;
            this.BtnGuardarModificar.Text = "Modificar";
            this.BtnGuardarModificar.UseVisualStyleBackColor = true;
            this.BtnGuardarModificar.Click += new System.EventHandler(this.BtnGuardarModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imagen:";
            // 
            // TxtImagen
            // 
            this.TxtImagen.Enabled = false;
            this.TxtImagen.Location = new System.Drawing.Point(113, 209);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(172, 23);
            this.TxtImagen.TabIndex = 10;
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Enabled = false;
            this.BtnExaminar.Location = new System.Drawing.Point(302, 209);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(69, 26);
            this.BtnExaminar.TabIndex = 11;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(113, 238);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(172, 121);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagen.TabIndex = 12;
            this.PbxImagen.TabStop = false;
            // 
            // FrmParámetros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 403);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnGuardarModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBbdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtServidor);
            this.Name = "FrmParámetros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros de configuración del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBbdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BtnGuardarModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.PictureBox PbxImagen;
    }
}