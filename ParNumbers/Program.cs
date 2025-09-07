using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int op = 1;

            while (op != 2)
            {
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }

                Console.WriteLine("¿Desea ingresar otro número? (1: Sí, 2: No)");
                op = int.Parse(Console.ReadLine());
            }

        }
    }
}
