using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen<string> almacenTexto = new Almacen<string>("¡Hola!");

            // Mostrar el valor guardado
            almacenTexto.MostrarElemento();

        }
    }
}
