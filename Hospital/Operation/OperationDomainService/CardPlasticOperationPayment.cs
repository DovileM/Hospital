using System;

namespace Hospital.Operation.OperationDomainService
{
    class CardPlasticOperationPayment : IPlasticOperationPayment
    {
        public void PayForPlasticOperation(string doctor, double payment)
        {
            Console.WriteLine("Thanks for your payment by CARD to " + doctor);
            Console.WriteLine("PAYMENT = " + payment);
        }
    }
}
