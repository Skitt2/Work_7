using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создать метод для вычисления объема и площади поверхности куба по длине его ребра.");
            Console.Write("Введите длину ребра куба = ");
            double lengthSide = Convert.ToDouble(Console.ReadLine());
            double V, S;
            CalcCube(lengthSide, out V, out S);
            Console.WriteLine("Объём куба {0} и площадь поверхности куба {1}", V, S);
            Console.ReadKey();
        }
        static void CalcCube(double lengthSide, out double V, out double S)
        {
            V = Math.Pow(lengthSide, 3);
            S = Math.Pow(lengthSide, 2) * 6;
        }

    }
}
