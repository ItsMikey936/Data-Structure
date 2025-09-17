using System.Drawing;

namespace TorresDeHanoiVisual
{
    public class Disco
    {
        public int Tamaño { get; set; } // Valor del disco (1 = pequeño, n = grande)
        public Color Color { get; set; } // Color visual del disco

        public Disco(int tamaño)
        {
            Tamaño = tamaño;
            // Genera un color dinámico según el tamaño del disco
            Color = Color.FromArgb(100 + tamaño * 15, 50, 200);
        }

        // Dibuja el disco como un rectángulo horizontal
        public void Dibujar(Graphics g, int x, int y, int anchoBase)
        {
            // Calcula el ancho del disco según su tamaño
            int ancho = anchoBase - Tamaño * 10;
            // Dibuja el disco centrado en la posición X
            g.FillRectangle(new SolidBrush(Color), x - ancho / 2, y, ancho, 20);
        }
    }
}
