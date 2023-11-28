using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionProgram
{
    internal class Fraction
    {
        private int n1;
        private int n2;
        private int n3;
        private int d1;
        private int d2;
        private int d3;

        public Fraction(int n1, int n2,  int d1, int d2)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;

        }
        public void SetN1(int n1)
        {
            this.n1 = n1;
        }
        public void SetN2(int n2)
        {
            this.n2 = n2;
        }
        public void SetN3(int n3)
        {
            this.n3 = n3;
        }
        public void SetD1(int d1)
        {
            this.d1 = d1;
        }
        public void SetD2(int d2)
        {
            this.d2 = d2;
        }
        public void SetD3(int d3)
        {
            this.d3 = d3;
        }
        public int GetN1()
        {
            return this.n1;
        }
        public int GetN2()
        {
            return this.n2;
        }
        public int GetN3()
        {
            return this.n1 + this.n2;
        }
        public int GetD1()
        {
            return this.d1;
        }
        public int GetD2()
        {
            return this.d2;
        }
        public int GetD3()
        {
            return this.d1 + this.d2;
        } 

        public void Calc(int n1, int n2, int d1, int d2)
        {
            n3 = n1+ n2;
            d3 = d1+ d2;
        }

    }
}
