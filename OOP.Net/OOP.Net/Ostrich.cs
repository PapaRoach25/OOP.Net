﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    class Ostrich : Animal
    {
        public Ostrich(int age, double weight)
            : base(age, weight) { }

        public override void Eat()
        {
            Console.WriteLine("Ostrich can eats");
        }

    }
}
