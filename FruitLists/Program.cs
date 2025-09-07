using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            list list = new list();
            int option = 0;

            do
            {
                Console.WriteLine("¿Qué opción quieres hacer?");
                Console.WriteLine("1. Agregar fruta");
                Console.WriteLine("2. Mostrar lista de frutas");
                Console.WriteLine("3. Eliminar fruta");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        String input = Console.ReadLine();
                        list.AddFruit(input);
                        break;
                    case 2:
                        list.ShowList();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la fruta a eliminar:");
                        String op2 = Console.ReadLine();
                        list.deleteFruit(op2);
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
