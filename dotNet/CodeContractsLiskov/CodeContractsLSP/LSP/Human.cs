using System;

namespace LSP
{
    public class Human
    {
        public int Age { get; set; }

        public int Calories { get; set; }

        public Human(int age)
        {
            if (age < 0 || age > 130)
            {
                throw new ArgumentException("Human can't have age less than 0 or greater than 130 year");
            }
            this.Age = age;
        }

        public virtual void Drink(DrinkableFluid fluid, int ml)
        {
            if (fluid == null)
            {
                throw new ArgumentException("Fluid can't be null");
            }
            if (ml < 0)
            {
                throw new ArgumentException("Can't drink less than 0 ml of fluid");
            }
            this.Calories += Convert.ToInt32(ml * fluid.CaloriesPerMl);
        }
    }
}