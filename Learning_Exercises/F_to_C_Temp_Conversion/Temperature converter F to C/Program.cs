using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_converter_F_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp1;
            double temp2;
            Console.WriteLine("Welcome to Kevyn's Temperature Converter!");
            Console.WriteLine("Please input your temperature in Fahrenheit.");
            string F = Console.ReadLine();
            temp1 = Convert.ToDouble(F);
            temp2 = (temp1 - 32) * 5 / 9;
            temp2 = Math.Round(temp2,1);
            Console.WriteLine("Your temperature in Celcius is " + temp2);
                
        }
    }
}
