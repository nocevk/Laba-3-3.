using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._3
{
    internal class Program

    {    
        static void ObchyslenniaFunktsii ()

        {       //Task3 : Обчислення функцій tg(x/3) * sin(x - 1.2) та 2,5 * sin(x/2)
            {
                double a = -2.5;
                double b = 5;
                double h = 0.2;

                Console.WriteLine(" x\t\ttg(x/3) * sin(x - 1.2)\t\t2.5 * sin(x/2)");
                Console.WriteLine("-------------------");

                for (double x = a; x <= b; x += h)
                {
                    
                    double firstFunction = Math.Tan(x / 3) * Math.Sin(x - 1.2);
                    double secondFunction = 2.5 * Math.Sin(x / 2);

                    Console.WriteLine($"{x:F2}\t\t{firstFunction:F6}\t\t\t{secondFunction:F6}");

                }

            }
        }
    }
}
