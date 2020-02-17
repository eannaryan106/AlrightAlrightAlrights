using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class VisitDetails : PatientDetails
    {
        public int DoctorId { get; set; }
        public int DepartId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public int BedId { get; set; }
        public DateTime Appointment { get; set; }

    }
}
