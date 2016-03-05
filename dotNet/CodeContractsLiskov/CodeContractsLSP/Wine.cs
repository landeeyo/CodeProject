using System;
using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public class Wine : Fluid
    {
        protected override void Drink(Person person, double ml)
        {
            Contract.Requires(person.Age > Consts.AgeOfMajority);
            person.Calories += Convert.ToInt32(ml * 0.85);
        }
    }
}