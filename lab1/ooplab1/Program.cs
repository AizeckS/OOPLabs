using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcFun calcFun = new CalcFun();
            calcFun.ShowDataTime();
            calcFun.SetValue();
            calcFun.ShowResult();
            Console.ReadKey();
        }
    }
}
