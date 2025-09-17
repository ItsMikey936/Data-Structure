using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    public class Torre
    {
        public Stack<Disco> Discos { get; private set; } = new Stack<Disco>();
        public int PosX { get; set; }

        public Torre(int x)
        {
            PosX = x;
        }

        public void Apilar(Disco d) => Discos.Push(d);
        public Disco Desapilar() => Discos.Pop();

        public void Dibujar(Graphics g, int baseY)
        {
            g.FillRectangle(Brushes.DarkGray, PosX - 5, baseY - 150, 10, 150);

            int y = baseY - 20;
            foreach (var disco in Discos)
            {
                disco.Dibujar(g, PosX, y, 120);
                y -= 22;
            }
        }
    }
}
