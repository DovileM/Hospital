using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationDomainService
{
    interface IPlasticOperationPayment
    {
        void PayForPlasticOperation(ISurgeon surgeon, ISurgery surgery, double payment);
    }
}
