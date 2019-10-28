using System;

namespace CourseApp
{
    public class Program
        {
            public static double Matem(double b, double x)
            {
                 var y = (1 + Math.Pow(Math.Sin(Math.Pow(b, 5) + Math.Pow(x, 5)), 2)) / Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 0.33);
                return y;
            }

        public static double[] TaskA(double b, double xn, double xk, double dx)
        {
            int i = 0;
            var y = new double[(int)((xk - xn) / dx)];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = Matem(b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = Matem(b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
        const double xn = 1.28;
        const double xk = 3.28;
        const double dx = 0.4;
        const double b = 2.5;
        Console.WriteLine("Задание А:");
            foreach (var item in TaskA(b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.WriteLine("Задание B:");
            var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            foreach (var item in TaskB(b, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}