using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона");
            Console.WriteLine("Введите длины сторон первого треугольника");
            double S1 = 0;
            for (int i = 0; i < 2; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double S;
                CalcS(x, y, z, out S);
                if (i == 1)
                {
                    if (S1>S)
                    {
                        Console.WriteLine("Площадь первого треугольника больше {0:F2} > {1:F2}", S1, S);
                    }
                    else
                    {
                        if (S1<S)
                        {
                            Console.WriteLine("Площадь второго треугольника больше {1:F2} > {0:F2}", S1, S);
                        }
                        else
                        {
                            Console.WriteLine("Площади треугольников равны {1:F2} = {0:F2}", S1, S);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введите длины сторон второго треугольника");
                }
                S1 = S;
            }
            Console.ReadKey();
        }
        static void CalcS(double x, double y, double z, out double S)
        {
            double P = (x + y + z) / 2;
            S = Math.Sqrt(P * (P - x) * (P - y) * (P - z));
        }
    }
}
