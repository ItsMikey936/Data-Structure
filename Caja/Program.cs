using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prueba con tipo string
            Caja<string> cajaTexto = new Caja<string>("¡Heeeey muy buenass!");
            cajaTexto.MostrarContenido();

            // Prueba con tipo int
            Caja<int> cajaNumero = new Caja<int>(2025);
            cajaNumero.MostrarContenido();

        }
    }
}
