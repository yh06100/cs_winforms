using IBatisNet.DataMapper;
using OYH.CS.MybatisNET.Service;
using OYH.CS.MybatisNET.VO;
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
    public partial class P007 : Form
    {
        public P007()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            MyService.SelectSTUDENT();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentVO vo = new StudentVO();
                vo.NUMBER = tb_NUMBER.Text;
                vo.KOREAN = tb_KOR.Text;
                vo.ENGLISH = tb_ENG.Text;
                vo.MATH = tb_MATH.Text;
                vo.SOCIAL = tb_SOL.Text;
                vo.SCIENCE = tb_SCI.Text;

                MyService.InsertSCORE(vo);
                MyService.SelectSCORE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

















    }
}
