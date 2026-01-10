using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[] x = { 0.5, 1.5, 2.5, 3.5, 4.5 };
            for(int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x [{0}] = {1}", i, x[i]);
            }
            Console.Read();*/


            int[] y = new int[12];
            Random xobj = new Random();
            int k = 0;
            bool exist = false;
            int key = 8;
            int j = 0;
            int big = 0;
            int where = 0;

            for (k = 0; k < y.Length; k++)
            {
                int a = xobj.Next(1, 11);
                y[k] = a;
                Console.WriteLine("y [{0}] = {1}", k, y[k]);
            }

            for (k = 0; k < y.Length; k++)
            {
                if (y[k] == key)
                {
                    Console.WriteLine("y [{0}] is equal to {1}", k, key);
                    exist = true;
                }
                if (y[k] >= key)
                {
                    j++;
                }
                if (y[k] > big)
                {
                    big = y[k];
                }
            }

            for (int i=0; i < y.Length; i++)
            {
                if (big == y[i])
                {
                    where = i;
                    Console.WriteLine("Element of index {0} is the largest", where);
                }
            }
            Console.WriteLine("The biggest value was {0}", big);

            if (!exist)
            {
                Console.WriteLine("No value is equal to {0}", key);
            }
            Console.WriteLine("There are {0} values greater than and/or equal to {1}", j, key);

            Array.Sort(y);
            Console.WriteLine("\nAfter sorting: ");
            for (int i=0; i < y.Length; i++)
            {
                Console.WriteLine("y[{0}]={1}", i, y[i]);
            }
            Array.Reverse(y);
            Console.WriteLine("\nAfter reversing: ");
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("y[{0}]={1}", i, y[i]);
            }



            Console.Read();



        }
    }
}
