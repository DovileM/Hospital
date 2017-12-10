using System;

namespace Hospital.Operation.OperationDomain
{
    interface ISurgery
    {
        string type { get; }
        DateTime date { get; set; }
        string doctor { get; set; }
        double payment { get; set; }
    }
}
