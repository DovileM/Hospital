using System;

namespace Hospital.Operation.OperationDomain
{
    interface ISurgeon
    {
        string Name { get; }
        string Surname { get; set; }
        DateTime Birth { get; set; }
        string SurgeryType { get; set; }
    }
}
