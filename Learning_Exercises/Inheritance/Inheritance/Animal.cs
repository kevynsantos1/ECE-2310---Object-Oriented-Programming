using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animal
    {
        protected int age;

        public Animal()
        {
            age = 1;
        }

        public Animal(int a)
        {
            age = a;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        /*public virtual void Move()
        {
            Console.WriteLine("The {0}-year old animal is moving fast", age);
        }*/

        public abstract void Move();

        public override string ToString()
        {
            return "Animal of Age "+age.ToString();
        }

        ~Animal() { }
    }
}
