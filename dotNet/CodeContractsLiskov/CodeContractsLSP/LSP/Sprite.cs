using System;
using System.Diagnostics.Contracts;

namespace LSP
{
    public class Sprite : DrinkableFluid
    {
        public override void Drink(Person person, double ml)
        {
            person.Calories += Convert.ToInt32(ml * 0.27);
        }
    }
}