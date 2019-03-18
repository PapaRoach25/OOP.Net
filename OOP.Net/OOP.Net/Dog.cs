using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    class Dog : Animal
    {
        public Dog(int age, double weight)
            : base(age, weight) { }

        public override void Eat()
        {
            Console.WriteLine("Dog can eats");
        }
        public override void Voice()
        {
            Console.WriteLine($"Dog can bark. With age {Age} and weight {Weight}");
        }
    }
}
