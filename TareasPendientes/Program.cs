using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasPendientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tareas tareas = new Tareas();
            int option = 0;
            String input;

            do
            {
                Console.WriteLine("¿Qué opción quieres hacer?");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar lista de tarea");
                Console.WriteLine("3. Agrega una tarea al inicio");
                Console.WriteLine("4. Agrega una tarea al final");
                Console.WriteLine("5. Elimina una tarea al inicio");
                Console.WriteLine("6. Finaliza");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese la tarea:");
                        input = Console.ReadLine();
                        tareas.AgregarTarea(input);
                        break;
                    case 2:
                        tareas.showTareas();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la tarea:");
                        input = Console.ReadLine();
                        tareas.addFirstTareas(input);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la tarea:");
                        input = Console.ReadLine();
                        tareas.addLastTareas(input);
                        break;
                    case 5:
                        tareas.removeFirstTareas();
                        break;
                }

                option = 0;
            } while (option != 6);
        }
    }
    
}
