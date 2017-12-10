using System;

namespace Hospital.Operation.OperationFacadeService
{
    interface IOperationFacade
    {
        DateTime GetSurgeryDate(int sergeryID);
        void CancelSurgery(int surgeryID, int surgeonID);
        void ChangeSurgeryDate(int surgeryID, DateTime date);
    }
}
