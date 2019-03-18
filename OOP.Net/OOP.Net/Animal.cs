using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Net
{
    abstract class Animal 
    {
        private int _age;
        private double _weight;

        public int Age
        {
            get {  return _age;}
            set { _age = value;}
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Animal(int age, double weight)
        {
            Age = age;
            Weight = weight;
        }
        public abstract void Eat();

        public virtual void Voice()
        {
            Console.WriteLine("Animal have voice");
        }
    }
}
