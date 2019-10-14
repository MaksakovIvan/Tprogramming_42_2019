using System;

namespace CourseApp
{
    public class Program
        {
            public static double Matem(double x, double b = 2.5, double y = 0)
            {
                y = (1 + Math.Pow(Math.Sin(Math.Pow(b, 5) + Math.Pow(x, 5)), 2)) / Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 0.33);
                return y;
            }

        public static void Main(string[] args)
            {
            for (double x = 1.28; x <= 3.28; x += 0.4)
            {
                Console.WriteLine(Matem(x));
            }

            double[] array_x = new double[5] { 1.1, 2.4, 3.6, 1.7, 3.9 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Matem(array_x[i]));
            }
        }
    }
}