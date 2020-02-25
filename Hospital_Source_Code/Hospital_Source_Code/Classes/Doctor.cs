using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class Doctor : Person
    {
        public string Qualification { get; set; }
        public int DepartID { get; set; }
        public int ID { get; set; }

        public Doctor ()
        {

        }

        public Doctor(int id)
        {
            ID = id;
        }

        public Doctor (string firstName, string lastName, string address, bool gender, string phoneNumber, string qualification, int deptId)
            : base(firstName, lastName, address, gender, phoneNumber)
        {
            Qualification = qualification;
            DepartID = deptId;
        }

        public Doctor(int id, string firstName, string lastName, bool gender, string address, string phoneNumber, string qualification, int deptId)
            : base(firstName, lastName, address, gender, phoneNumber)
        {
            Qualification = qualification;
            DepartID = deptId;
            ID = id;
        }
    }
}
