using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    [Serializable]

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
            cherryesta.Stop();
            uvaesta.Stop();
            //Bitmap cherry = (Bitmap)Image.FromFile(@"C:\Users\naxol\Desktop\examen-naxolorca\cherry.png", true);
            //Graphics flagGraphics = Graphics.FromImage(cherry);
            ////Bitmap uva = new Bitmap("tile114.png");


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void uvanoesta_Tick(object sender, EventArgs e)
        {
            uva.colocar();
            uva.dibujar(juego);
            uvaesta.Start();
            uvanoesta.Stop();

        }

        private void cherrynoesta_Tick(object sender, EventArgs e)
        {
            cherry.colocar();
            cherry.dibujar(juego);
            cherryesta.Start();
            cherrynoesta.Stop();
            

        }

        private void cherryesta_Tick(object sender, EventArgs e)
        {
            cherry.sacar();
            cherrynoesta.Start();
            cherryesta.Stop();
        }

        private void uvaesta_Tick(object sender, EventArgs e)
        {
            uva.sacar();
            uvanoesta.Start();
            uvaesta.Stop();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BinaryFormatter formateador = new BinaryFormatter();
            //Stream miStream = new FileStream("Pacman.bin", FileMode.Create, FileAccess.Write);
            //formateador.Serialize(miStream, Uandes);
            //miStream.Close();
            //MessageBox.Show("Todos los datos modificados han sido guardados con exito.\n Gracias por preferirnos");

        }


        public void movimiento()
        {
            pac.mover(pac.getX() + xdir, pac.getY() + ydir);
            rojo.seguir(pac.x, pac.y);
            rosa.seguir(pac.x, pac.y);
            uva.dibujar(juego);
            cherry.dibujar(juego);
            puntaje.Text = Convert.ToString(puntos);

        }

        private void ciclo_Tick(object sender, EventArgs e)
        {
        
            juego.Clear(Color.White);
            pac.dibujar(juego);
            rojo.dibujar(juego);
            rosa.dibujar(juego);
            movimiento();


            if (pac.choque(cherry))
            {
                puntos = puntos + 10;
                cherry.sacar();
                cherrynoesta.Start();
                cherryesta.Stop();
                
            }

            if (pac.choque(uva))
            {
                puntos = puntos + 15;
                uva.sacar();
                uvanoesta.Start();
                uvaesta.Stop();

            }
            if (pac.choque(rosa))
            {
                puntos = 0;
            }
            if (pac.choque(rojo))
            {
                puntos = 0;
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
