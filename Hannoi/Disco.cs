using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    public class Disco
    {
        public int Tamaño { get; set; }
        public Color Color { get; set; }

        public Disco(int tamaño)
        {
            Tamaño = tamaño;
            Color = Color.FromArgb(100 + tamaño * 15, 50, 200);
        }

        public void Dibujar(Graphics g, int x, int y, int anchoBase)
        {
            int ancho = anchoBase - Tamaño * 10;
            g.FillRectangle(new SolidBrush(Color), x - ancho / 2, y, ancho, 20);
        }
    }
}
