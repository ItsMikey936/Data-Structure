using System;
using System.Windows.Forms;

namespace TorresDeHanoiVisual
{
    static class Program
    {
        [STAThread] // Indica que el hilo principal usa el modelo de subprocesamiento STA (Single Thread Apartment), necesario para Windows Forms.
        static void Main()
        {
            Application.EnableVisualStyles(); // Mejora la apariencia visual de los controles.
            Application.SetCompatibleTextRenderingDefault(false); // Usa el motor de renderizado GDI+ en lugar de GDI clásico.
            Application.Run(new Form1()); // Inicia la aplicación con el formulario principal.
        }
    }
}
