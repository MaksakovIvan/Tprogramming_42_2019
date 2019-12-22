using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Data
    {
        public static DateTime SetDate()
        {
            Console.WriteLine("Введите день рождения");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения");
            int mounth = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год рождения");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, mounth, day);
            return date;
        }

        public static string Age()
        {
            DateTime birthday = Data.SetDate();
            DateTime timeNow = Data.SetDate();
            DateTime age;
            if (birthday.Ticks < timeNow.Ticks)
            {
                age = new DateTime(timeNow.Ticks - birthday.Ticks);
            }
            else
            {
                throw new Exception();
            }

            return $"Вам {age.Day - 1} дня,{age.Month - 1} месяцев, {age.Year - 1} лет";
        }
    }
}