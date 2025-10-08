using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Pila<T>
    {
        private Stack<T> pila = new Stack<T>();

        public void Apilar(T item)
        {
            pila.Push(item);
            Console.WriteLine($"Apilado: {item}");
        }

        public T Desapilar()
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
                return default(T);
            }

            T item = pila.Pop();
            Console.WriteLine($"Desapilado: {item}");
            return item;
        }

        public T VerTope()
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
                return default(T);
            }

            T item = pila.Peek();
            Console.WriteLine($"Elemento en el tope: {item}");
            return item;
        }

    }
}
