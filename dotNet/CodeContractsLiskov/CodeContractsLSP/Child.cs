using System;
using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public class Child : Human
    {
        public Child(int age)
            : base(age)
        {
            Contract.Requires(age > 0);
            Contract.Requires(age < 130);
            this.Age = age;
        }

        public override void Drink(DrinkableFluid fluid, int ml)
        {
            Contract.Requires(!fluid.GetType().IsAssignableFrom(typeof(Alcohol)));
            this.Calories += Convert.ToInt32(ml * fluid.CaloriesPerMl);
        }
    }
}