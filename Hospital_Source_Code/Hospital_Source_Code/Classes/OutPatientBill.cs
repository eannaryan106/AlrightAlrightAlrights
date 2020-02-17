using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class OutPatientBill : Bill
    {
        public DateTime AppointmentDate { get; set; }
        public decimal TotalBill;

        public OutPatientBill(DateTime dateIssued, string note, decimal micellFee, decimal doctorFee,
            decimal roomCharge, decimal totalBill)
        {
            this.DateIssued = dateIssued;
            this.Note = note;
            this.MicellFee = micellFee;
            this.DoctorFee = doctorFee;
            this.RoomCharge = roomCharge;
            totalBill = getTotalBill(micellFee, doctorFee, roomCharge);
        }



        public decimal getTotalBill(decimal micellFee, decimal doctorFee, decimal roomCharge)
        {
            return 1.00m;
            //return (roomCharge + doctorFee + micellFee)
        }
    }
}
