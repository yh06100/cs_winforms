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
    public partial class P001 : Form
    {
        public P001()
        {
            int x = 0;
            int y = 0;

            InitializeComponent();
            Console.WriteLine("덧셈을 하려고 합니다. 두 수를 입력하세요.");

            Console.Write("첫 번째 수를 입력하세요. :");
            x = int.Parse(Console.ReadLine());

            Console.Write("두 번째 수를 입력하세요. :");
            y = int.Parse(Console.ReadLine());

            Console.ReadKey();

            Console.WriteLine("두 수의 합 : {0} + {1} = {2}", x, y, x+y);
            Console.ReadKey();
        }
    }
}
