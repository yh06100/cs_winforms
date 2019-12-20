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

                InsertSTUDENT(vo);
                SelectSTUDENT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SelectSTUDENT()
        {
            ISqlMapper mapper = EntityMapper;
            StudentVO testVo = new StudentVO();
            IList<StudentVO> resultList = mapper.QueryForList<StudentVO>("SelectSTUDENT", testVo);

            for (int x = 0; x < resultList.Count; x++)
            {
                Console.WriteLine(resultList[x].NUMBER + resultList[x].NAME + resultList[x].AGE + resultList[x].SEX);
            }
        }
        public static void InsertSTUDENT(StudentVO vo)
        {
            
            ISqlMapper mapper = EntityMapper;
            StudentVO testVo = new StudentVO() { NUMBER = vo.NUMBER, NAME = vo.NAME, AGE = vo.AGE, SEX = vo.SEX };
            mapper.Insert("InsertSTUDENT", testVo);
        }



        // 
        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    //mapper.DataSource.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    return mapper;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static string executeFunction()
        {

            ISqlMapper mapper = EntityMapper;
            string str = mapper.QueryForObject<string>("FindPageId", "Footer");
            return str;
        }

    }
}
