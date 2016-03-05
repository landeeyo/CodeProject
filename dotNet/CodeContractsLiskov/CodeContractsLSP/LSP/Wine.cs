using System;
using System.Diagnostics.Contracts;

namespace LSP
{
    public class Wine : DrinkableFluid
    {
        public override void Drink(Person person, double ml)
        {
            if (person.Age < Consts.AgeOfMajority)
            {
                throw new ArgumentException("Person is too young to drink");
            }
            person.Calories += Convert.ToInt32(ml * 0.85);
        }
    }
}