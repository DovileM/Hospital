using Hospital.Operation.OperationFacadeService;
using System;

namespace Hospital.Operation.OperationController
{
    class OperationControllerImplementation : IOperationController
    {
        IOperationFacade facade;

        public OperationControllerImplementation(IOperationFacade facade)
        {
            this.facade = facade;
        }

        public void CancelSurgery(int surgeryID, int surgeonID)
        {
            facade.CancelSurgery(surgeryID, surgeonID);
        }

        public DateTime GetSurgeryDate(int surgeryID)
        {
            return facade.GetSurgeryDate(surgeryID);
        }

        public int RegistSurgeon(string name, string surname, DateTime birth, string type)
        {
            return facade.RegistSurgeon(name, surname, birth, type);
        }

        public int RegistSurgery(string type, DateTime date, string name, double payment)
        {
            return facade.RegistSurgery(type, date, name, payment);
        }
    }
}
