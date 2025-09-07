using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vocals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa una oración: ");
            string oracion = Console.ReadLine().ToLower();

            int a = 0, e = 0, i = 0, o = 0, u = 0, consonantes = 0;

            foreach (char c in oracion)
            {
                if ("aeiou".Contains(c))
                {
                    switch (c)
                    {
                        case 'a': a++; break;
                        case 'e': e++; break;
                        case 'i': i++; break;
                        case 'o': o++; break;
                        case 'u': u++; break;
                    }
                }
                else if (char.IsLetter(c))
                {
                    consonantes++;
                }
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Vocal 'a': {a}");
            Console.WriteLine($"Vocal 'e': {e}");
            Console.WriteLine($"Vocal 'i': {i}");
            Console.WriteLine($"Vocal 'o': {o}");
            Console.WriteLine($"Vocal 'u': {u}");
            Console.WriteLine($"Consonantes: {consonantes}");
        }
    }
}
