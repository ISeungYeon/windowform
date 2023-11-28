using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionProgram
{
    public partial class FractionForm : Form
    {
        Fraction fr = null;
        public FractionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;
            int d1;
            int d2;
            int d3;

            n1 = int.Parse(txtNumerator1.Text);
            n2 = int.Parse(txtNumerator2.Text);
            d1 = int.Parse(txtDenominator1.Text);
            d2 = int.Parse(txtDenominator2.Text);

            fr = new Fraction(n1,n2,d1,d2);

            txtNumerator3.Text = fr.GetN3() + "";
            txtDenominator3.Text = fr.GetD3() + "";



        }
    }
}
