using Hospital.Operation.OperationDomain;
using System;

namespace Hospital.Operation.TreatmentOperation
{
    class TreatmentSurgery : ISurgery
    {
        public string Type { get; }

        public DateTime Date { get; set; }
        public string Doctor { get; set; }
        public double Payment { get; set; }

        public TreatmentSurgery(string type, DateTime date, string doctor, double payment)
        {
            Type = type;
            Date = date;
            Doctor = doctor;
            Payment = payment;
        }
    }
}
