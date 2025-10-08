using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class Registro
    {
        public List<Aventurero> Inscritos { get; private set; }

        public Registro()
        {
            Inscritos = new List<Aventurero>
        {
            new Aventurero { Nombre = "Thorin", Clase = "Guerrero", Nivel = 12, PuntosVictoria = 80 },
            new Aventurero { Nombre = "Elena", Clase = "Mago", Nivel = 9, PuntosVictoria = 50 },
            new Aventurero { Nombre = "Lira", Clase = "Arquero", Nivel = 15, PuntosVictoria = 120 },
            new Aventurero { Nombre = "Borin", Clase = "Guerrero", Nivel = 8, PuntosVictoria = 30 },
            new Aventurero { Nombre = "Zara", Clase = "Mago", Nivel = 11, PuntosVictoria = 95 }
        };
        }

    }
}
