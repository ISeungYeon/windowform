using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExamProject
{
   /* class Exam
    {
            여기는 클래스 선언을 하면 디자이너가 깨져요 MainForm 에서는 아래의 Form을 먼저 읽어드려야 함
    }*/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Point p = null;

            p = new Point(int.Parse(txtX.Text), int.Parse(txtY.Text));

            txtR.Text = p.ToString();
        }
        //클래스가 클래스 안에 들어가는 경우도 있지만 일반적이진 않아요
    }
    /*
     * 여기에 클래스가 들어갈 수 있어요.
     */
}
