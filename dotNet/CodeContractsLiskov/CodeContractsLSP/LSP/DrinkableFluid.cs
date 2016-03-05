using System.Diagnostics.Contracts;

namespace LSP
{
    public abstract class DrinkableFluid
    {
        public virtual void Drink(Person person, double ml)
        {
        }
    }
}