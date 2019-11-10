using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Cat
    {
        private int age;

        private string gender;

        public Cat()
        : this("Unnamed")
        {
        }

        public Cat(string name)
        : this(name, 0, "male")
        {
        }

        public Cat(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 21)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 21");
                }
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (value == "male" || value == "female")
                {
                    this.gender = value;
                }
                else
                {
                    Console.WriteLine("Не правильно введен пол");
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя:{Name},Возраст:{Age},Пол:{Gender}");
        }

        public void SayMyew()
        {
            Console.WriteLine($"{Name}:Мяу");
        }

        public void AgeUp()
        {
            this.age++;
        }
    }
}