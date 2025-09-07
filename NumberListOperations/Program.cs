using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Ingresa 10 números enteros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intenta de nuevo.");
                    i--; // Repetir esta iteración
                }
            }

            int sumaTotal = numeros.Sum();
            int numeroMayor = numeros.Max();

            Console.WriteLine($"\nSuma total: {sumaTotal}");
            Console.WriteLine($"Número mayor: {numeroMayor}");

            Console.Write("\nIngresa un número extra para verificar si está en la lista: ");
            if (int.TryParse(Console.ReadLine(), out int extra))
            {
                if (numeros.Contains(extra))
                {
                    Console.WriteLine("El número está en la lista.");
                }
                else
                {
                    Console.WriteLine("El número NO está en la lista.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}
