using System.Diagnostics.Contracts;

namespace CodeContractsLSP
{
    public class Person
    {
        public int Age { get; set; }
        public int Calories { get; set; }

        public Person(int age)
        {
            Contract.Requires(age > 0);
            Contract.Requires(age < 130);
            this.Age = age;
        }
    }
}