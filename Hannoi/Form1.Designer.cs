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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnIniciar = new Button();
            this.numDiscos = new NumericUpDown();
            this.panelTorres = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).BeginInit();
            this.SuspendLayout();

            // btnIniciar
            this.btnIniciar.Location = new System.Drawing.Point(20, 20);
            this.btnIniciar.Size = new System.Drawing.Size(100, 30);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new EventHandler(this.btnIniciar_Click);

            // numDiscos
            this.numDiscos.Location = new System.Drawing.Point(140, 25);
            this.numDiscos.Minimum = 1;
            this.numDiscos.Maximum = 10;
            this.numDiscos.Value = 3;

            // panelTorres
            this.panelTorres.Location = new System.Drawing.Point(20, 70);
            this.panelTorres.Size = new System.Drawing.Size(500, 300);
            this.panelTorres.Paint += new PaintEventHandler(this.panelTorres_Paint);

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.numDiscos);
            this.Controls.Add(this.panelTorres);
            this.Text = "Torres de Hanoi Visual";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

