using System;
using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.PlasticOperation
{
    class PlasticFactory : IOperationFactory
    {
        public ISurgeon CreateSurgeon(string name, string surname, DateTime birth, string surgeryType)
        {
            return (new PlasticSurgeon(name, surname, birth, surgeryType));
        }

        public ISurgery CreateSurgery(string type, DateTime date, string doctor, double payment)
        {
            return (new PlasticSurgery(type, date, doctor, payment));
        }
    }
}
