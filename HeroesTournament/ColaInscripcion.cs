using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class ColaInscripcion
    {
        private Queue<Aventurero> cola = new Queue<Aventurero>();

        public void Encolar(List<Aventurero> lista)
        {
            foreach (var a in lista)
                cola.Enqueue(a);
        }

        public void Atender()
        {
            while (cola.Count > 0)
            {
                var siguiente = cola.Dequeue();
                Console.WriteLine($"Atendiendo a {siguiente.Nombre}");
            }
        }

    }
}
