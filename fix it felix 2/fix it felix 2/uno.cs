using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fix_it_felix_2
{
    class uno
    {
        ventana[] vidrio;
        int velocidad;
        int dificultad;
        jugabilidad jug;
        Bitmap fondosinfelix = new Bitmap(Properties.Resources.Nivel_1___copia);
        Bitmap fondo = new Bitmap(Properties.Resources.Nivel_1);
        Bitmap todo = new Bitmap(Properties.Resources.Nivel_1.Width, Properties.Resources.Nivel_1.Height);
        bool jugable;

        internal ventana[] Vidrio
        {
            get
            {
                return vidrio;
            }

            set
            {
                vidrio = value;
            }
        }

        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public int Dificultad
        {
            get
            {
                return dificultad;
            }

            set
            {
                dificultad = value;
            }
        }

        internal jugabilidad Jug
        {
            get
            {
                return jug;
            }

            set
            {
                jug = value;
            }
        }

        public Bitmap Fondo
        {
            get
            {
                return fondo;
            }

            set
            {
                fondo = value;
            }
        }

        public Bitmap Todo
        {
            get
            {
                return todo;
            }

            set
            {
                todo = value;
            }
        }

        public Bitmap Fondosinfelix
        {
            get
            {
                return fondosinfelix;
            }

            set
            {
                fondosinfelix = value;
            }
        }

        public bool Jugable
        {
            get
            {
                return jugable;
            }

            set
            {
                jugable = value;
            }
        }

        public bool Vivo
        {
            get
            {
                return vivo;
            }

            set
            {
                vivo = value;
            }
        }

        int randralph = 0; bool romperralph = false;
        public void ralphjuego(ref int t, ventana[] ven)

        {
            generarralph();
            Random rnd = new Random();
            if (t <= 6)
            {
                if (t % 2 == 0)
                {
                    jug.Ral.Imagen = jug.Ral.Coleccion[15];
                }
                if (t % 2 == 1)
                {
                    jug.Ral.Imagen = jug.Ral.Coleccion[16];
                }
                if (t == 6)
                {
                    romperralph = ((rnd.Next(0, 2) == 0 && jug.Dificultad == "Fácil") || (rnd.Next(0, 5) == 0 && jug.Dificultad != "Fácil"));
           
                }
            }
            else
            {
             
                if (romperralph)
                {
                    Jugable = false;
                    Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
                    Bitmap fel = new Bitmap(30, 40);
                    Graphics grfe = Graphics.FromImage(fel);
                    grfe.DrawImage(imgfelix, 0, 0, new RectangleF(72, 192, 30, 40), GraphicsUnit.Pixel);
                    jug.Fel.Imagen = fel;
                    
                   switch(t)
                    {
                        case 7:
                            {
                                jug.romper(rnd.Next(0, ven.Length),ref ven);
                                jug.Ral.Imagen = jug.Ral.Coleccion[17];
                             
                                break;
                            }
                        case 8:
                            {
                                jug.romper(rnd.Next(0, ven.Length),ref ven);
                                jug.Ral.Imagen = jug.Ral.Coleccion[18];
                                break;
                            }
                        case 9:
                            {  
                                jug.romper(rnd.Next(0, ven.Length),ref ven);
                                jug.Ral.Imagen = jug.Ral.Coleccion[17];
                                break;
                            }
                        case 10:
                            {
                                jug.romper(rnd.Next(0, ven.Length),ref ven);
                                jug.Ral.Imagen = jug.Ral.Coleccion[18];
                                break;
                            }
                        case 11:
                            {
                                jug.romper(rnd.Next(0, ven.Length),ref ven);
                                jug.Ral.Imagen = jug.Ral.Coleccion[17];
                                t = 0;
                                jugable = true;
                                jug.Fel.generar();
                                break;
                            }
                            
                           
                    }
                  /*  todo = fondo;
                    dibujar_ventanas();
                    generar_felix();
                    generarralph();*/


                }
                else
                {
                  //  jugable = true;
                    
                    switch(t)
                    {
                        
                        case 7:
                            {
                                jug.pararladrillos(200);
                                jug.Ral.Imagen = jug.Ral.Coleccion[4];
                                //ladrillo ld = new ladrillo(rnd.Next(285, 455), 220);
                                jug.Lad[0].desplegar(rnd.Next(285, 455), 220);
                                
                                
                                break;
                            }
                        case 8:
                            {
                                jug.Ral.Imagen = jug.Ral.Coleccion[5];
                                jug.Lad[1].desplegar(rnd.Next(285, 455), 220);
                                jug.Lad[2].desplegar(rnd.Next(285, 455), 220);

                                break;
                            }

                        case 9:
                            {
                                jug.Ral.Imagen = jug.Ral.Coleccion[6];
                                jug.Lad[3].desplegar(rnd.Next(285, 455), 220);
                                break;
                            }

                        case 10:
                            {
                                jug.Ral.Imagen = jug.Ral.Coleccion[4];
                                jug.Lad[4].desplegar(rnd.Next(285, 455), 220);
                                t = 0;
                                break;
                            }
                            
                    }


                }
            }

            //      285,455
        }
        public void golpearladrillo(ladrillo ld)
        {
            if(jug.Fel.Direccion==1)
            {
                if( (ld.X+ld.Ancho<jug.Fel.X+jug.Fel.Ancho-10&& ld.X+ld.Ancho >jug.Fel.X)&& (ld.Y < jug.Fel.Y + jug.Fel.Alto-10 && ld.Y > jug.Fel.Y))
                {
                    jug.Vidas--;
                    morir();
                    jugable = false;
                  
                  //  cargar_jugador();
                }
            }
            else 
            {
                if ((ld.X + ld.Ancho < jug.Fel.X + jug.Fel.Ancho-10 && ld.X + ld.Ancho > jug.Fel.X)&& (ld.Y < jug.Fel.Y + jug.Fel.Alto - 10 && ld.Y > jug.Fel.Y))
                {
                    jug.Vidas--;
                    morir();
                    jugable = false;
                    
                 //   cargar_jugador();
                }
            }

        }
        bool vivo = true;
        public void morir()
        {
            if(jug.Vidas==0)
            {
                jugable = false;
                jug.Fel.perder();
                vivo = false;
            }
            else
            {
                jugable = false;
                
                jug.Fel.perder();
                jug.pararladrillos(200);
                vivo = false;
              //  cargar_jugador();
            }
            
        }
        bool fixit = true;
        public void generarralph()
        {
            Graphics grfo = Graphics.FromImage(Todo);
            grfo.DrawImage(jug.Ral.Imagen, jug.Ral.X, jug.Ral.Y, new RectangleF(0, 0, 70, 70), GraphicsUnit.Pixel);
        }
        public void cargar_jugador()
        {
            if(!jugable && !fixit)
            {
                Graphics grfo = Graphics.FromImage(Todo);
                Bitmap vidas = new Bitmap(16, 15);
                Graphics grvi = Graphics.FromImage(vidas);
                Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
                grvi.DrawImage(imgfelix, 0, 0, new RectangleF(14, 105, 16, 15), GraphicsUnit.Pixel);
                jug.Fel.perder();
                grfo.DrawImage(jug.Fel.Imagen, jug.Fel.X, jug.Fel.Y, new RectangleF(0, 0, 30, 40), GraphicsUnit.Pixel);
                for (int i = 0; i < jug.Vidas; i++)
                {
                    grfo.DrawImage(vidas, 20 + 20 * i, 10, new RectangleF(0, 0, 16, 15), GraphicsUnit.Pixel);
                }
             //   System.Threading.Thread.Sleep(2000);
                fixit = true;
                generar_felix();
                //cargar_jugador();
            }else 
            if(!jugable && fixit)
            {
                Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
                jug.Fel.X = 400;jug.Fel.Y = 320;
                Graphics grfo = Graphics.FromImage(Todo);
                Bitmap vidas = new Bitmap(16, 15);
                Graphics grvi = Graphics.FromImage(vidas);
                Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
                grvi.DrawImage(imgfelix, 0, 0, new RectangleF(14, 105, 16, 15), GraphicsUnit.Pixel);
                jug.Fel.Direccion = 1;
                jug.Fel.generar();
                grfo.DrawImage(jug.Fel.Imagen, jug.Fel.X, jug.Fel.Y, new RectangleF(0, 0, 30, 40), GraphicsUnit.Pixel);
                for (int i = 0; i < jug.Vidas; i++)
                {
                    grfo.DrawImage(vidas, 20 + 20 * i, 10, new RectangleF(0, 0, 16, 15), GraphicsUnit.Pixel);
                }
                grfo.DrawImage(imgmisc, vidrio[0].X-20, vidrio[8].Y, new RectangleF(760, 570, 180, 45), GraphicsUnit.Pixel);
                //                System.Threading.Thread.Sleep(2000);
                vivo = true;
               // jugable = true;
                //cargar_jugador();
                generar_felix();
            }else
            if(jugable&&fixit)
            {
                jug.Fel.X = 400;jug.Fel.Y = 320;
                generar_felix();
                fixit = false;
            }
        }

        public void dibujarladrillo(ref ladrillo ld, bool ca)
        {
            if(jugable && ld.Mov)
            {
                if(ca)
                ld.caer(790);
                Graphics grfo = Graphics.FromImage(Todo);
                grfo.DrawImage(ld.Imagen , ld.X, ld.Y, new RectangleF(0, 0, 15, 13), GraphicsUnit.Pixel);
                golpearladrillo(ld);
            }
            else
            {
                //   jug.pararladrillos(200);
                ld.Mov = false;
                ld.Y = 200;
            }
        }
        public uno()
        {
            jug = new jugabilidad("Fácil",3);
            ; jug.Fel.X = 400; jug.Fel.Y = 320;
            generar_ventanas();
            cargar_jugador();
            fixit = true;
            Jugable = false;
            jug.Ral.Y = 150;
            jug.Ral.X = 350;
        }
        public void generar_ventanas()
        {
            int[] x = { 290, 325, 360,394, 427 };
            int[] y = { 317, 265, 219 };
            Vidrio = new ventana[15];
            int fila=1, columna=0; 
            for(int i=0;i<Vidrio.Length;i++)
            {
                columna++;
                if(columna==6)
                {
                    columna = 1;
                    fila++;
                }
                if (columna == 3 && fila < 3)
                    ;
                else
                    Vidrio[i] = new ventana(fila,columna,x[columna-1],y[fila-1]);
            }

            
        }
        public void dibujar_ventanas()
        {
            
            todo = new Bitmap(Properties.Resources.Nivel_1);
            int fila = 1, columna = 0;
            Graphics grfo = Graphics.FromImage(todo);
            for(int i=0; i<Vidrio.Length;i++)
            {
                columna++;
                if (columna == 6)
                {
                    columna = 1;
                    fila++;
                }
                if (columna == 3 && fila < 3)
                    ;
                else
                    grfo.DrawImage(Vidrio[i].Imagen,Vidrio[i].X,Vidrio[i].Y, new RectangleF(2, 0, 40, 45), GraphicsUnit.Pixel);

            }
            //todo=fondo;

        }
        public void mover(int dir)
        {
            switch (dir)
            {
                case 1:
                    {
                        if(jug.Fel.X > 285)
                        {
                            jug.Fel.mover(dir);
                            generar_felix();
                        }
                        break;
                    }
                case 2:
                    {
                      if(jug.Fel.X + jug.Fel.Ancho < 455)
                        {
                            jug.Fel.mover(dir);
                            generar_felix();
                        }
                        break;
                    }
                case 3:
                    {
                     if(jug.Fel.Y > 220)
                        {
                            jug.Fel.mover(dir);
                            generar_felix();
                        }
                            break;
                    }
                case 4:
                    {
                       if(jug.Fel.Y + jug.Fel.Alto < 360)
                        {
                            jug.Fel.mover(dir);
                            generar_felix();
                        }
                            break;
                    }
            }
            
        }
        public void generar_felix()
        {
            //todo = Fondosinfelix;
            
            Graphics grfo = Graphics.FromImage(Todo);
            Bitmap vidas = new Bitmap(16, 15);
            Graphics grvi = Graphics.FromImage(vidas);
            Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
            grvi.DrawImage(imgfelix, 0, 0, new RectangleF(14, 105, 16, 15), GraphicsUnit.Pixel);
            for(int i=0; i<jug.Vidas;i++)
            {
                grfo.DrawImage(vidas, 20+20*i, 10, new RectangleF(0, 0, 16, 15), GraphicsUnit.Pixel);
            }
            generarralph();
            for (int i = 0; i < 5; i++)
            {
                dibujarladrillo(ref Jug.Lad[i],false);
            }
            grfo.DrawImage(jug.Fel.Imagen, jug.Fel.X, jug.Fel.Y, new RectangleF(0, 0, 30, 40), GraphicsUnit.Pixel);
        }
    }
}
