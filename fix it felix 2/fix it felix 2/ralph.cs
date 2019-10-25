using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace fix_it_felix_2
{
    class ralph
    {
        Bitmap imagen;
        int x, y;
        Bitmap[] coleccion;

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

        public Bitmap[] Coleccion
        {
            get
            {
                return coleccion;
            }

            set
            {
                coleccion = value;
            }
        }
        public ralph(int xy,int yx)
        {
            x = xy;
            y = yx;
            
            definircoleccion();
            imagen = coleccion[0];
        }
        public void definircoleccion()
        {
            Bitmap imgralph = new Bitmap(Properties.Resources.RalphSheet);
            Coleccion = new Bitmap[19];
            //camina tranquilo
            Coleccion[0] = new Bitmap(63, 65);
            Graphics grra = Graphics.FromImage(Coleccion[0]);
            grra.DrawImage(imgralph, 6, 0, new RectangleF(135, 17, 63, 65), GraphicsUnit.Pixel);

            Coleccion[1] = new Bitmap(63, 65);
            Graphics grra1 = Graphics.FromImage(Coleccion[1]);       
           grra1.DrawImage(imgralph, 8, 0, new RectangleF(75, 17, 63, 65), GraphicsUnit.Pixel);
            //camina molesto
            Coleccion[2] = new Bitmap(70, 65);
            Graphics grra2 = Graphics.FromImage(Coleccion[2]);
            grra2.DrawImage(imgralph, 0, 0, new RectangleF(192, 25, 69, 65), GraphicsUnit.Pixel);

            Coleccion[3] = new Bitmap(70, 65);
            Graphics grra3 = Graphics.FromImage(Coleccion[3]);
            grra3.DrawImage(imgralph, 0, 0, new RectangleF(192+70, 25, 69, 65), GraphicsUnit.Pixel);
            //rompe
            coleccion[4] = new Bitmap(70, 65);
            Graphics grra4 = Graphics.FromImage(coleccion[4]);
            grra4.DrawImage(imgralph, 0, 0, new RectangleF(6 + 2, 97, 70, 65), GraphicsUnit.Pixel);

            coleccion[5] = new Bitmap(70, 65);
            Graphics grra5 = Graphics.FromImage(coleccion[5]);
            grra5.DrawImage(imgralph, 0, 0, new RectangleF(6 + 2+70, 97, 70, 65), GraphicsUnit.Pixel);

            coleccion[6] = new Bitmap(70, 65);
            Graphics grra6 = Graphics.FromImage(coleccion[6]);
            grra6.DrawImage(imgralph, 0, 0, new RectangleF(6 + 142, 97, 70, 65), GraphicsUnit.Pixel);

            //tronco 
            coleccion[7] = new Bitmap(63, 65);
            Graphics grra7 = Graphics.FromImage(coleccion[7]);
            grra7.DrawImage(imgralph, 0, 0, new RectangleF(111 + -63 + 66, 480, 63, 65), GraphicsUnit.Pixel);

            coleccion[8] = new Bitmap(63, 65);
            Graphics grra8 = Graphics.FromImage(coleccion[8]);
            grra8.DrawImage(imgralph, 0, 0, new RectangleF(111 + 67, 480, 63, 65), GraphicsUnit.Pixel);

            coleccion[9] = new Bitmap(63, 65);
            Graphics grra9 = Graphics.FromImage(coleccion[9]);
            grra9.DrawImage(imgralph, 0, 0, new RectangleF(111 + 63 + 68, 480, 63, 65), GraphicsUnit.Pixel);

            coleccion[10] = new Bitmap(63, 65);
            Graphics grra10 = Graphics.FromImage(coleccion[10]);
            grra10.DrawImage(imgralph, 0, 0, new RectangleF(111 + 63*2 + 69, 480, 63, 65), GraphicsUnit.Pixel);

            coleccion[11] = new Bitmap(63, 65);
            Graphics grra11 = Graphics.FromImage(coleccion[11]);
            grra11.DrawImage(imgralph, 0, 0, new RectangleF(111 + 63*3 + 70, 480, 63, 65), GraphicsUnit.Pixel);

            coleccion[12] = new Bitmap(63, 65);
            Graphics grra12 = Graphics.FromImage(coleccion[12]);
            grra12.DrawImage(imgralph, 0, 0, new RectangleF(111 + 63*4+71, 480, 63, 65), GraphicsUnit.Pixel);
            //i am gonna wreck it
            Coleccion[13] = new Bitmap(170, 115);
            Graphics grra13 = Graphics.FromImage(Coleccion[13]);
            grra13.DrawImage(imgralph, 0, 0, new RectangleF(305, 430, 170, 40), GraphicsUnit.Pixel);
            grra13.DrawImage(imgralph, 0, 50, new RectangleF(330, 5, 69, 85), GraphicsUnit.Pixel);

            Coleccion[14] = new Bitmap(170, 115);
            Graphics grra14 = Graphics.FromImage(Coleccion[14]);
            grra14.DrawImage(imgralph, 0, 0, new RectangleF(305, 430, 170, 40), GraphicsUnit.Pixel);
            grra14.DrawImage(imgralph, 0, 50, new RectangleF(395, 5, 69, 85), GraphicsUnit.Pixel);
            //camina agitando sus brazos
            coleccion[15] = new Bitmap(63, 65);
            Graphics grra15 = Graphics.FromImage(coleccion[15]);
            grra15.DrawImage(imgralph, 0, 0, new RectangleF(318, 620, 63, 65), GraphicsUnit.Pixel);
           
            coleccion[16] = new Bitmap(67, 65);
            Graphics grra16 = Graphics.FromImage(coleccion[16]);
            grra16.DrawImage(imgralph, 0, 0, new RectangleF(318+67, 620, 65, 65), GraphicsUnit.Pixel);
            //golpea al suelo
           coleccion[17] = new Bitmap(72, 64);
            Graphics grra17 = Graphics.FromImage(coleccion[17]);
            grra17.DrawImage(imgralph, 0, 0, new RectangleF(295,95, 72, 64), GraphicsUnit.Pixel);
            
            coleccion[18] = new Bitmap(72, 64);
            Graphics grra18 = Graphics.FromImage(coleccion[18]);
            grra18.DrawImage(imgralph, 0, 0, new RectangleF(367, 95, 72, 64), GraphicsUnit.Pixel);


        }
    }
}
