using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array;
            array = new int[10];
            array[0] = 1;
            array[1] = 3;
            array[2] = 4;
            array[3] = 5;
            array[4] = 6;
            array[5] = 7;
            array[6] = 9;
            array[7] = 8;
            array[8] = 2;
            array[9] = 0;

            textBox1.Text = array[0].ToString() +"," + array[1].ToString() + "," + array[2].ToString() + "," + array[3].ToString() + ","+ array[4].ToString() + "," + array[5].ToString() + "," + array[6].ToString() + "," + array[7].ToString() + "," + array[8].ToString() + "," + array[9].ToString() ;

        }
    }
}
