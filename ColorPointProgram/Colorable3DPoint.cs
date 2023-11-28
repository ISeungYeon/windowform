using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPointProgram
{
    internal class Colorable3DPoint : Point
    {
        private int z;
        private string color;

        public Colorable3DPoint(int x, int y, int z, string color) : base(x, y)
        {
            this.z= z;
            this.color= color;
        }
        public void SetZ( int z)
        {
            this.z = z;
        }
        public void SetColor( string color)
        {
            this.color = color; ;
        }
        public int GetZ()
        {
            return z;
        }
        public String GetColor()
        {
            return color;
        }
        public void MoveTo(int x, int y, int z)
        {
           base. MoveTo(x, y); //base 생략 가능
            this.z = z;
        }
        public void MoveBy(int x, int y, int z)
        {
            MoveBy(x, y);
            this.z = this.z + z;
        }
        public override string ToString()
        {
            return base.ToString() + ", z : " + this.z +  ", color : " + this.color;
        }

    }
}
