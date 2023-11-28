using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamProject
{
    //새 항목 추가로 클래스를 만들 수 있다.
    internal class Point
    {
        private int x;
        int y; //생략 시 private
        public static readonly double PI = 3.14; //public을 변수에 사용하는 일반적인 예

        //1 생성자 - 대표적인 중복정의 - 다형성
        public Point()
        {
            x = y = 10;

        }
        public Point(int xx, int yy)
        {
            this.x = xx; // xx = x; (올바르지 않음)
            this.y = yy;
        }
        //접근자, 수정자 get메서드 set메서드 -> C#에서는 프로퍼티로 만듬 (나중에)
        public int getX()
        {
            return this.x;
        }
        public void setX(int x)
        {
            this.x = x;
        }

        // 정보제공 - 문자열 형태로
        public override string ToString()
        {
            return "x: " + x + " y: " + y;
        }
    }
}
