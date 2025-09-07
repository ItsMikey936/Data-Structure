using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado;
            int option;

            Console.WriteLine("================================================");
            Console.WriteLine("BIENVENIDO A LA CALCULADORA");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIPLICACION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("5. SALIR");
            Console.Write("SELECCIONE UNA OPCION: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("================================================");

            while (option != 5)
            {
                switch(option)
                {
                    case 1: 
                        Console.Write("Ingrese el primer número: ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el egundo número: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + resultado);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el egundo número: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("EL RESULTADO DE LA RESTA ES: " + resultado);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el egundo número: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES: " + resultado);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el egundo número: ");
                        num2 = float.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("EL RESULTADO DE LA DIVISION ES: " + resultado);
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: NO SE PUEDE DIVIDIR ENTRE CERO");
                            Console.WriteLine("");
                        }
                        break;
                }

                Console.WriteLine("================================================");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("5. SALIR");
                Console.Write("SELECCIONE UNA OPCION: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("================================================");

            }
        }
    }
}
