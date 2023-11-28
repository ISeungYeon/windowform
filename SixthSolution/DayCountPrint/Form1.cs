using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayCountPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;
            int other = 28;
            int thirty = 30; //4,6,9,11
            int thirtyone = 31; //1,3,5,7,8,10

            month = int.Parse(textBox1.Text);

            switch (month)
            {
             case 1: textBox2.Text = thirtyone.ToString();
                    break;
             case 2:
                    textBox2.Text = other.ToString();
                    break;

             case 3:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 4:
                    textBox2.Text = thirty.ToString();
                    break;

             case 5:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 6:
                    textBox2.Text = thirty.ToString();
                    break;

             case 7:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 8:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 9:
                    textBox2.Text = thirty.ToString();
                    break;

             case 10:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 11:
                    textBox2.Text = thirtyone.ToString();
                    break;

             case 12:
                    textBox2.Text = thirty.ToString();
                    break;

            }

        }
    }
}