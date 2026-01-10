using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird:Animal
    {
        private string color;
        

        public Bird():base()
        {
            color = "Unknown";
        }

        public Bird(string c, int a) : base(a)
        {
            color = c;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Chirp()
        {
            Console.WriteLine("The {0} bird is chirping happily", color);
        }

        public override string ToString()
        {
            return "A " + color + " bird of age " + age;
        }

        public override void Move()
        {
            Console.WriteLine("The {0} bird is flying high", color); 
        }

        ~Bird() { }

    }
}
