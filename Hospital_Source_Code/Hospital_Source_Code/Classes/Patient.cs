﻿using System;
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
        public DateTime birth { get; set; }

        public Patient()
        {

        }

        public Patient(int id)
        {
            PatientID = id;
        }

        public Patient(string firstName, string lastName, DateTime DOB, string address, bool gender, string phoneNumber, string nextOfKin)
            : base(firstName, lastName, address, gender, phoneNumber)
        {
            NextOfKin = nextOfKin;
            birth = DOB;
        }

        public Patient(int id, string firstName, string lastName, DateTime dob, string address, bool gender, string phoneNumber, string nextOfKin)
    : base(firstName, lastName, address, gender, phoneNumber)
        {
            NextOfKin = nextOfKin;
        }
    }
}
