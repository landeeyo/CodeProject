using System;
using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public class Human
    {
        public int Age { get; set; }

        public int ConsumedCalories { get; set; }

        public Human(int age)
        {
            Contract.Requires(age > 0);
            Contract.Requires(age < 130);
            this.Age = age;
        }

        public virtual void Drink(DrinkableFluid fluid, int ml)
        {
            Contract.Requires(fluid != null);
            Contract.Requires(ml > 0);
            this.ConsumedCalories += Convert.ToInt32(ml * fluid.CaloriesPerMl);
        }
    }
}