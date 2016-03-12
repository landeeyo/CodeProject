using System;

namespace LSP
{
    public class Child : Human
    {
        public Child(int age)
            : base(age)
        {
            if (age < 0 || age > 130)
            {
                throw new ArgumentException("Human can't have age less than 0 or greater than 130 year");
            }
            this.Age = age;
        }

        public override void Drink(DrinkableFluid fluid, int ml)
        {
            if (fluid is Alcohol)
            {
                throw new ArgumentException("Children can't drink alcohol");
            }
            this.ConsumedCalories += Convert.ToInt32(ml * fluid.CaloriesPerMl);
        }
    }
}