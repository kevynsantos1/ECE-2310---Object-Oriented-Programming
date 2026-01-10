using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dr_kleains_better_validation
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 0, n2 = 0;
            string str_n1, str_n2;
            bool valid1, valid2;
            do
            {
                Console.Write("How many students are there in section1,please? ");
                str_n1 = Console.ReadLine();
                valid1 = int.TryParse(str_n1, out n1);
                if (!valid1)
                    Console.WriteLine("Invalid! It has to be numeric. Please re-enter.");
                else if (n1 < 0)
                    Console.WriteLine("Invalid! It has to be a positive number. Please re-enter.");
                else if (n1 > 49)
                    Console.WriteLine("Invalid! It cannot be over 49. Please re-enter.");
                else
                    Console.WriteLine("Section1 has {0} students.", n1);
            } while (!valid1 || n1 < 0 || n1 > 49);
            do
            {
                Console.Write("How many students are there in section2,please? ");
                str_n2 = Console.ReadLine();
                valid2 = int.TryParse(str_n2, out n2);
                if (!valid2)
                    Console.WriteLine("Invalid! It has to be numeric. Please re-enter.");
                else if (n2 < 0)
                    Console.WriteLine("Invalid! It has to be a positive number. Please re-enter.");
                else if (n2 > 49)
                    Console.WriteLine("Invalid! It cannot be over 49. Please re-enter.");
                else
                    Console.WriteLine("Section2 has {0} students.", n2);
            } while (!valid2 || n2 < 0 || n2 > 49);
            if (n1 > n2)
                Console.WriteLine("Section1 is bigger");
            else if (n1 < n2)
                Console.WriteLine("Section2 is bigger");
            else
                Console.WriteLine("Section1 and section2 are of the same size");
            Console.Read();

        }
    }
}

        
