using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasPendientes
{
    public class Tareas
    {
        LinkedList<string> tareas = new LinkedList<string>();

        public void AgregarTarea(string tarea)
        {
            tareas.AddLast(tarea);
        }

        public void showTareas()
        {
            Console.WriteLine("Tus tareas pendientes son:");
            foreach (var tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
        }

        public void addFirstTareas(string tarea) 
        {
            tareas.AddFirst(tarea);
        }

        public void addLastTareas(string tarea)
        {
            tareas.AddLast(tarea);
        }

        public void removeFirstTareas()
        {
            tareas.RemoveFirst();
            Console.WriteLine("Tarea eliminada");
        }
    }
}
