using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog:Animal    //inheritance states that the dog has all properties of an animal
    {
        private string breed;

        public Dog() : base()
        {
            breed = "unknown breed";
        }

        public Dog(string b, int a) : base(a)
        {
            breed = b;
        }

        public void Bark()
        {
            Console.WriteLine("The {0}-year-old {1} is barking.", age, breed);
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return "A " + breed + " dog of age " + age.ToString();
        }

        public override void Move()
        {
            Console.WriteLine("The {0} dog is running fast", breed);
        }
    }
}
