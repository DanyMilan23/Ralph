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
    public partial class creditos : Form
    {
        public creditos()
        {
            InitializeComponent();
        }

        private void creditos_Load(object sender, EventArgs e)
        {
            CreditosM.Ctlcontrols.play();
            timerCreditos.Start();

        }
        int music;
        private void timerCreditos_Tick(object sender, EventArgs e)
        {
            if (music<180)
            {
                music += 1;
            }
            else
            {
                CreditosM.Ctlcontrols.stop();
                menu x = new menu();
                this.Close();
                x.Show();
            }
        }
    }
}
