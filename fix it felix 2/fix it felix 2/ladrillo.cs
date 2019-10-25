using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fix_it_felix_2
{
    class ladrillo
    {
        int x;
        int y;
        int ancho, alto;
        Bitmap imagen;
        bool mov;
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Ancho
        {
            get
            {
                return ancho;
            }

            set
            {
                ancho = value;
            }
        }

        public int Alto
        {
            get
            {
                return alto;
            }

            set
            {
                alto = value;
            }
        }

        public Bitmap Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public bool Mov
        {
            get
            {
                return mov;
            }

            set
            {
                mov = value;
            }
        }

        public ladrillo(int xy,int yx)
        {
            Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
            X = xy;
            Y = yx;
            Bitmap lad = new Bitmap(15, 13);
            Graphics grla = Graphics.FromImage(lad);
            grla.DrawImage(imgmisc, 0, 0, new RectangleF(366, 5, 15, 13), GraphicsUnit.Pixel);
            Imagen = lad;
            Mov = false;
        }
        public void desplegar(int xy,int yx)
        {
            
            Mov = true;
            x = xy;
            y = yx;
        }
        public void caer(int lim)
        {
            if(y<lim && Mov)
            {
                y += 17;
            }
            else
            {
                Mov = false;
            }
        }
    }

}
