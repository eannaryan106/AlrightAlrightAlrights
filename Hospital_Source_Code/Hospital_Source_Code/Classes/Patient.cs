using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public string NextOfKin { get; set; }

        public Patient()
        {

        }

        public Patient(string firstName, string lastName, DateTime dob, string address, bool gender, string phoneNumber, string nextOfKin)
            : base(firstName, lastName, address, gender, phoneNumber)
        {
            NextOfKin = nextOfKin;
        }
    }
}
