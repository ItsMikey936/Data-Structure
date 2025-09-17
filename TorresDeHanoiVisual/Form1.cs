using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresDeHanoiVisual
{
    public partial class Form1 : Form
    {
        List<Torre> torres; // Lista de torres (A, B, C)
        Hanoi hanoi;         // Instancia del algoritmo de resolución

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes visuales
            this.DoubleBuffered = true; // Evita parpadeo al dibujar gráficos
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numDiscos.Value; // Obtiene el número de discos del control

            txtPasos.Clear(); // Limpia el historial de pasos
            panelTorres.Invalidate(); // Limpia el panel gráfico

            // Crea las tres torres con sus posiciones X
            torres = new List<Torre>
            {
                new Torre(100), // Torre A
                new Torre(250), // Torre B
                new Torre(400)  // Torre C
            };

            // Apila los discos en la torre A (de mayor a menor)
            for (int i = cantidad; i >= 1; i--)
                torres[0].Apilar(new Disco(i));

            // Crea la instancia del algoritmo y pasa el método para refrescar la UI
            hanoi = new Hanoi(torres, () => panelTorres.Invalidate());

            // Ejecuta la resolución recursiva con animación
            await hanoi.Resolver(cantidad, 0, 2, 1); // A → C usando B

            // Calcula y muestra el número mínimo de movimientos
            int movimientos = (int)Math.Pow(2, cantidad) - 1;
            txtPasos.AppendText($"Número mínimo de movimientos: {movimientos}\r\n\r\n");

            // Muestra los pasos realizados
            foreach (var paso in hanoi.Pasos)
                txtPasos.AppendText(paso + "\r\n");
        }

        private void panelTorres_Paint(object sender, PaintEventArgs e)
        {
            int baseY = panelTorres.Height - 50; // Posición base para dibujar torres
            if (torres != null)
                foreach (var torre in torres)
                    torre.Dibujar(e.Graphics, baseY); // Dibuja cada torre y sus discos
        }
    }
}
