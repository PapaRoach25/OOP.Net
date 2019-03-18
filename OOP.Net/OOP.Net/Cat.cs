using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    class Cat : Animal
    {
        public Cat(int age, double weight)
            : base(age, weight) { }

        public override void Eat()
        {
            Console.WriteLine("Cat can eats");
        }
        public override void Voice()
        {
            Console.WriteLine($"Cat can mew. With age {Age} and weight {Weight}");
        }
    }
}
