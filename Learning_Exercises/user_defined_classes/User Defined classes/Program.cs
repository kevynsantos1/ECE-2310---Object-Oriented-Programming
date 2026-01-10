using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate objects of Student Class
            Student stud01 = new Student();
            Student stud02 = new Student();
            Student stud03 = new Student();

            stud01.ChangeData("12345", "Kev", 4.4);

            //use objects to call member functions
            Console.WriteLine("----Student #1----");
            stud01.DispInfo();
            Console.WriteLine("----Student #2----");
            stud02.DispInfo();
            Console.WriteLine("----Student #3----");
            stud03.DispInfo();

            Console.Read();

        }
    }
}
