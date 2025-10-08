using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Contenedor<T>
    {
        private List<T> elementos = new List<T>();

        public void Agregar(T item)
        {
            elementos.Add(item);
        }

        public void MostrarTodos()
        {
            Console.WriteLine("Elementos en el contenedor:");
            foreach (var item in elementos)
            {
                Console.WriteLine($"- {item}");
            }
        }

        public List<T> ObtenerElementos()
        {
            return elementos;
        }

    }
}
