using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registro = new Registro();

            Console.WriteLine(" Filtrar nivel > 10:");
            foreach (var a in ConsultasLINQ.FiltrarNivelAlto(registro.Inscritos))
                Console.WriteLine(a);

            Console.WriteLine("\n Ordenar por puntos:");
            foreach (var a in ConsultasLINQ.OrdenarPorPuntos(registro.Inscritos))
                Console.WriteLine(a);

            Console.WriteLine("\n Agrupar por clase:");
            ConsultasLINQ.AgruparPorClase(registro.Inscritos);

            Console.WriteLine("\n Cola de inscripción:");
            var cola = new ColaInscripcion();
            cola.Encolar(registro.Inscritos);
            cola.Atender();

            Console.WriteLine("\n Historial de batallas:");
            var historial = new HistorialBatallas();
            historial.Registrar("Thorin venció a un dragón");
            historial.Registrar("Lira ganó el torneo de arquería");
            historial.Registrar("Zara derrotó a un elemental de fuego");
            historial.MostrarHistorial();

            Console.WriteLine("\n Diccionario de puntos:");
            var diccionario = DiccionarioPuntos.CrearDiccionario(registro.Inscritos);
            DiccionarioPuntos.Mostrar(diccionario);

            Console.WriteLine("\n ¿Hay un campeón con más de 100 puntos?");
            Console.WriteLine(ConsultasLINQ.ExisteCampeon(registro.Inscritos) ? "¡Sí hay campeón!" : "No hay campeón aún.");

        }
    }
}
