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
            return new double[0];
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
        const double b = 2.5;
        var resSingle = Matem(b, 4);
        Console.WriteLine(resSingle);
        var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
        var taskBRes = TaskB(b, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }
        }
    }
}