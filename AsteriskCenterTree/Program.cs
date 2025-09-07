using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskCenterTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero N: ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.Write(new string(' ', N - i));

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número entero válido mayor que cero.");
            }
        }
    }
}
