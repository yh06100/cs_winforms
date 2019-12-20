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
    public partial class P008 : Form
    {
        public P008()
        {
            InitializeComponent();



            button1.Click += Button1_Click;
            MyService.SelectPRODUCT();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductVO vo = new ProductVO();
                vo.NAME = tb_NAME.Text;
                vo.COUNT = tb_COUNT.Text;
                vo.PRICE = tb_PRICE.Text;

                MyService.InsertPRODUCT(vo);
                MyService.SelectPRODUCT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
