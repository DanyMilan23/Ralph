﻿using System;
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
    public partial class gameover : Form
    {
        public gameover()
        {
            InitializeComponent();
        }

        private void gameover_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu x = new menu();
            x.Show();
        }
    }
}
