﻿namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {   //  типа тесты
            if (!MakeTest())
            {
                Console.WriteLine("Тесты не пройдены, исправьте баги");
                return;
            }

            string doNext = "yes";

            double a, b, c;

            while (doNext == "yes")
            {
                Console.WriteLine("ax^2 + bx + c = 0, при a != 0");
                Console.WriteLine("Введите a: ");

                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a не должно равняться нулю\n");
                    continue;
                }

                Console.WriteLine("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите c: ");
                c = Convert.ToDouble(Console.ReadLine());

                double d = GetDiscriminant(a, b, c);

                if (d > 0)
                {
                    double x1 = GetX1(a, b, c);
                    double x2 = GetX2(a, b, c);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}\n");
                }
                else if (d == 0)
                {
                    double x = GetX(a, b, c);
                    Console.WriteLine($"D = 0, корень один x = {x}\n");
                }
                else
                {
                    Console.WriteLine("Дискриминант меньше 0, корней нет\n");
                }

                Console.WriteLine("Попоробвать еще раз? (yes/no)");
                doNext = Console.ReadLine() ?? "no";
            }


        }
        static double GetDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }     
        static double GetX(double a, double b, double c)
        {
            return -b / (2 * a);
        }
        static double GetX1(double a, double b, double c)
        {
            return (-b + Math.Pow(GetDiscriminant(a, b, c), 0.5)) / (2 * a);
        }
        static double GetX2(double a, double b, double c)
        {
            return (-b - Math.Pow(GetDiscriminant(a, b, c), 0.5)) / (2 * a);
        }
        static bool MakeTest()
        {
            bool isProgramOk = true;

            double d = GetDiscriminant(0, 0, 0);
            if (d != 0) return false;

            double x = GetX(1, 2, 1);
            if (x != -1) return false;

            return isProgramOk;
        }
    }
}
 