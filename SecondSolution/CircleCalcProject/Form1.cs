using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalcProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            double v;
            double s;

            double r1 = double.Parse(txtR.Text);
            r = r1;

            v = (4 / 3 )* 3.14 * r * r * r;
            s = 4 * 3.14 * r * r;

            txtVolume.Text = v.ToString();
            txtSurface.Text = s.ToString();

            
        }
    }
}
