using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class ConsultasLINQ
    {
        public static IEnumerable<Aventurero> FiltrarNivelAlto(List<Aventurero> lista) =>
        lista.Where(a => a.Nivel > 10);

        public static IEnumerable<Aventurero> OrdenarPorPuntos(List<Aventurero> lista) =>
            lista.OrderByDescending(a => a.PuntosVictoria);

        public static void AgruparPorClase(List<Aventurero> lista)
        {
            var grupos = lista.GroupBy(a => a.Clase);
            foreach (var grupo in grupos)
                Console.WriteLine($"{grupo.Key}: {grupo.Count()} inscritos");
        }

        public static bool ExisteCampeon(List<Aventurero> lista) =>
            lista.Any(a => a.PuntosVictoria > 100);

    }
}
