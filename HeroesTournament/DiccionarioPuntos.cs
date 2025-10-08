using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class DiccionarioPuntos
    {
        public static Dictionary<string, int> CrearDiccionario(List<Aventurero> lista)
        {
            return lista.ToDictionary(a => a.Nombre, a => a.PuntosVictoria);
        }

        public static void Mostrar(Dictionary<string, int> diccionario)
        {
            foreach (var kvp in diccionario)
                Console.WriteLine($"{kvp.Key}: {kvp.Value} puntos");
        }

    }
}
