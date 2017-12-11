using System;
using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.TreatmentOperation
{
    class TreatmentFactory : IOperationFactory
    {
        public ISurgeon CreateSurgeon(string name, string surname, DateTime birth, string surgeryType)
        {
            return (new TreatmentSurgeon(name, surname, birth, surgeryType));
        }

        public ISurgery CreateSurgery(string type, DateTime date, string doctor, double payment)
        {
            return (new TreatmentSurgery(type, date, doctor, payment));
        }
    }
}
