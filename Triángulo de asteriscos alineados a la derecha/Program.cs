using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulo_de_asteriscos_alineados_a_la_derecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String asteriscos = "*";
            int n = 0;
            Console.Write("Ingrese la cantidad de filas: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(asteriscos.PadLeft(n));
                asteriscos += "*";
            }
        }
    }
}
