using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    [Serializable]
    class Uva:objeto
    {
        public Uva(int x, int y)
        {
            this.x = -10;
            this.y = -10;

        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.LightGreen), this.x, this.y, this.ancho, this.ancho);

        }

        public void colocar()
        {
            this.x = generar(87);
            this.y = generar(47);
        }

        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
