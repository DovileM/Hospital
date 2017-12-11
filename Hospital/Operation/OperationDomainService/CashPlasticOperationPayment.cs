using System;

namespace Hospital.Operation.OperationDomainService
{
    class CashPlasticOperationPayment : IPlasticOperationPayment
    {
        public void PayForPlasticOperation(string doctor, double payment)
        {
            Console.WriteLine("Thanks for your payment by CASH to " + doctor);
            Console.WriteLine("PAYMENT = " + payment);
        }
    }
}
