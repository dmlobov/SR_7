using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double Square(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1 = Square(x1, y1, z1);
            Console.WriteLine("Введите длины второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = Square(x2, y2, z2);
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника {0:0.00} больше площади второго треугольника {1:0.00}", S1,S2);
            else
                if (S1 < S2)
                Console.WriteLine("Площадь второго треугольника {0:0.00} больше площади первого треугольника {1:0.00}", S2, S1);
            else
                Console.WriteLine("Площадь первого треугольника {0:0.00} равна площади второго треугольника {1:0.00}", S1, S2);
            Console.ReadKey();
        }
    }
}