using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            nivel_1 x = new nivel_1();
            x.Show();
            this.Hide();

            /*timer1.Start();
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;
            /*Form1 x = new Form1();
            x.Show();
            this.Hide();*/
        }
        int t = 0;bool arriba = false;bool abajo = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap fon = new Bitmap(Properties.Resources.nivel_2);
            Bitmap neg = new Bitmap(Properties.Resources.Panel_Fondo,fon.Width,fon.Height);
            Graphics grra = Graphics.FromImage(fon);
            
            if (arriba)
                t += 20;
            if (abajo)
                t -= 20;
            if (t>=fon.Height-5)
            {
             //   abajo = true;
                arriba = false;
            }
            if (t == 0)
            {
                abajo = false;
                arriba = true;
            }
            grra.DrawImage(neg, 0, fon.Height - t, new RectangleF(0, 0, neg.Width, neg.Height), GraphicsUnit.Pixel);
            this.BackgroundImage = fon;
        }
    }
}
