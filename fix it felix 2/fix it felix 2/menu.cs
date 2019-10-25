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

   
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private string ruta = "";
        bool res = true, vol = true;

        private void label1_Click(object sender, EventArgs e)
        {
          //  axWindowsMediaPlayer1.Ctlcontrols.pause();
            timer1.Stop();
       //     Forms_Instrucciones x = new Forms_Instrucciones();
            this.Hide();
            nivel_1 x = new nivel_1();
            x.Show();
          //  x.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
      /*      if (vol == true)
            {
                pictureBox3.Image = Properties.Resources.Volumen_Mute;
              //  axWindowsMediaPlayer1.Ctlcontrols.pause();
                // timer1.Stop();
                vol = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.Volumen;
           //     axWindowsMediaPlayer1.Ctlcontrols.play();
                // timer1.Start();
                vol = true;
            }*/
        }

        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            instruciones y = new instruciones();

            //this.Hide();
            y.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            creditos x = new creditos();
            x.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        /*    if (vol == true)
            {
                if (music < 15)
                {
                    music += 1;
                }
                else
                {

                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    music = 0;
                }
            }
            */

            if (res == true)
            {
                label1.ForeColor = Color.Orange;
                res = false;
            }
            else
            {
                label1.ForeColor = Color.Red;
                res = true;
            }
        }
    }
}
