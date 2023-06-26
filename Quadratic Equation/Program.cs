namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("ax^2 + bx + c = 0, при a != 0");
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            new Reshenie(a, b, c).raschet();
            Console.ReadKey();
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;

        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void raschet()
        {
            D = (Math.Pow(a, 5) - Math.Pow(a, 3) * Math.Sqrt(b)) / (2 * c);
            Console.WriteLine("Ответ: {0}", D);
            Console.ReadKey();
        }
    }
}