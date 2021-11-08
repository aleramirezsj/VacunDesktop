
namespace VacunDesktop.Presentation
{
    partial class FrmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.PbaBarraProgreso = new System.Windows.Forms.ProgressBar();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.TmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "VacunDesktop";
            // 
            // PnlFondo
            // 
            
            this.PnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlFondo.Location = new System.Drawing.Point(13, 62);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(504, 170);
            this.PnlFondo.TabIndex = 1;
            // 
            // PbaBarraProgreso
            // 
            this.PbaBarraProgreso.Location = new System.Drawing.Point(13, 252);
            this.PbaBarraProgreso.Name = "PbaBarraProgreso";
            this.PbaBarraProgreso.Size = new System.Drawing.Size(453, 31);
            this.PbaBarraProgreso.TabIndex = 2;
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.Location = new System.Drawing.Point(472, 268);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(0, 15);
            this.LblPorcentaje.TabIndex = 3;
            // 
            // TmrCronometro
            // 
            this.TmrCronometro.Enabled = true;
            this.TmrCronometro.Interval = 50;
            this.TmrCronometro.Tick += new System.EventHandler(this.TmrCronometro_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 295);
            this.ControlBox = false;
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.PbaBarraProgreso);
            this.Controls.Add(this.PnlFondo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.ProgressBar PbaBarraProgreso;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.Timer TmrCronometro;
    }
}