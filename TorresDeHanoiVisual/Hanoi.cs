using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TorresDeHanoiVisual
{
    public class Hanoi
    {
        public List<Torre> Torres; // Referencia a las torres
        public Action RefrescarUI; // Delegado para refrescar el panel
        public List<string> Pasos { get; private set; } = new List<string>(); // Historial textual de movimientos

        public Hanoi(List<Torre> torres, Action refrescarUI)
        {
            Torres = torres;
            RefrescarUI = refrescarUI;
        }

        // Método recursivo para resolver el problema
        public async Task Resolver(int n, int origen, int destino, int auxiliar)
        {
            if (n > 0)
            {
                await Resolver(n - 1, origen, auxiliar, destino); // Mueve n-1 discos al auxiliar
                MoverDisco(origen, destino); // Mueve el disco n al destino
                RefrescarUI(); // Redibuja el panel
                await Task.Delay(500); // Pausa para animación
                await Resolver(n - 1, auxiliar, destino, origen); // Mueve n-1 discos al destino
            }
        }

        private void MoverDisco(int origen, int destino)
        {
            var disco = Torres[origen].Desapilar(); // Quita disco de torre origen
            Torres[destino].Apilar(disco);          // Lo pone en torre destino
            Pasos.Add($"Mover disco {disco.Tamaño} de {Nombre(origen)} a {Nombre(destino)}"); // Guarda el paso
        }

        private char Nombre(int i)
        {
            if (i == 0) return 'A';
            if (i == 1) return 'B';
            if (i == 2) return 'C';
            return '?';
        }
    }
}
