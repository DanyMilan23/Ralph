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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int c = 0;
        Bitmap[] romper;
        public void xds()
        { c += 4;

            /*   romper = new Bitmap[10];
               Bitmap img = new System.Drawing.Bitmap(70, 65);
               Graphics g = Graphics.FromImage(img);
               g.DrawImage(Properties.Resources.RalphSheet, 0, 0, new RectangleF(6 + c, 97, 70, 65), GraphicsUnit.Pixel);
               pictureBox1.Image = img;//13 21 65 82
               button2.Text = c.ToString();
               if (c > 35)
                   c = 0;*/
            ;  Bitmap imgralph = new Bitmap(Properties.Resources.RalphSheet);
            
            int var = 0;
            romper = new Bitmap[10];
            for (int i = 0; i < 3;i++)
            {
                romper[i] = new Bitmap(70, 65);
                Graphics grro = Graphics.FromImage(Properties.Resources.RalphSheet);
                var += 4;
                grro.DrawImage(imgralph, 0, 0, new RectangleF(6 + var * i, 97, 70, 65), GraphicsUnit.Pixel);
                if(i==1)
                {
                    var -= 1;
                }
                if(i==2)
                {
                    var -= 5;
                }
            }
            for(int i=4; i<5;i++)
            {
                var = 70;
                romper[i] = new Bitmap(70, 65);
                Graphics grra = Graphics.FromImage(romper[i]);
                grra.DrawImage(imgralph, 0, 0, new RectangleF(196 + var * (i - 4), 25, 70, 65), GraphicsUnit.Pixel);
            }
        }
        int ttronco = 0;
        public void intro()
        {
            
            
            /*
                   tmrintro.Interval = 200
        'vidas()
        ttronco += 1
        If ttronco < 8 Then
            Dim tronco As New Bitmap(63, 65)
            Dim grtr As Graphics = Graphics.FromImage(tronco)
            grtr.DrawImage(imgralph, 0, 0, New RectangleF(111 + 63 * ttronco + var, 480, 63, 65), GraphicsUnit.Pixel)
            If ttronco > 4 Then
                If ttronco = 5 Then
                    var = 0
                End If
                grtr.DrawImage(imgralph, 0, 0, New RectangleF(111 + 63 * (ttronco - 5) + var, 543, 63, 65), GraphicsUnit.Pixel)
                Dim dialral As New Bitmap(193, 25)
                Dim grdr As Graphics = Graphics.FromImage(dialral)
                grdr.DrawImage(imgralph, 0, 0, New RectangleF(307, 405, 193, 25), GraphicsUnit.Pixel)
                pbxdialral.Image = dialral
            End If
            pbxtronco.Image = tronco
            var += 1
        Else
            If ttronco = 8 Then
                Dim tronco As New Bitmap(63, 65)
                Dim grtr As Graphics = Graphics.FromImage(tronco)
                grtr.DrawImage(imgralph, 0, 0, New RectangleF(111, 480, 63, 65), GraphicsUnit.Pixel)
                pbxtronco.Image = tronco
                pbxdialral.Visible = False
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(387, 619, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
                Pbxralph.BringToFront()
            End If
        End If
        If ttronco > 9 And ttronco < 45 Then
            tmrintro.Interval = 100
            Pbxralph.Left += 20
            If ttronco Mod 2 Then
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(75, 17, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            Else
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(135, 17, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            End If
        End If
        If ttronco > 44 And ttronco < 51 Then
            tmrintro.Interval = 200
            pbxdialral.Location = New Point(Pbxralph.Location.X - 50, Pbxralph.Location.Y - 40)
            pbxdialral.Visible = True
            Dim dialral As New Bitmap(193, 25)
            Dim grdr As Graphics = Graphics.FromImage(dialral)
            grdr.DrawImage(imgralph, 0, 0, New RectangleF(304, 434, 193, 25), GraphicsUnit.Pixel)
            pbxdialral.Image = dialral
            If ttronco Mod 2 Then
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(385, 619, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            Else
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(320, 619, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            End If
        ElseIf ttronco > 51 And ttronco < 60 Then
            pbxdialral.Visible = False
            pbxdialral.Location = New Point(0, 0)
        End If
        If ttronco > 51 And ttronco < 87 Then
            tmrintro.Interval = 100
            If ttronco > 71 Then
                Pbxralph.Left += 20
            Else
                Pbxralph.Left -= 20
            End If

            If ttronco Mod 2 Then
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(10, 160, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            Else
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(78, 160, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            End If
        End If
        If ttronco = 86 Then
            '  tmrintro.Interval = 200
            Pbxralph.Left += 3
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(0, 314, 63, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
        End If
        If ttronco > 86 And ttronco < 95 Then
            Pbxralph.Top -= 20
        End If
        If ttronco = 95 Then
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(61, 314, 62, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Left += 35
        End If
        If ttronco = 97 Then
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(122, 314, 61, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Left -= 72
        End If
        '   Dim ralph1, ralph2 As Integer
        If ttronco = 98 Then
            ' ralph1 = Pbxralph.Location.X + 64
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(290, 314, 61, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Left += 64
        End If
        If ttronco = 101 Then
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(10, 400, 61, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Left -= 65
        End If
        If ttronco = 103 Then
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(0, 314, 63, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Left += 39
        End If
        If ttronco > 103 And ttronco < 113 Then
            Pbxralph.Top -= 40
        End If
        If ttronco > 112 And ttronco < 122 Then
            Pbxralph.Left -= 20
            If ttronco Mod 2 Then
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(296, 93, 75, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            Else
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(362, 93, 75, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            End If
        End If
        If ttronco = 122 Then
            Dim ralph As New Bitmap(63, 65)
            Dim grra As Graphics = Graphics.FromImage(ralph)
            grra.DrawImage(imgralph, 0, 0, New RectangleF(15, 28, 75, 65), GraphicsUnit.Pixel)
            Pbxralph.Image = ralph
            Pbxralph.Top += 20
        End If
        If ttronco > 123 Then
            If ttronco Mod 2 Then
                Pbxralph.Image = ralph(4)
            Else
                Pbxralph.Image = ralph(5)
            End If
        End If
        If ttronco = 123 Then
            pbxdialral.Location = New Point(495, 335)
            pbxdialral.Visible = True
            Dim dialral As New Bitmap(193, 45)
            Dim grdr As Graphics = Graphics.FromImage(dialral)
            grdr.DrawImage(imgmisc, 0, 0, New RectangleF(761, 577, 193, 45), GraphicsUnit.Pixel)
            pbxdialral.Image = dialral
            pbxdialral.Height += 30
        End If
reiniciar:
        If ttronco = 130 Then
            pbxdialral.Visible = False
            pbxdialral.Location = New Point(0, 0)
        End If
        If ttronco = 78 Then
            v1.Image = My.Resources.Ventana_1
        End If
        If ttronco = 87 Then
            v2.Image = My.Resources.Ventana_4
            v3.Image = My.Resources.Ventana_3
            v4.Image = My.Resources.Ventana_2
        End If
        If ttronco = 99 Then
            v8.Image = My.Resources.Ventana_4
        End If
        If ttronco = 114 Then
            v13.Image = My.Resources.Ventana_3
        End If
        If ttronco = 116 Then
            v12.Image = My.Resources.Ventana_1
            v7.Image = My.Resources.Ventana_2
        End If
        If ttronco = 118 Then
            v11.Image = My.Resources.Ventana_3
        End If
        If ttronco = 118 Then
            v10.Image = My.Resources.Ventana_4
            v6.Image = My.Resources.Ventana_1
        End If
        If ttronco = 120 Then
            v9.Image = My.Resources.Ventana_2
            v5.Image = My.Resources.Ventana_3
        End If
        If ttronco > 131 Then
            pbxdialfelix.Visible = True
        End If
        If ttronco > 131 Then
            felix(2) = New Bitmap(30, 48)
            Dim grfe As Graphics = Graphics.FromImage(felix(2))
            grfe.DrawImage(imgfelix, 0, 0, New RectangleF(170, 100, 30, 48), GraphicsUnit.Pixel)
            pbxfelix.Image = felix(2)
            pbxfelix.Visible = True
            pbxfelix.Location = New Point(1154, 555)
        End If
        If ttronco = 140 Then
            pbxfelix.Location = New Point(515, 555)
            pbxdialfelix.Visible = False
            tmrintro.Stop()
            tmrladrllos.Start()
            tmrralph.Start()
            tmrscore.Start()
            juego = True
            vida1.Image = felix(10)
            vida2.Image = felix(10)
            vida3.Image = felix(10)
        End If

            */
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //xds();
            romper = new Bitmap[10];
            Bitmap img = new System.Drawing.Bitmap(70, 65);
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(Properties.Resources.RalphSheet, 0, 0, new RectangleF(75 , 450, 125, 450), GraphicsUnit.Pixel);
            pictureBox1.Image = img;//13 21 65 82

          //  75,390  125,450
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //xds();
            ttronco++;
            Bitmap imgralph = new Bitmap(Properties.Resources.RalphSheet);
            Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
            if(ttronco==4)
            {
                ttronco = 1;
            }
            if (ttronco ==1)
            {

                Bitmap ventana = new Bitmap(400, 300);
                Graphics grve = Graphics.FromImage(ventana);
                grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                pictureBox3.Image = ventana;
                goto f;
            }
            if (ttronco ==3)
            {
                Bitmap ralph = new Bitmap(63, 65);
                Graphics grra = Graphics.FromImage(ralph);
                grra.DrawImage(imgralph, 0, 2, new RectangleF(111 + 63 , 480, 63, 65), GraphicsUnit.Pixel);
                grra.DrawImage(imgralph, 8, 0, new RectangleF(75, 17, 63, 65), GraphicsUnit.Pixel);
                pictureBox2.Image = ralph;


                Bitmap ventana = new Bitmap(400,300);
                Graphics grve = Graphics.FromImage(ventana);
                grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 7, 10, 10), GraphicsUnit.Pixel);
                pictureBox3.Image = ventana;//432,6
                goto f;
                //52,298

            }
          
            {
                if (ttronco==2)
                {
                    Bitmap ralph = new Bitmap(63, 65);
                    Graphics grra = Graphics.FromImage(ralph);
               
                    grra.DrawImage(imgralph, 0, 2, new RectangleF(111 + 63, 480, 63, 65), GraphicsUnit.Pixel);
                    grra.DrawImage(imgralph, 6, 0, new RectangleF(135, 17, 63, 65), GraphicsUnit.Pixel);
                    pictureBox2.Image = ralph;

                    Bitmap ventana = new Bitmap(400, 300);
                    Graphics grve = Graphics.FromImage(ventana);
                    grve.DrawImage(imgmisc, 0, 0, new RectangleF(272, 9, 25, 50), GraphicsUnit.Pixel);
                    grve.DrawImage(imgmisc, 7, 10, new RectangleF(433, 39, 10, 10), GraphicsUnit.Pixel);//433,39
                    pictureBox3.Image = ventana;

                }
             
                

            }
        f:;

            ;/*
            If ttronco > 9 And ttronco < 45 Then
            tmrintro.Interval = 100
            Pbxralph.Left += 20
            If ttronco Mod 2 Then
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(75, 17, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            Else
                Dim ralph As New Bitmap(63, 65)
                Dim grra As Graphics = Graphics.FromImage(ralph)
                grra.DrawImage(imgralph, 0, 0, New RectangleF(135, 17, 63, 65), GraphicsUnit.Pixel)
                Pbxralph.Image = ralph
            End If
        End If*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            Bitmap imgmisc = new Bitmap(Properties.Resources.MiscelanousSheet);
            Bitmap lad = new Bitmap(15, 13);
            Graphics grla = Graphics.FromImage(lad);
            grla.DrawImage(imgmisc, 0, 0, new RectangleF(366, 5, 15, 13), GraphicsUnit.Pixel);
            pictureBox1.Image = lad;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nivel_1 x = new nivel_1();
            x.Show();

            this.WindowState = FormWindowState.Minimized;
            //this.Close();
            //this.Hide();
        }

        int t = 17;
        private void timer2_Tick(object sender, EventArgs e)
        {
            t++;
            
            ralph r = new ralph(0,0);
            if (t == r.Coleccion.Length)
                t =0;
            button1.Text = t.ToString();
            pictureBox1.Image = r.Coleccion[t];
            pictureBox1.BackColor = Color.Black;
        }
    }
}
