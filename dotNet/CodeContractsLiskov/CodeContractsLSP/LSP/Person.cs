using System;
using System.Diagnostics.Contracts;

namespace LSP
{
    public class Person
    {
        public int Age { get; set; }
        public int Calories { get; set; }

        public Person(int age)
        {
            if (age < 0 || age > 130)
            {
                throw new ArgumentException("Person age can't be less than 0 and greater than 130.");
            }
            this.Age = age;
        }
    }
}