using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Cat : Animal
    {
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

        public Cat(string name, string breed)
        : base(name)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name}: Мяу");
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender},Порода:{Breed}";
        }
    }
}
