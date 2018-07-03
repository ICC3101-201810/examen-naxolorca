using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    [Serializable]
    public class pacman:objeto
    {
        public pacman(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public int getX()
        {

            return this.x;
        }
        public int getY()
        {
            return this.y;
        }


        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Yellow), this.x, this.y, this.ancho, this.ancho);

        }
        public void mover(int x, int y)
        {
            this.x = x;
            this.y = y;        
        }

    }
}
