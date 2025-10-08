using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLINQ
{
    internal class ProcesadorHeroes
    {
        public static IEnumerable<Heroe> FiltrarPorNivel(List<Heroe> heroes, int nivelMinimo)
        {
            return heroes.Where(h => h.Nivel > nivelMinimo);
        }

        public static IEnumerable<Heroe> OrdenarPorPoderDescendente(List<Heroe> heroes)
        {
            return heroes.OrderByDescending(h => h.Poder);
        }

        public static IEnumerable<string> ObtenerNombresMagos(List<Heroe> heroes)
        {
            return heroes.Where(h => h.Clase == "Mago").Select(h => h.Nombre);
        }

        public static IEnumerable<(string Clase, int Cantidad)> AgruparPorClase(List<Heroe> heroes)
        {
            return heroes
                .GroupBy(h => h.Clase)
                .Select(g => (Clase: g.Key, Cantidad: g.Count()));
        }

        public static bool ExisteHeroePoderoso(List<Heroe> heroes, int umbralPoder)
        {
            return heroes.Any(h => h.Poder > umbralPoder);
        }

    }
}
