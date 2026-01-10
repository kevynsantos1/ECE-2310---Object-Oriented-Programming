using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_classes
{
    class Student //class definition
    {
        //attributes-data members
        private string broncoID;
        private string name;
        private double gpa;
        //behaviors-member functions/methods
        public void Study()
        {
            Console.WriteLine("The student is studying.");
        }
        public void DispInfo()
        {
            Console.WriteLine("Bronco ID: {0}   Name: {1}   GPA: {2}", broncoID, name, gpa);
        }

        public void ChangeData(string ide, string namee, double gpae)
        {
            name = namee;
            broncoID = ide;
            gpa = gpae;
        }
    }
}
