using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroes = RepositorioHeroes.ObtenerHeroes();

            Console.WriteLine("1️ Héroes con nivel > 10:");
            foreach (var h in ProcesadorHeroes.FiltrarPorNivel(heroes, 10))
                Console.WriteLine(h);

            Console.WriteLine("\n2️ Ordenados por poder descendente:");
            foreach (var h in ProcesadorHeroes.OrdenarPorPoderDescendente(heroes))
                Console.WriteLine(h);

            Console.WriteLine("\n3️ Nombres de los magos:");
            foreach (var nombre in ProcesadorHeroes.ObtenerNombresMagos(heroes))
                Console.WriteLine(nombre);

            Console.WriteLine("\n4️ Agrupación por clase:");
            foreach (var grupo in ProcesadorHeroes.AgruparPorClase(heroes))
                Console.WriteLine($"{grupo.Clase}: {grupo.Cantidad}");

            Console.WriteLine("\n5️ ¿Existe héroe con poder > 90?");
            Console.WriteLine(ProcesadorHeroes.ExisteHeroePoderoso(heroes, 90) ? " Sí" : " No");

        }
    }
}
