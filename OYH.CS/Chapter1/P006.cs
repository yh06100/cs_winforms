using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OYH.CS.MybatisNET;
using OYH.CS.MybatisNET.VO;
using OYH.CS.MybatisNET.Service;

namespace OYH.CS.Chapter1
{
    public partial class P006 : Form
    {
        public P006()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentVO vo = new StudentVO();
                vo.NUMBER = tb_NUMBER.Text;
                vo.NAME = tb_NAME.Text;
                vo.AGE = tb_AGE.Text;
                vo.SEX = tb_SEX.Text;
                //MessageBox.Show(tb_NUMBER.Text);

                MyService.InsertSTUDENT(vo);
                MyService.SelectSTUDENT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
