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
    public partial class youwin : Form
    {
        int punt;
        public youwin(int pun)
        {
            InitializeComponent();
            punt = pun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntua x = new puntua(punt);
            x.Show();
            this.Close();
        }
    }
}
