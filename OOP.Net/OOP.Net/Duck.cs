using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    class Duck : Animal , IFly
    {
        public Duck(int age, double weight)
            : base(age, weight) { }

        public override void Eat()
        {
            Console.WriteLine("Duck can eats");
        }
        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }

    }
}
