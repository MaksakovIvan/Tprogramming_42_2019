using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Cat : Animal
    {
        public Cat(string name, string brood)
        : base(name)
        {
            Brood = brood;
        }

        public string Brood { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name}:Мяу");
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender},Порода:{Brood}";
        }
    }
}