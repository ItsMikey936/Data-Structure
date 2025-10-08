using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLINQ
{
    internal class RepositorioHeroes
    {
        public static List<Heroe> ObtenerHeroes()
        {
            return new List<Heroe>
        {
            new Heroe { Nombre = "Monarch", Clase = "Guerrero", Nivel = 12, Poder = 85 },
            new Heroe { Nombre = "Kozeroneko", Clase = "Mago", Nivel = 15, Poder = 92 },
            new Heroe { Nombre = "Thrall", Clase = "Chamán", Nivel = 9, Poder = 78 },
            new Heroe { Nombre = "Valeera", Clase = "Pícaro", Nivel = 11, Poder = 88 },
            new Heroe { Nombre = "Medivh", Clase = "Mago", Nivel = 20, Poder = 95 },
            new Heroe { Nombre = "Rexxar", Clase = "Cazador", Nivel = 8, Poder = 70 }
        };
        }

    }
}
