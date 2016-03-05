using LSP;
using Xunit;

namespace Test
{
    public class Test
    {
        [Fact]
        public void Oops()
        {
Person person = new Person(17);
DrinkableFluid fluid = new Wine();
fluid.Drink(person, 750);
        }
    }
}