using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_A_Raise
{
    class Program
    {
        static void Main(string[] args)
        {


            double CurSal = 80000;
            double rate = 0.12;
            Console.WriteLine("The raised salary would be {0:C2}", GetARaise(CurSal, rate));
            DisplSalary(2000, 0.12);
            double[] pay = {1000, 2000, 3000, 4000, 5000};
            double[] new_pay = GetARaise(pay, rate);
            DispArray(new_pay);
            Console.Read();
        }

        static double GetARaise(double s, double rate)
        {
            return s * (1 + rate);
        }

        static void DisplSalary(double s, double rate)
        {
        Console.WriteLine("The raised salary is {0:C2}", s * (1 + rate));
        }

        static void DispArray(double [] a)
        {
            for (int i = 0; i< a.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", i, a[i]);
            }
        }

        static double[] GetARaise(double[] s, double rate)
        {
            double[] new_s = new double[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                new_s[i] = s[i] * (1 + rate);
            }

            return new_s;
        }

        static void DispSalary(double [] s, double rate)
        {
            DispArray(GetARaise(s, rate));
        }


    }
}
