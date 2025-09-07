using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinealCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear una pila de enteros.
            Stack<int> pila1 = new Stack<int>();
            Stack<int> pila2 = new Stack<int>();
            int input;

            //Agregar elementos a la pila.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inserta números");
                input = int.Parse(Console.ReadLine());
                pila1.Push(input);
            }

            //Ver el último elemento agregado a la pila sin eliminarlo.
            int element = pila1.Peek();
            Console.WriteLine("El elemento en la cima de la pila es: " + element);

            //Eliminar el último elemento agregado a la pila y mostrarlo.
            element = pila1.Pop();
            Console.WriteLine("El elemento extraído de la pila es: " + element);

            //Mostrar el número de elementos en la pila.
            int count = pila1.Count();
            Console.WriteLine("El número de elementos en la pila es: " + count);

            //Verifica que se encuentre un elemento específico en la pila.
            Console.WriteLine("Inserta un número a buscar en la pila");
            int verification = int.Parse(Console.ReadLine());
            
            if (pila1.Contains(verification))
            {
                Console.WriteLine("El número " + verification + " SI se encuentra en la pila");
            }
            else
            {
                Console.WriteLine("El número " + verification + " NO se encuentra en la pila");
            }

            //Convertir la pila en un arreglo.
            int[] arreglo = pila1.ToArray();
            Console.WriteLine("El arreglo contiene los siguientes elementos:");
            foreach (int num in arreglo)
            {
                Console.WriteLine(num);
            }

            //Limpiar la pila.
            pila1.Clear();
            Console.WriteLine("La pila ha sido limpiada. El número de elementos en la pila es: " + pila1.Count());
        }
    }
}
