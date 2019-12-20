using IBatisNet.DataMapper;
using OYH.CS.MybatisNET.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYH.CS.MybatisNET.Service
{
    public static class MyService
    {
        private static ISqlMapper mapper = MyService.EntityMapper;
        public static void SelectSTUDENT()
        {
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

        public static void SelectSCORE()
        {
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
