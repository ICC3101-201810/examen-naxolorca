﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    [Serializable]
    public class objeto
    {
        public int x, y, ancho;
        public objeto()
        {
            ancho = 10;
        }

        public Boolean choque(objeto o)
        {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.y);
            if(difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
                {return true;}
            else{return false;}

        }
        public void sacar()
        {
            this.x = -10;
            this.y = -10;
        }
    }
}
