using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Dog : Animal
    {
        public Dog(string name, string brood)
        : base(name)
        {
            Brood = brood;
        }

        public string Brood { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name}:Гав");
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender},Порода:{Brood}";
        }
    }
}