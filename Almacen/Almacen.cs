using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    internal class Almacen<T>
    {
        // Propiedad que guarda un valor de cualquier tipo
        public T Elemento { get; set; }

        // Constructor opcional para inicializar el valor
        public Almacen(T valor)
        {
            Elemento = valor;
        }

        // Método para mostrar el valor en consola
        public void MostrarElemento()
        {
            Console.WriteLine($"Elemento almacenado: {Elemento}");
        }

    }
}
