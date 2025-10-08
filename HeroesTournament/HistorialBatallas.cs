using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class HistorialBatallas
    {
        private Stack<string> batallas = new Stack<string>();

        public void Registrar(string descripcion)
        {
            batallas.Push(descripcion);
        }

        public void MostrarHistorial()
        {
            while (batallas.Count > 0)
                Console.WriteLine($"Registro: {batallas.Pop()}");
        }

    }
}
