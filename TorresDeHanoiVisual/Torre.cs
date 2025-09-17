using System.Collections.Generic;
using System.Drawing;

namespace TorresDeHanoiVisual
{
    public class Torre
    {
        public Stack<Disco> Discos { get; private set; } = new Stack<Disco>(); // Pila de discos
        public int PosX { get; set; } // Posición horizontal en el panel

        public Torre(int x)
        {
            PosX = x;
        }

        public void Apilar(Disco d) => Discos.Push(d); // Agrega disco
        public Disco Desapilar() => Discos.Pop();      // Quita disco

        public void Dibujar(Graphics g, int baseY)
        {
            // Dibuja el poste de la torre
            g.FillRectangle(Brushes.DarkGray, PosX - 5, baseY - 150, 10, 150);

            // Dibuja los discos apilados
            int y = baseY - 20;
            foreach (var disco in Discos)
            {
                disco.Dibujar(g, PosX, y, 120);
                y -= 22;
            }
        }
    }
}
