using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    
    public partial class Form1 : Form
    {
        Graphics juego;
        pacman pac;
        Rojo rojo;
        Rosa rosa;
        Guinda cherry;
        Uva uva;
        int cuadro = 10, puntos = 0;
        int xdir=0, ydir = 0;
        Boolean ejex = true, ejey = true;
        public Form1()
        {
            int cuadro = 10;
            InitializeComponent();
            juego = pictureJuego.CreateGraphics();
            pac = new pacman(440, 240);
            cherry = new Guinda(10,10);
            uva = new Uva(100, 100);
            rojo = new Rojo(10, 10);
            rosa = new Rosa(400, 300);
            //Bitmap cherry = (Bitmap)Image.FromFile(@"C:\Users\naxol\Desktop\examen-naxolorca\cherry.png", true);
            //Graphics flagGraphics = Graphics.FromImage(cherry);
            ////Bitmap uva = new Bitmap("tile114.png");
           
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        public void movimiento()
        {
            pac.mover(pac.getX() + xdir, pac.getY() + ydir);
            rojo.seguir(pac.x, pac.y);
            rosa.seguir(pac.x, pac.y);
            puntaje.Text = Convert.ToString(puntos);

        }

        private void ciclo_Tick(object sender, EventArgs e)
        {
        
            juego.Clear(Color.White);
            pac.dibujar(juego);
            rojo.dibujar(juego);
            rosa.dibujar(juego);
            uva.dibujar(juego);
            cherry.dibujar(juego);
            movimiento();


            if (pac.choque(cherry))
            {
                puntos = puntos + 10;
                cherry.colocar();
            }

            if (pac.choque(uva))
            {
                puntos = puntos + 15;
                uva.colocar();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ydir = -cuadro;
                xdir = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                ydir = cuadro;
                xdir = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                ydir = 0;
                xdir = cuadro;
            }
            if (e.KeyCode == Keys.Left)
            {
                ydir = 0;
                xdir = -cuadro;
            }

        }
    }
}
