using System;

namespace Hospital.Operation.OperationFacadeService
{
    interface IOperationFacade
    {
        DateTime GetSurgeryDate(int sergeryID);
        void CancelSurgery(int surgeryID, int surgeonID);
        int RegistSurgery(String type, DateTime date, String doctor, double payment);
        int RegistSurgeon(String name, String surname, DateTime birth, String surgeryType);
    }
}
