using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    public class Cola
    {
        Queue<string> cola = new Queue<string>();

        public void addCliente(string cliente)
        {
            cola.Enqueue(cliente);
            Console.WriteLine($"Cliente {cliente} agregado a la cola.");
        }
    }
}
