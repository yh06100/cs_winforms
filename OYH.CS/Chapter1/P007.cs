using IBatisNet.DataMapper;
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

                InsertSCORE(vo);
                SelectSCORE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }











        public static void SelectSCORE()
        {
            ISqlMapper mapper = EntityMapper;
            StudentVO testVo = new StudentVO();
            IList<StudentVO> resultList = mapper.QueryForList<StudentVO>("SelectSCORE", testVo);

            for (int x = 0; x < resultList.Count; x++)
            {
                Console.WriteLine(resultList[x].NUMBER + resultList[x].KOREAN + resultList[x].ENGLISH + resultList[x].MATH
                    + resultList[x].SOCIAL + resultList[x].SCIENCE);
            }
        }
        public static void InsertSCORE(StudentVO vo)
        {
            ISqlMapper mapper = EntityMapper;
            StudentVO testVo = new StudentVO()
            {
                NUMBER = vo.NUMBER,
                KOREAN = vo.KOREAN,
                ENGLISH = vo.ENGLISH,
                MATH = vo.MATH,
                SOCIAL = vo.SOCIAL,
                SCIENCE = vo.SCIENCE
            };
            mapper.Insert("InsertSCORE", testVo);
        }




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
