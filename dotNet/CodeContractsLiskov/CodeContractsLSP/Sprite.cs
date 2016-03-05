using System;
using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public class Sprite : Fluid
    {
        protected override void Drink(Person person, double ml)
        {
            person.Calories += Convert.ToInt32(ml * 0.27);
        }
    }
}