using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Filtrar números pares usando LINQ
            var pares = numeros.Where(n => n % 2 == 0);

            //Proyectar al cuadrado
            var cuadrados = numeros.Select(n => n * n);

            //Ordenar números descendente
            var ordenadosDesc = numeros.OrderByDescending(n => n);

            //Contar mayores a 3
            int conteo = numeros.Count(n => n > 3);

            Console.WriteLine("Números pares: " + string.Join(", ", pares));
            Console.WriteLine("Cuadrados: " + string.Join(", ", cuadrados));
            Console.WriteLine("Ordenados: " + string.Join(", ", ordenadosDesc));
            Console.WriteLine("Conteo mayores a 3: " + conteo);
        }
    }
}
