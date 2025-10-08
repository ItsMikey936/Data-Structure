using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLINQ
{
    internal class Heroe
    {
        public string Nombre { get; set; }
        public string Clase { get; set; } 
        public int Nivel { get; set; }
        public int Poder { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - Clase: {Clase}, Nivel: {Nivel}, Poder: {Poder}";
        }

    }
}
