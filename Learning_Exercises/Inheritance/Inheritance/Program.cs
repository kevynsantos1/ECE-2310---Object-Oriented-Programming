using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTING DOG CLASS");
            Dog[] d = new Dog[2];
            d[0] = new Dog();
            d[1] = new Dog("chihuahua", 7);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("d[{0}] is {1}", i, d[i].ToString());
            }
            d[1].Bark();
            d[0].Move();
            d[0].Age = 3;
            d[0].Breed = "husky";
            Console.WriteLine("d[0] is actually a {0}", d[0].ToString());

            //test bird class
            Console.WriteLine("\n\nTESTING BIRD CLASS");
            Bird[] b = new Bird[2];
            b[0] = new Bird();
            b[1] = new Bird("yellow", 2);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("b[{0}] is {1}", i, b[i].ToString());
            }
            b[0].Move();
            b[1].Chirp();


            Animal[] a = new Animal[3];
            a[0] = new Bird("green", 2);
            a[1] = new Dog("husky", 9);
            a[2] = new Bird();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("a[{0}]  is {1}", i, a[i].ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                a[i].Move();  
            }

            int[] ages = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ages[i] = a[i].Age;
            }
            int location = 0, high = 0;



                Bird x1 = new Bird();
            Dog x2 = new Dog( );
            x1.Move();
            x2.Move();

                Console.Read();
        }
    }
}
