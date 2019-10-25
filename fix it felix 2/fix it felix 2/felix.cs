using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fix_it_felix_2
{
    class felix
    {
        Bitmap imagen;
        int direccion;
        int x;
        int y;
        double ancho, alto;

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

        public int Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

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

        public double Ancho
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

        public double Alto
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

        public felix(int xy, int yx)
        {
            Direccion = 1;
            X = xy;Y = yx;
            Ancho = 30;
            Alto = 40;
            generar();
        }
        public void generar()
        {
            Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
            switch (Direccion)
            {

                case 1:
                    {
                        Bitmap fel = new Bitmap(30, 40);
                        Graphics grfe = Graphics.FromImage(fel);
                        grfe.DrawImage(imgfelix, 0, 0, new RectangleF(170, 100, 30, 40), GraphicsUnit.Pixel);
                        Imagen = fel;
                        break;
                    }
                case 2:
                    {
                        Bitmap fel = new Bitmap(30, 40);
                        Graphics grfe = Graphics.FromImage(fel);
                        grfe.DrawImage(imgfelix, 0, 0, new RectangleF(164, 5, 30, 40), GraphicsUnit.Pixel);
                        Imagen = fel;
                        break;
                    }
              
            }
        }
        public void martillar()
        {
            Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
            switch (Direccion)
            {

                case 1:
                    {
                       Bitmap fel = new Bitmap(55, 40);
                        Graphics grfe = Graphics.FromImage(fel);
                        grfe.DrawImage(imgfelix, 0, 0, new RectangleF(300, 105, 55, 40), GraphicsUnit.Pixel);
                        
                        Imagen = fel;
                        break;
                    }
                case 2:
                    {
                        Bitmap fel = new Bitmap(47, 40);
                        Graphics grfe = Graphics.FromImage(fel);
                        grfe.DrawImage(imgfelix, 0, 0, new RectangleF(300, 5, 47, 40), GraphicsUnit.Pixel);
                        Imagen = fel;
                        break;
                    }
                 
            }
        }
        public void perder()
        {
            Bitmap imgfelix = new Bitmap(Properties.Resources.felixSheet);
            Bitmap fel = new Bitmap(40, 20);
            Graphics grfe = Graphics.FromImage(fel);
            grfe.DrawImage(imgfelix, 0, 0, new RectangleF(281, 189, 40, 20), GraphicsUnit.Pixel);
            Imagen = fel;
            ;
        }
        public void mover(int dir)
        {
            switch(dir)
            {
                case 1:
                    {
                        Direccion = dir;
                        X -= 5;
                        break;
                    }
                case 2:
                    {
                        Direccion = dir;
                        X += 5;
                        break;
                    }
                case 3:
                    {
                        Y -= 50;
                        break;
                    }
                case 4:
                    {
                        Y += 50;
                        break;
                    }
            }
            generar();
        }

    }
}
