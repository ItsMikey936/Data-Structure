using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiantes> estudiantes = new List<Estudiantes>
            {
                new Estudiantes { nombre = "Omar", edad = 20, calificacion = 70 },
                new Estudiantes { nombre = "Edgar", edad = 22, calificacion = 72 },
                new Estudiantes { nombre = "Miguel", edad = 21, calificacion = 98 },
                new Estudiantes { nombre = "Sara", edad = 23, calificacion = 100 },
                new Estudiantes { nombre = "Sofia", edad = 20, calificacion = 88 }
            };

            ////Filtrar estudiantes aprobados
            //var aprobados = estudiantes.Where(e => e.calificacion >= 70);

            ////Filtrar de mayor a menor calificación
            //var ordenadosDesc = aprobados.OrderByDescending(e => e.calificacion);

            ////Seleccionar solo nombres
            //var nombres = ordenadosDesc.Select(e => e.nombre);

            int op = 0;

            do 
            {
                Console.WriteLine("1. Agregar a un nuevoo estudiante");
                Console.WriteLine("2. Mostrar estudiantes de excelencia");
                Console.WriteLine("3. Mostrar estudiantes buenos");
                Console.WriteLine("4. Mostrar estudiantes regulares");
                Console.WriteLine("5. Mostrar estudiantes reprobados");
                Console.WriteLine("6. Salir");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Ingrese el nombre del estudiante:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese la edad del estudiante:");
                        int edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la calificación del estudiante:");
                        int calificacion = int.Parse(Console.ReadLine());
                        estudiantes.Add(new Estudiantes { nombre = nombre, edad = edad, calificacion = calificacion });
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                    break;
                    case 2:
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------");
                            var excelencia = estudiantes.Where(e => e.calificacion >= 90).OrderByDescending(e => e.calificacion).Select(e => e.nombre);
                            Console.WriteLine("Estudiantes de excelencia:");
                            foreach (var estudiante in excelencia)
                            {
                                Console.WriteLine(estudiante);
                            }
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("");
                    break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        var buenos = estudiantes.Where(e => e.calificacion >= 80 && e.calificacion < 90).OrderByDescending(e => e.calificacion).Select(e => e.nombre);
                        Console.WriteLine("Estudiantes buenos:");
                        foreach (var estudiante in buenos)
                        {
                            Console.WriteLine(estudiante);
                        }
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                    break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Estudiantes regulares:");
                        var regulares = estudiantes.Where(e => e.calificacion >= 70 && e.calificacion < 80).OrderByDescending(e => e.calificacion).Select(e => e.nombre);
                        foreach (var estudiante in regulares)
                        {
                            Console.WriteLine(estudiante);
                        }
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                    break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Estudiantes reprobados:");
                        var reprobados = estudiantes.Where(e => e.calificacion < 70).OrderByDescending(e => e.calificacion).Select(e => e.nombre);
                        foreach (var estudiante in reprobados)
                        {
                            Console.WriteLine(estudiante);
                        }
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                    break;

                }

            } while(op != 6);
        }
    }
}
