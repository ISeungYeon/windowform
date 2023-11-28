using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointExam
{
    internal class Point
    {
        /*
         멤버변수, 생성자, 접근자(수정자), get, set 메서드 -> 프로퍼티를 만들어서 사용 , 연산자 재정의, 델리게이트
        각종 메서드, ToString*/

        private int x;
        private int y;

        public Point(int x, int y) //생성자 부분
        {
            this.x = x;
            this.y = y; 
        }
        public void SetX(int x) //값을 받아서 바꿔주는 역할
        {
            this.x = x;
        }
        public void SetY(int Y)
        {
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveBy(int moveX, int moveY)
        {
            this.x = this.x + moveX;
            this.y = this.y + moveY;
        }
        public override string ToString()
        {
            return "x : " + this.x + ", y : " + this.y; //x: 100 , y: 100
        }
    }
}
