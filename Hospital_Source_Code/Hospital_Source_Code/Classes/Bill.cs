using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class Bill
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int visitId { get; set; }

        public DateTime DateIssued { get; set; }
        public int PatientId { get; set; }
        public string Note { get; set; }
        public decimal MicellFee { get; set; }
        public decimal DoctorFee { get; set; }
        public decimal RoomCharge { get; set; }
    }
}
