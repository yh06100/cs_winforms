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
    public partial class P003 : Form
    {
        public P003()
        {
            InitializeComponent();
            btn_Plus.Click += Btn_Plus_Click;
            btn_Clear.Click += Btn_Clear_Click;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "Ready--------------------------------";
            tb_Result.Text = "";
        }

        public int Plus(string x, string y)
        {
            int a = int.Parse(x);
            int b = int.Parse(y);

            return a + b;
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("공백이 입력되었습니다. 다시 입력해주세요.");
            }

            try
            {
                int x = int.Parse(textBox1.Text.Trim());
                int y = int.Parse(textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("숫자를 입력하세요. 다시 입력하세요.");
            }

            try
            {
                int xy = Plus(textBox1.Text, textBox2.Text);


                tb_Result.Text = xy.ToString();

                label3.Text = "  +  --------------------------------";
            }
            catch
            {

            }

        }
    }
}
