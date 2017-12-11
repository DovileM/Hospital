using Hospital.Operation.OperationDomain;
using Hospital.Operation.OperationDomainService;
using System;

namespace Hospital.Operation.OperationFacadeService
{
    class OperationFacadeImplementation : IOperationFacade
    {
        ISurgeonRepository surgeonRepo;
        ISurgeryRepository surgeryRepo;
        IOperationFactory factory;
        IPlasticOperationPayment payment;

        public OperationFacadeImplementation(ISurgeonRepository surgeonRepo, ISurgeryRepository surgeryRepo, IOperationFactory factory, IPlasticOperationPayment payment)
        {
            this.surgeonRepo = surgeonRepo;
            this.surgeryRepo = surgeryRepo;
            this.factory = factory;
            this.payment = payment;
        }

        public object ISurgery { get; private set; }

        public void CancelSurgery(int surgeryID, int surgeonID)
        {
            surgeryRepo.DeleteSurgery(surgeryID);
            surgeonRepo.DeleteSurgeon(surgeonID);
        }

        public DateTime GetSurgeryDate(int surgeryID)
        {
            ISurgery surgery = surgeryRepo.GetSurgery(surgeryID);
            return surgery.Date;
        }

        public int RegistSurgeon(string name, string surname, DateTime birth, string surgeryType)
        {
            ISurgeon surgeon = factory.CreateSurgeon(name, surname, birth, surgeryType);
            return surgeonRepo.SaveSurgeon(surgeon);
        }

        public int RegistSurgery(string type, DateTime date, string doctor, double payment)
        {
            ISurgery surgery = factory.CreateSurgery(type, date, doctor, payment);
            this.payment.PayForPlasticOperation(doctor, payment);
            return surgeryRepo.SaveSurgery(surgery);
        }
    }
}
