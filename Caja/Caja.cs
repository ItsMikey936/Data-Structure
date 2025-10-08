using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    internal class Caja<T>
    {
        // Propiedad que almacena el valor
        public T Contenido { get; set; }

        // Constructor que inicializa el contenido
        public Caja(T valor)
        {
            Contenido = valor;
        }

        // Método para mostrar el contenido en consola
        public void MostrarContenido()
        {
            Console.WriteLine($"Contenido de la caja: {Contenido}");
        }

    }
}
