using System;
using System.Collections.Generic;

namespace Biblioteca
{
    // Clase principal que gestiona la lógica de la biblioteca
    internal class Biblioteca
    {
        // Lista de libros disponibles
        private List<string> libros = new List<string>();

        // Cola para registrar los préstamos (FIFO)
        private Queue<string> prestamos = new Queue<string>();

        // Pila para registrar las devoluciones (LIFO)
        private Stack<string> devoluciones = new Stack<string>();

        // Diccionario que asocia ID de usuario con su nombre
        private Dictionary<int, string> usuarios = new Dictionary<int, string>();

        // Método principal que ejecuta el menú interactivo
        public void Ejecutar()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menú Biblioteca ===");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Registrar usuario");
                Console.WriteLine("4. Prestar libro");
                Console.WriteLine("5. Registrar devolución");
                Console.WriteLine("6. Mostrar usuarios");
                Console.WriteLine("7. Mostrar préstamos y devoluciones");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();

                // Validación de entrada numérica
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    opcion = -1;
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();
                // Ejecución de la opción seleccionada
                switch (opcion)
                {
                    case 1: AgregarLibro(); break;
                    case 2: MostrarLibros(); break;
                    case 3: RegistrarUsuario(); break;
                    case 4: PrestarLibro(); break;
                    case 5: RegistrarDevolucion(); break;
                    case 6: MostrarUsuarios(); break;
                    case 7: MostrarPrestamosYDevoluciones(); break;
                    case 0: Console.WriteLine("Saliendo del sistema..."); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }

        // Agrega un libro a la lista si el título es válido
        private void AgregarLibro()
        {
            Console.Write("Ingrese el título del libro: ");
            string libro = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(libro))
            {
                libros.Add(libro);
                Console.WriteLine(" Libro agregado correctamente.");
            }
            else
            {
                Console.WriteLine(" Título inválido.");
            }
        }

        // Muestra todos los libros registrados
        private void MostrarLibros()
        {
            Console.WriteLine(" Lista de libros:");
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
            }
            else
            {
                foreach (var libro in libros)
                    Console.WriteLine($"- {libro}");
            }
        }

        // Registra un usuario con ID y nombre
        private void RegistrarUsuario()
        {
            Console.Write("Ingrese el ID del usuario: ");
            string entradaId = Console.ReadLine();
            if (int.TryParse(entradaId, out int id))
            {
                Console.Write("Ingrese el nombre del usuario: ");
                string nombre = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(nombre))
                {
                    usuarios[id] = nombre;
                    Console.WriteLine(" Usuario registrado correctamente.");
                }
                else
                {
                    Console.WriteLine(" Nombre inválido.");
                }
            }
            else
            {
                Console.WriteLine(" ID inválido.");
            }
        }

        // Agrega un libro a la cola de préstamos
        private void PrestarLibro()
        {
            Console.Write("Ingrese el título del libro a prestar: ");
            string libro = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(libro))
            {
                prestamos.Enqueue(libro);
                Console.WriteLine(" Libro agregado a la cola de préstamos.");
            }
            else
            {
                Console.WriteLine(" Título inválido.");
            }
        }

        // Registra un libro devuelto en la pila de devoluciones
        private void RegistrarDevolucion()
        {
            Console.Write("Ingrese el título del libro devuelto: ");
            string libro = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(libro))
            {
                devoluciones.Push(libro);
                Console.WriteLine(" Libro registrado en la pila de devoluciones.");
            }
            else
            {
                Console.WriteLine(" Título inválido.");
            }
        }

        // Muestra todos los usuarios registrados
        private void MostrarUsuarios()
        {
            Console.WriteLine(" Usuarios registrados:");
            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
            }
            else
            {
                foreach (var usuario in usuarios)
                    Console.WriteLine($"ID: {usuario.Key}, Nombre: {usuario.Value}");
            }
        }

        // Muestra los libros prestados y devueltos
        private void MostrarPrestamosYDevoluciones()
        {
            Console.WriteLine(" Cola de préstamos:");
            if (prestamos.Count == 0)
            {
                Console.WriteLine("No hay préstamos registrados.");
            }
            else
            {
                foreach (var libro in prestamos)
                    Console.WriteLine($"- {libro}");
            }

            Console.WriteLine("\n Pila de devoluciones:");
            if (devoluciones.Count == 0)
            {
                Console.WriteLine("No hay devoluciones registradas.");
            }
            else
            {
                foreach (var libro in devoluciones)
                    Console.WriteLine($"- {libro}");
            }
        }
    }

    // Clase de entrada al programa
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia del sistema de biblioteca y ejecución del menú
            Biblioteca sistema = new Biblioteca();
            sistema.Ejecutar();
        }
    }
}