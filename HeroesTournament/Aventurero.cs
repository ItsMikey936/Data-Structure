using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class Aventurero
    {
        public string Nombre { get; set; }
        public string Clase { get; set; } // Guerrero, Mago, Arquero
        public int Nivel { get; set; }
        public int PuntosVictoria { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({Clase}) - Nivel {Nivel}, {PuntosVictoria} puntos";
        }

    }
}
