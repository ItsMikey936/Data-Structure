using System;
using System.Windows.Forms;

namespace TorresDeHanoiVisual
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnIniciar;
        private NumericUpDown numDiscos;
        private Panel panelTorres;
        private TextBox txtPasos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Botón para iniciar la simulación
            this.btnIniciar = new Button();
            this.btnIniciar.Location = new System.Drawing.Point(20, 20);
            this.btnIniciar.Size = new System.Drawing.Size(100, 30);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new EventHandler(this.btnIniciar_Click);

            // Selector de número de discos
            this.numDiscos = new NumericUpDown();
            this.numDiscos.Location = new System.Drawing.Point(140, 25);
            this.numDiscos.Minimum = 1;
            this.numDiscos.Maximum = 10;
            this.numDiscos.Value = 3;

            // Panel donde se dibujan las torres y discos
            this.panelTorres = new Panel();
            this.panelTorres.Location = new System.Drawing.Point(20, 70);
            this.panelTorres.Size = new System.Drawing.Size(500, 300);
            this.panelTorres.Paint += new PaintEventHandler(this.panelTorres_Paint);

            // TextBox para mostrar los pasos en texto
            this.txtPasos = new TextBox();
            this.txtPasos.Location = new System.Drawing.Point(530, 70);
            this.txtPasos.Size = new System.Drawing.Size(300, 300);
            this.txtPasos.Multiline = true;
            this.txtPasos.ScrollBars = ScrollBars.Vertical;
            this.txtPasos.ReadOnly = true;

            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.numDiscos);
            this.Controls.Add(this.panelTorres);
            this.Controls.Add(this.txtPasos);
            this.Text = "Torres de Hanoi Visual";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
