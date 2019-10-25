﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fix_it_felix_2
{
    public partial class nivel_1 : Form
    {
        /*Bitmap[] pisos = new Bitmap[5];
        Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
        Bitmap imgralph = new Bitmap(Properties.Resources.RalphSheet);
        Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
        //Bitmap imgpisos = new Bitmap(Properties.Resources.);
        Bitmap[] ralph = new Bitmap[15];
        Bitmap[] felix = new Bitmap[13];*/
        public nivel_1()
        {
            InitializeComponent();
        }


        //        int ttronco = 0;
        int t = 0;
        private void intro_Tick(object sender, EventArgs e)
        {
            t++;
            nivel.ralphjuego(ref t, nivel.Vidrio);
            nivel.Todo = nivel.Fondo;

            nivel.dibujar_ventanas();
            for (int i = 0; i < 5; i++)
            {
                nivel.dibujarladrillo(ref nivel.Jug.Lad[i], true);
            }
            nivel.generarralph();
            nivel.generar_felix();
            if (!nivel.Jugable)
                nivel.Jug.pararladrillos(200);

            this.BackgroundImage = nivel.Todo;
            if (!nivel.Vivo )
            {
                
                revivir.Start(); intro.Stop();
            }
          if(nivel.Jug.ganar(nivel.Vidrio ))
            {
                intro.Stop();
                ganaste();
                //label1.Text = "¡Ganaste!";
            }
        }
        public void ganaste()
        {
            timer1.Start();
            nivel.Vivo = false;
        }
        uno nivel;
        private void nivel_1_KeyDown(object sender, KeyEventArgs e)
        {
            if(nivel.Jugable)
            {
                this.BackgroundImage = null;

                switch (e.KeyCode)
                {
                    case Keys.Up:
                        {
                            nivel.mover(3);
                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();
                            break;
                        }
                    case Keys.Down:
                        {
                            nivel.mover(4);
                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();
                            break;
                        }
                    case Keys.Left:
                        {
                            nivel.mover(1);
                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();
                            break;
                        }
                    case Keys.Right:
                        {
                            nivel.mover(2);
                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();
                            break;

                        }
                    case Keys.Space:
                        {
                            nivel.Jug.reparar(nivel.Vidrio);
                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();
                            label2.Text = "Puntuacion: " + nivel.Jug.Puntuacion;
                            break;
                        }
                }
                //    label1.Text = "x: " + nivel.Jug.Fel.X + " y: " + nivel.Jug.Fel.Y;

                this.BackgroundImage = nivel.Todo;
            }
            
        }

        private void nivel_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (nivel.Jugable)
            {
                this.BackgroundImage = null;

                switch (e.KeyCode)
                {
                    case Keys.Space:
                        {
                            nivel.Jug.Fel.generar();

                            nivel.Todo = nivel.Fondo;
                            nivel.dibujar_ventanas();
                            nivel.generar_felix();

                            break;
                        }
                }
                //    label1.Text = "x: " + nivel.Jug.Fel.X + " y: " + nivel.Jug.Fel.Y;

                this.BackgroundImage = nivel.Todo;
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void nivel_1_Load(object sender, EventArgs e)
        {
            //  intro.Start();

            timerMusicaG.Start();
            Musica.Ctlcontrols.play();

            nivel = new uno();
            nivel.generar_ventanas();
            nivel.dibujar_ventanas();
             nivel.generar_felix();
            this.BackgroundImage = null;
            this.BackgroundImage = nivel.Todo;
            revivir.Start();
            
        }
        int viv = 0;
        private void revivir_Tick(object sender, EventArgs e)
        {
            if (nivel.Jug.Vidas == 0)
            {
                gameover x = new gameover();
                x.Show();
                this.Close();
            }
            if (viv<3)
            {
                //if (viv == 2)
                  
                nivel.Todo = nivel.Fondo;
                
                
                nivel.dibujar_ventanas();
                nivel.generarralph();
                nivel.cargar_jugador(); viv++;
                this.BackgroundImage = nivel.Todo;
            }
            else
            {
                nivel.Jugable = true;
                nivel.Vivo = true;
                viv = 0;
                intro.Start();
                revivir.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nivel.Jugable = false;
            Bitmap fon = new Bitmap(Properties.Resources.Nivel_1);
            Bitmap neg = new Bitmap(Properties.Resources.Panel_FondoED, fon.Width, fon.Height);
            Graphics grra = Graphics.FromImage(fon);

         if(nivel.Vivo )
            {
                nivel_2 x = new nivel_2(nivel.Jug.Vidas,nivel.Jug.Puntuacion);
                x.Show();
                this.Close();
                nivel.Vivo = false;
            }
            if (t <= fon.Height - 5)
            {
                t += 10;
                 
            }
            else
            {
                timer1.Interval = 3000;
                nivel.Vivo = true;
            }
            
            grra.DrawImage(neg, 0, fon.Height - t, new RectangleF(0, 0, neg.Width, neg.Height), GraphicsUnit.Pixel);
            this.BackgroundImage = fon;
        }
        bool pa = false;
        private void label1_Click_1(object sender, EventArgs e)
        {
            if(!pa)
            {
                panel1.Visible = true;
                intro.Stop();
                nivel.Jugable = false;
                pa = true;
            }
            else
            {
                panel1.Visible = false;
                intro.Start();
                nivel.Jugable = true;
                pa = false; 
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }
        bool vol = true;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (vol == true)
            {
                pictureBox3.Image = Properties.Resources.Volumen_Mute;
                // axWindowsMediaPlayer1.Ctlcontrols.pause();
                // timer1.Stop();
                vol = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.Volumen;
                //  axWindowsMediaPlayer1.Ctlcontrols.play();
                // timer1.Start();
                vol = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu  x = new menu();
            this.Close();
            x.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int music;
        private void timerMusicaG_Tick(object sender, EventArgs e)
        {
            if (music<15)
            {
                music++;
            }
            else
            {
                Musica.Ctlcontrols.play();
            }
        }
    }
}
