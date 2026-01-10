using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        private string employeeNum;
        private Name employeeName;
        private double monthlySalary;

        public Employee()
        {
            employeeNum = "123456";
            employeeName = new Name();
            monthlySalary = 10000;
        }

        public Employee(string num, Name nm, double sal)
        {
            employeeNum = num;
            employeeName = nm;
            monthlySalary = sal;
        }

        public Employee(string num, string fn, string ln, double sal)
        {
            employeeNum = num;
            employeeName = new Name(fn,ln);
            monthlySalary = sal;
        }

        public Name EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public override string ToString()
        {
            string outStr = "Employee number: " + employeeNum;
            outStr += ", Employee name: " + employeeName.ToString();
            outStr += ", Monthly Slary: $" + monthlySalary.ToString();
            return outStr;
        }
    }
}
