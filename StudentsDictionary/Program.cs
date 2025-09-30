using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diccionario de alumnos y calificaciones
            Dictionary<string, int> calificaciones = new Dictionary<string, int>
            {
                { "Omar", 50 },
                { "Edgar", 72 },
                { "Miguel", 98 },
                { "Sara", 100 },
                { "Sofia", 88 }
            };

            //Filtrar alumnos aprobados
            var aprobados = calificaciones.Where(a => a.Value >= 70).OrderByDescending(a => a.Value);


            Console.WriteLine("Alumnos aprobados:");
            foreach (var alumno in aprobados)
            {
                Console.WriteLine($"{alumno.Key}: {alumno.Value}");
            }
        }
    }
}
