using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    public class InPatientBill : Bill
    {

        public DateTime AddmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public int TotalDays;
        public decimal TotalBill;

        public InPatientBill(DateTime dateIssued, string note, decimal micellFee, decimal doctorFee,
            decimal roomCharge, DateTime addmissionDate, DateTime dischargeDate, int totalDays, decimal totalBill)
        {
            this.DateIssued = dateIssued;
            this.Note = note;
            this.MicellFee = micellFee;
            this.DoctorFee = doctorFee;
            this.RoomCharge = roomCharge;
            this.AddmissionDate = addmissionDate;
            this.DischargeDate = dischargeDate;
            totalDays = getTotalDays(addmissionDate, dischargeDate);
            totalBill = getTotalBill(totalDays, doctorFee, roomCharge, micellFee);

        }

        public int getTotalDays(DateTime AddmissionDate, DateTime DischargeDate)
        {
            return (DischargeDate.Date - AddmissionDate.Date).Days;
        }

        public decimal getTotalBill(int totalDays, decimal DoctorsFee, decimal RoomCharge,
            decimal MiscellFee)
        {
            // Calculation
            // return (roomType.cost * totalDays) + DoctorFee + MiscellFee) 
            return 1.00m;
        }
    }
}
