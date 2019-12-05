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
    public partial class P005 : Form
    {
        public P005()
        {
            InitializeComponent();

            Console.WriteLine("첫 번째 수를 입력하세요 : ");
            int x = int.Parse(Console.ReadLine());
        }
    }
}
