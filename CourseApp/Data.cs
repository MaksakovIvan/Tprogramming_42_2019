using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Data
    {
        public static string Age()
        {
            Console.WriteLine("Число вашего рождения:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц вашего рождения:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Год вашего рождения:");
            int year = int.Parse(Console.ReadLine());
            DateTime res = new DateTime(year, month, day);
            DateTime result = new DateTime(DateTime.Now.Ticks - res.Ticks);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }
    }
}