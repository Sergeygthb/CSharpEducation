namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {   
            double a, b, c, x1, x2;
            Console.WriteLine("ax^2 + bx + c = 0, при a != 0");
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            double d = GetDiscriminant(a, b, c);

            if (d > 0)
            {
                x1 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                x2 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"D = 0, корень один x = {x1}");
            }
            else  
            {
                Console.WriteLine("Дискриминант меньше 0, корней нет");
            }
            //  Console.ReadKey();

        }
        static double GetDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }     
        static bool MakeTest(double a, double b, double c)
        {
            bool isProgramOk = true;
            return isProgramOk;
        }
    }
}
 