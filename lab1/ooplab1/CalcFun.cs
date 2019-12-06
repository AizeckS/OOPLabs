using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1
{
    class CalcFun
    {
        double x, y, z;
        public void SetValue()
        {
            Console.WriteLine("Введіть x=");
            this.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть y=");
            this.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть z=");
            this.z = Convert.ToDouble(Console.ReadLine());
        }
        public double CalculateFirst()
        {
            double result = (2 * Math.Cos(x - Math.PI / 6)) / (1 / 2 + Math.Pow(Math.Sin(y), 2));
            return result;
        }
        public double CalculateSecond()
        {
            double result = 1 + (Math.Pow(z, 2)) / (3 + Math.Pow(z, 2) / 5);
            return result;
        }

        public void ShowResult()
        {
            double first = CalculateFirst();
            double second = CalculateSecond();
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
            Console.WriteLine("z={0}", z);
            Console.WriteLine("a={0}", first);
            Console.WriteLine("b={0}",second);
        }
        public void ShowDataTime()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(String.Format("Сьогодні:{0:dd-MM-yyyy}",date));
        }
    }
}
