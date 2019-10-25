using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

    
    namespace fix_it_felix_2
{
    class ventana
    {
        Bitmap imagen;
        int daño;
        int fila;
        int columna;
        int x, y;
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

        public int Daño
        {
            get
            {
                return daño;
            }

            set
            {
                daño = value;
            }
        }

        public int Fila
        {
            get
            {
                return fila;
            }

            set
            {
                fila = value;
            }
        }

        public int Columna
        {
            get
            {
                return columna;
            }

            set
            {
                columna = value;
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

        public ventana(int f, int c, int xy, int yx)
        {
            X = xy; Y = yx;
            int[] num = { 0, 2, 4 };
            Random r = new Random();
            Daño = num[r.Next(1, 3)];
            Fila = f;
            Columna = c;
            generar();
        }
        public void generar()
        {
            Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
            switch (Daño)
            {
                case 0:
                    {

                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana; 
                        break;
                    }
                case 1:
                    {
                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 39, 10, 10), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 39, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana;
                        break;
                    }
                case 2:
                    {
                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 39, 10, 10), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 39, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana;
                        break;
                    }
                case 3:
                    {
                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                        //    grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        //  grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana;
                        break;
                    }
                case 4:
                    {
                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                    //    grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                      //  grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana;
                        break;
                    }
                default:
                    {
                        Bitmap ventana = new Bitmap(400, 300);
                        Graphics grve = Graphics.FromImage(ventana);
                        grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        grve.DrawImage(imgmisc, 7, 23, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                        Imagen = ventana;

                        break;
                    }
            }
        }
    }
}
