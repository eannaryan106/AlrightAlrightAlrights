using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class TestDetails : PatientDetails
    {
        public DateTime DiagnosisDate { get; set; }
        public string Note { get; set; }
    }
}
