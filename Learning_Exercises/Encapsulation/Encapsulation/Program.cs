using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 1.345;
            Console.WriteLine("x=" + x.ToString());
            Name test = new Name("Jack", "Doe");
            Console.WriteLine("Test is " + test.ToString());


            Name[] names = new Name[3];
            names[0] = new Name();
            names[1] = new Name("Jane", "Wang");
            names[2] = new Name("Eric");
            


            for (int i = 0; i < 3; i++)
            {
                Console.Write(" #{0}\t{1}\n", i + 1, names[i].ToString());
                //names[i].DisplayName();
            }
            names[2].SetLastName("Jackson");
            Console.WriteLine("#3 changed to "+names[2].ToString());
            //names[2].DisplayName();

            Console.WriteLine("What is the name of studnet #2?");
            Console.WriteLine("It is {0}", names[1].GetFirstName());

            Console.WriteLine("\n-----using properties-----");
            names[0].FirstName = "Andy";
            names[0].LastName = "Garcia";
            Console.WriteLine("#1 is now "+names[0].ToString());
            //names[0].DisplayName();


            Console.WriteLine("\n-----Testing Employee Class-----");
            Employee[] emp = new Employee[3];
            emp[0] = new Employee();
            emp[1] = new Employee("632190", names[1], 3000);
            emp[2] = new Employee("888888", "Paul", "Smith", 4000);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" #{0}\t{1}", i + 1, emp[i].ToString());
            }
         



            Console.Read();
        }
    }
}
