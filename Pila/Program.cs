using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejecución 1: Contenedor de enteros
            var contenedor = new Contenedor<int>();
            contenedor.Agregar(5);
            contenedor.Agregar(10);
            contenedor.Agregar(3);
            contenedor.MostrarTodos();

            int mayores = Utilidades.ContarMayoresQue(contenedor.ObtenerElementos(), 4);
            Console.WriteLine($"Cantidad de elementos mayores que 4: {mayores}");

            // Ejecución 2: Pila de cadenas
            var pila = new Pila<string>();
            pila.Apilar("Manzana");
            pila.Apilar("Banana");
            pila.VerTope();
            pila.Desapilar();
            pila.VerTope();

            // Ejecución 3: Contenedor de decimales
            var contenedorDecimales = new Contenedor<decimal>();
            contenedorDecimales.Agregar(2.5m);
            contenedorDecimales.Agregar(7.8m);
            contenedorDecimales.Agregar(1.2m);
            contenedorDecimales.MostrarTodos();

            int mayoresDecimales = Utilidades.ContarMayoresQue(contenedorDecimales.ObtenerElementos(), 2.0m);
            Console.WriteLine($"Cantidad de decimales mayores que 2.0: {mayoresDecimales}");

        }
    }
}
