﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dan;

            dan = int.Parse(textBox1.Text);

            for(int i = 1; i < 10; i++)
            {
                textBox2.Text += dan + "*" + i + "=" + dan * i + Environment.NewLine;
                
            }
            
        }
    }
}
