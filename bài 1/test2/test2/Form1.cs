﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string str = "jkajkdfjhja asdfioasfn jajiosf aiosdfasji jioasfjioajio";
            for (int i = 0; i< Convert.ToInt32(str.Length);i++)
            {
                    label1.Text += str[i];

                Thread.Sleep(500);
            }

        }
    }
}
