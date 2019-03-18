using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(3, 4);
            Dog dog = new Dog(8, 6);
            Ostrich ostrich = new Ostrich(10, 40);
            Duck duck = new Duck(1, 4);

            duck.Eat();
            duck.Fly();

            dog.Eat();
            dog.Voice();

            ostrich.Eat();
           
            cat.Eat();
            cat.Voice();

            Console.ReadLine();

        }
    }
}
