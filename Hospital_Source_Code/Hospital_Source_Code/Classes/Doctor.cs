﻿using System;
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
    }
}
