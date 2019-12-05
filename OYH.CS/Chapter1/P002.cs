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
    public partial class P002 : Form
    {
        int x;
        int y;
        public P002()
        {
            InitializeComponent();
            btn_Plus.Click += Btn_Plus_Click;
            btn_Clear.Click += Btn_Clear_Click;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tb_Result.Text = "";
            label3.Text = "Ready--------------------------------";
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            int xy = Plus(textBox1.Text, textBox2.Text);
            // tb_Result.Text = ToString(x); Plus 함수에서 받아서 값만 뿌리면 될 것 같은데 어떻게 받는지 모르겠다...

            tb_Result.Text = xy.ToString();
        }

        public int Plus(string sx, string xy)
        {
            x = int.Parse(sx);
            y = int.Parse(xy);
            label3.Text = "  +  --------------------------------";
            return x+y;
        }
    }
}
