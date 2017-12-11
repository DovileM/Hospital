using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationDomainService
{
    interface IPlasticOperationPayment
    {
        void PayForPlasticOperation(string doctor, double payment);
    }
}
