using Hospital.Operation.OperationDomain;
using System;

namespace Hospital.Operation.TreatmentOperation
{
    class TreatmentSurgery : ISurgery
    {
        public string type { get; }

        public DateTime date { get; set; }
        public string doctor { get; set; }
        public double payment { get; set; }

        public TreatmentSurgery(string type, DateTime date, string doctor, double payment)
        {
            this.type = type;
            this.date = date;
            this.doctor = doctor;
            this.payment = payment;
        }
    }
}
