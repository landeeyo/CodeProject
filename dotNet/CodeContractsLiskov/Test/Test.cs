using LSP;
using Xunit;

namespace Test
{
    public class Test
    {
        [Fact]
        public void Oops()
        {
            Human human = new Child(10);
            DrinkableFluid fluid = new Wine();
            human.Drink(fluid, 750);
        }
    }
}