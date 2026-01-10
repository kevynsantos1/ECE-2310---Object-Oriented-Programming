using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Name
    {
        private string firstName;
        private string lastName;
        public Name() //in the case name is created with no names
        {
            firstName = "Unknown";
            lastName = "Unknown";
        }
        public Name(string fn, string ln) //in the case name is created with both names
        {
            firstName = fn;
            lastName = ln;
        }
        public Name(string fn) //in the case name is created with only first name
        {
            firstName = fn;
            lastName = "Unknown";
        }
        public void DisplayName()
        {
            Console.WriteLine("The name is: {0} {1}", firstName, lastName);
        }
        //mutators also known as setters
        public void SetLastName(string newLN) //allows us to set a last name
        {
            lastName = newLN;
        }
        public void SetFirstName(string newFN) //allows us to set a first name
        {
            firstName = newFN;
        }
        //Accessors also known as getters
        public string GetFirstName() //only returns the first name
        {
            return firstName;
        }
        public string GetLastName() //only returns the last name
        {
            return lastName;
        }
        //properties
        public string FirstName //setters and getters in one. if you ask to get youll get the return value, if you set it wil replace firstname with the given value
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public override string ToString() 
        {
            return firstName + " " + lastName;
        }

        //destructor
        ~Name() {  }
    }
   
}
