using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace fix_it_felix_2
{
    public partial class puntua : Form
    {
        int punt;
        public puntua(int pun)
        {
            punt = pun;
            InitializeComponent();
        }
        static StreamReader leer;
        static StreamWriter escribir;
        static int[] puntajes = new int[10];
        static string[] alias = new string[10];
        static string[] lineas = new string[10];
        string ali;
        int puntuacion;
        private void puntua_Load(object sender, EventArgs e)
        {
            textBox2.Text = punt.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            leer = new StreamReader("puntajes.txt");
            int i = 0;
            while (!leer.EndOfStream)
            {
                lineas[i] = Convert.ToString(leer.ReadLine());
                i++;
            }
            leer.Close();

            for (int j = 0; j < 10; j++)
            {
                if (lineas[j] != null)
                {
                    string aux = lineas[j];
                    int j1 = 0;
                    string aux2 = "";
                    do
                    {
                        aux2 += aux[j1];
                        j1++;
                    } while (aux[j1] != ',' && j1 != aux.Length - 1);
                    puntajes[j] = Convert.ToInt32(aux2);
                    j1++;
                    aux2 = "";
                    while (j1 < aux.Length)
                    {
                        aux2 += aux[j1];
                        j1++;
                    }
                    alias[j] = Convert.ToString(aux2);
                }
            }
            puntuacion = Convert.ToInt32(textBox2.Text);
            ali = Convert.ToString(textBox1.Text);
            for (int j = 0; j < 10; j++)
            {
                if (puntuacion > puntajes[j])
                {
                    for (int k = 9; k != j; k--)
                    {
                        puntajes[k] = puntajes[k - 1];
                    }
                    puntajes[j] = puntuacion;
                    alias[j] = ali;
                }
            }

            escribir = new StreamWriter("puntajes.txt");
            for (int j = 0; j < 10; j++)
            {
                escribir.WriteLine(puntajes[j] + ',' + alias[j]);
            }

            escribir.Close();
            x:;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.Show();
            this.Close();
        }
    }
}
