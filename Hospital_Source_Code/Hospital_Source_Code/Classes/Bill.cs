using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class Bill
    {
        public DateTime DateIssued { get; set; }
        public string Note { get; set; }
        public decimal MicellFee { get; set; }
        public decimal DoctorFee { get; set; }
        public decimal RoomCharge { get; set; }
    }
}
