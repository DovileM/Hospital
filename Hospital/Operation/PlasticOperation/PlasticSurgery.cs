using Hospital.Operation.OperationDomain;
using System;

namespace Hospital.Operation.PlasticOperation
{
    class PlasticSurgery : ISurgery
    {
        public string Type { get; }

        public DateTime Date { get; set; }
        public string Doctor { get; set; }
        public double Payment { get; set; }

        public PlasticSurgery(string type, DateTime date, string doctor, double payment)
        {
            Type = type;
            Date = date;
            Doctor = doctor;
            Payment = payment;
        }
    }
}
