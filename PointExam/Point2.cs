using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointExam
{
    internal class Point2 <DataType>
    {
        private DataType x;
        private DataType y;

        public Point2(DataType x, DataType y)
        {
            this.x = x;
            this.y = y;
        }
        
        public void SetX(DataType x) //값을 받아서 바꿔주는 역할
        {
            this.x = x;
        }
        public void SetY(DataType Y)
        {
            this.y = y;
        }
        public DataType GetX()
        {
            return x;
        }
        public DataType GetY()
        {
            return y;
        }
        public void MoveTo(DataType x, DataType y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x : " + this.x + ", y : " + this.y; //x: 100 , y: 100
        }
    }
}
