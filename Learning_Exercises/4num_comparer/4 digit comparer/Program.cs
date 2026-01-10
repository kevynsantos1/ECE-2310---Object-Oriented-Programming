using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_digit_comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, x4;

            Console.WriteLine("Please input your first digit");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please input your second digit");
            string input2 = Console.ReadLine();
            Console.WriteLine("Please input your third digit");
            string input3 = Console.ReadLine();
            Console.WriteLine("Please input your fourth digit");
            string input4 = Console.ReadLine();

            x1 = Convert.ToDouble(input1);
            x2 = Convert.ToDouble(input2);
            x3 = Convert.ToDouble(input3);
            x4 = Convert.ToDouble(input4);

            if ((x1 > x2) && (x1 > x3) && (x1 > x4))
            {
                Console.WriteLine("Your largest input was: " + x1);
            }
            else if ((x2 > x1) && (x2 > x3) && (x2 > x4))
            {
                Console.WriteLine("Your largest input was: " + x2);
            }
            else if ((x3 > x1) && (x3 > x2) && (x3 > x4))
            {
                Console.WriteLine("Your largest input was: " + x3);
            }
            else if ((x4 > x1) && (x4 > x2) && (x4 > x3))
            {
                Console.WriteLine("Your largest input was: " + x4);
            }
            else
            {
                Console.WriteLine("I pooped myself");
            }
        }
    }
}
