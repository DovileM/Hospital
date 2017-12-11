using System;

namespace Hospital.Operation.OperationDomain
{
    interface ISurgery
    {
        string Type { get; }
        DateTime Date { get; set; }
        string Doctor { get; set; }
        double Payment { get; set; }
    }
}
