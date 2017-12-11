using System;

namespace Hospital.Operation.OperationDomain
{
    interface IOperationFactory
    {
        ISurgery CreateSurgery(string type, DateTime date, string doctor, double payment);
        ISurgeon CreateSurgeon(string name, string surname, DateTime birth, string surgeryType);
    }
}
