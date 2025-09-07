using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Names names = new Names();
            int option = 0;

            do
            {
                Console.WriteLine("¿Qué opción quieres hacer?");
                Console.WriteLine("1. Agregar nombre");
                Console.WriteLine("2. Ordenar lista de nombres");
                Console.WriteLine("3. Mostrar lista de nombres");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        String input = Console.ReadLine();
                        names.addName(input);
                        break;
                    case 2:
                        names.sortList();
                        break;
                    case 3:
                        names.showNames();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                option = 0;
            } while (option != 4);
        }
    }
}
