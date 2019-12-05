using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYH.CS.Chapter1
{
    public partial class P004 : Form
    {
        public P004()
        {
            InitializeComponent();

            btn_Plus.Click += Btn_Plus_Click; // 더하기 이벤트 만들기
            button1.Click += Button1_Click; // 빼기 이벤트 만들기
            button2.Click += Button2_Click; // 곱하기 이벤트 만들기
            button3.Click += Button3_Click; // 나누기 이벤트 만들기
            btn_Clear.Click += Btn_Clear_Click; // 클리어 이벤트 만들기
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tb_Result.Text = "";
            label3.Text = "Ready--------------------------------";
        }

        public int Plus(string x, string y)
        {
            int a = int.Parse(x) + int.Parse(y); // 23 + 3

            return a;
        }

        public int Mainus(string x, string y)
        {
            int a = int.Parse(x) - int.Parse(y); // 23 - 3

            return a;
        }

        public int gop(string x, string y)
        {
            int a = int.Parse(x) * int.Parse(y); // 23 * 3

            return a;
        }

        public int nanuki(string x, string y)
        {
            int a = int.Parse(x) / int.Parse(y); // 23 / 3

            return a;
        }

        private void Button3_Click(object sender, EventArgs e) // 나누기
        {
            int xNy = nanuki(textBox1.Text, textBox2.Text);
            tb_Result.Text = xNy.ToString();
            label3.Text = "  /  --------------------------------";
        }

        private void Button2_Click(object sender, EventArgs e) // 곱하기
        {
            int xXy = gop(textBox1.Text, textBox2.Text);
            tb_Result.Text = xXy.ToString();
            label3.Text = "  *  --------------------------------";
        }

        private void Button1_Click(object sender, EventArgs e) // 빼기
        {
            int xMy = Mainus(textBox1.Text, textBox2.Text);
            tb_Result.Text = xMy.ToString();
            label3.Text = "  -  --------------------------------";
        }

        private void Btn_Plus_Click(object sender, EventArgs e) // 더하기
        {
            int xPy = Plus(textBox1.Text, textBox2.Text);
            tb_Result.Text = xPy.ToString();
            label3.Text = "  +  --------------------------------";
        }
    }
}
