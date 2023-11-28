using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionAddProject
{
    public partial class FractionAddForm : Form
    {
        public FractionAddForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int numerator1, numerator2, numerator3=0;
            int denominator1, denominator2, denominator3=0;

            numerator1 = int.Parse(txtNumerator1.Text);
            numerator2 = int.Parse(txtNumerator2.Text);
            denominator1 = int.Parse(txtDenominator1.Text);
            denominator2 = int.Parse(txtDenominator2.Text);


            if( denominator1 == denominator2)
            {
                denominator3 = denominator1;
                numerator3 = numerator1+ numerator2;
            }
            else
            {
                denominator3 = denominator1 * denominator2;
                numerator3 = numerator1 * denominator2 + numerator2 * denominator1;
            }

            /*Euclid(numerator3, denominator3);

             int Euclid(int n1, int n2)
            {
                if (n1 == 0)
                    return n2;
                else if (n2 == 0)
                    return n1;
                else if (n1 < n2)
                    return Euclid(n2, n1 % n2);
                else
                    return Euclid(n1, n2 % n1);
            }*/
           

            txtDenominator3.Text = denominator3.ToString();
            txtNumerator3.Text = numerator3.ToString();
        }
    }
}
