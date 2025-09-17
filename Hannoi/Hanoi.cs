using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    public class Hanoi
    {
        public List<Torre> Torres;
        public Action RefrescarUI;

        public Hanoi(List<Torre> torres, Action refrescarUI)
        {
            Torres = torres;
            RefrescarUI = refrescarUI;
        }

        public async Task Resolver(int n, int origen, int destino, int auxiliar)
        {
            if (n > 0)
            {
                await Resolver(n - 1, origen, auxiliar, destino);
                MoverDisco(origen, destino);
                RefrescarUI();
                await Task.Delay(500);
                await Resolver(n - 1, auxiliar, destino, origen);
            }
        }

        private void MoverDisco(int origen, int destino)
        {
            var disco = Torres[origen].Desapilar();
            Torres[destino].Apilar(disco);
        }
    }
}
