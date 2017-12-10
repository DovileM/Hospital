using System;

namespace Hospital.Operation.OperationDomain
{
    interface ISurgeon
    {
        string name { get; }
        string surname { get; set; }
        DateTime birth { get; set; }
        string surgeryType { get; set; }
    }
}
