using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointExam
{
    /*public class Point
    {
        메인 폼 위에 클래스 만들면 디자이너가 보이지 않음 18줄이 폼을 만드는 것임
    }*/ 

    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }

        Point p = null;
        Point2 <int> p1 = null;

        private void PointForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;


            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            
            p = new Point(x, y);

            txtPrint.Text = p.ToString();

            p1 = new Point2<int>(x,y);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            p.MoveTo(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p.ToString();

            p1.MoveTo(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p1.ToString();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            p.MoveBy(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p.ToString();
        }
    }
    /*public class Point
    {

    }*/
}
