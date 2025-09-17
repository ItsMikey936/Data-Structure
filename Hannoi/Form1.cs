using Hannoi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi
{
    public partial class Form1 : Form
    {
        List<Torre> torres;
        Hanoi hanoi;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numDiscos.Value;
            torres = new List<Torre>
            {
                new Torre(100),
                new Torre(250),
                new Torre(400)
            };

            for (int i = cantidad; i >= 1; i--)
                torres[0].Apilar(new Disco(i));

            hanoi = new Hanoi(torres, () => panelTorres.Invalidate());
            await hanoi.Resolver(cantidad, 0, 2, 1);
        }

        private void panelTorres_Paint(object sender, PaintEventArgs e)
        {
            int baseY = panelTorres.Height - 50;
            if (torres != null)
                foreach (var torre in torres)
                    torre.Dibujar(e.Graphics, baseY);
        }
    }
}
