using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //int y = 1;
            //int i = 0;
            //for(int j = 0; j < 9; j++)
            //{
            //    if(i<9)
            //    {
            //        for (i = 0; i < 9; i++)
            //        {
            //            int z = x * y;
            //            Console.WriteLine(x + "*" + y + "=" + z);

            //            y++;
            //        }
            //    }
            //    x++;
            //}
            //Console.ReadKey();


            for (int y = 1; y < 10; y++)
            {
                Console.WriteLine(2 + "* " + y + "=" + 2 * y);
                Console.WriteLine("test");
            }


            Console.ReadKey();

        }
    }
}
