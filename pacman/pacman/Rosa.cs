using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    [Serializable]
    class Rosa:objeto
    {
        public Rosa(int x, int y)
        {
            this.x = 870;
            this.y = 270;

        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Pink), this.x, this.y, this.ancho, this.ancho);

        }

        public void seguir(int x, int y)
        {
            int difx = Math.Abs(this.x - x);
            int dify = Math.Abs(this.y - y);

            if (difx > dify)
            {
                if(this.x - x > 0)
                {
                    this.x = this.x - 8;
                }
                else
                {
                    this.x = this.x + 8;
                }
            }
            else
            {
                if (this.y - y > 0)
                {
                    this.y = this.y - 8;
                }
                else
                {
                    this.y = this.y + 8;
                }
            }

        }


        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
