using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetParamsCube(double a, out double v, out double s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetParamsCube(a, out v, out s);
            Console.WriteLine("{0:0.00}  {1:0.00}", v, s);
            Console.ReadKey();
        }
    }
}
