using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====2-D Array=====");
            int[,] A = new int[3,5];
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Enter the value of A[{0},{1}]: ", r, c);
                    A[r,c]=int.Parse(Console.ReadLine());
                }            
            }
            Console.WriteLine("\nA = ");
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(A[r, c].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
