using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_it_felix_2
{
    class jugabilidad
    {
        string dificultad;
        felix fel;
        ralph ral;
        int vidas;
        ladrillo[] lad;
        int puntuacion=0;
        public jugabilidad(string dif,int vid)
        {
            Dificultad = dif;
            Fel = new felix(0,0);
            Ral = new ralph(0,0);
            Vidas = vid;
            Lad = new ladrillo[5];
            for( int i=0; i<5; i++)
            {
                Lad[i] = new ladrillo(ral.X,ral.Y+60);
            }
        }

        public string Dificultad
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

        internal felix Fel
        {
            get
            {
                return fel;
            }

            set
            {
                fel = value;
            }
        }

        internal ralph Ral
        {
            get
            {
                return ral;
            }

            set
            {
                ral = value;
            }
        }

        public int Vidas
        {
            get
            {
                return vidas;
            }

            set
            {
                vidas = value;
            }
        }

        internal ladrillo[] Lad
        {
            get
            {
                return lad;
            }

            set
            {
                lad = value;
            }
        }

        public int Puntuacion
        {
            get
            {
                return puntuacion;
            }

            set
            {
                puntuacion = value;
            }
        }

        public void pararladrillos( int y)
        {
            for(int i=0; i<5;i++)
            {
                Lad[i].Mov = false;
                
                Lad[i].Y = y;
            }
        }
        public bool ganar(ventana[] ven)
        {
            
            for(int i =0;i<ven.Length;i++ )
            {
                if(ven[i]!=null)
                {
                    if(ven[i].Daño > 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void romper(int pos,ref ventana[] ven)
        {
            
            Random r = new Random();
            if(ven[pos]==null)
            {
                goto x;
            }
            if (ven[pos].Daño == 4)
            {
                ven[pos].Daño = 4;
                ven[pos].generar();
            }
            if (ven[pos].Daño <4 && ven[pos].Daño>0)
            {
                ven[pos].Daño = 4;
                ven[pos].generar();
            }
            else if (ven[pos].Daño <= 0)
            {
                ven[pos].Daño = r.Next(2,5);
                ven[pos].generar();
            }
            x:;
        }
        
        public void reparar(ventana[] ven)
        {
            int re = 0;
            fel.martillar();
            if (Dificultad == "Fácil"){ re = 2; }else { re = 1; }
            if(Fel.Direccion==1)
            {
                for( int i=0; i<ven.Length;i++)
                {
                    if(ven[i]!=null)
                    if (ven[i].X + 23 > ( Fel.X) && (Fel.X) > ven[i].X && (Fel.Y + 25) > ven[i].Y && (Fel.Y + 25) < ven[i].Y + 50)
                    {
                            if(ven[i].Daño>0)
                            {
                                puntuacion += 100;
                            }
                        ven[i].Daño -= re;
                        ven[i].generar();
                    }
                }
                
            }
            if (Fel.Direccion == 2)
            {
                for (int i = 0; i < ven.Length; i++)
                {
                    if (ven[i] != null)
                        if (ven[i].X+40>(Fel.Ancho + Fel.X) && (Fel.Ancho + Fel.X) > ven[i].X && (Fel.Y +25) > ven[i].Y && (Fel.Y + 25) < ven[i].Y+50)
                    {

                            if (ven[i].Daño > 0)
                            {
                                puntuacion += 100;
                            }
                            ven[i].Daño -= re;
                        ven[i].generar();
                    }
                }
            }
        }
    }
}
