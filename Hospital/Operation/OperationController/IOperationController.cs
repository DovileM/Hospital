using System;

namespace Hospital.Operation.OperationController
{
    interface IOperationController
    {
        DateTime GetSurgeryDate(int sergeryID);
        void CancelSurgery(int surgeryID, int surgeonID);
        void ChangeSurgeryDate(int surgeryID, DateTime date);
    }
}
