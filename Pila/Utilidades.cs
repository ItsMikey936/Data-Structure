using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Utilidades
    {
        public static int ContarMayoresQue<T>(IEnumerable<T> coleccion, T valor) where T : IComparable<T>
        {
            int contador = 0;
            foreach (var item in coleccion)
            {
                if (item.CompareTo(valor) > 0)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}
