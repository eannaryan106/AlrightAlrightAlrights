using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string address, bool gender, string phoneNumber) {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }
    }
}
