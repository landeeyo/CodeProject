using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public abstract class Fluid
    {
        protected virtual void Drink(Person person, double ml)
        {
            Contract.Requires(person != null);
            Contract.Requires(ml >= 0);
        }
    }
}