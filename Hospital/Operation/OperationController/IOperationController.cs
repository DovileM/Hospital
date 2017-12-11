using System;

namespace Hospital.Operation.OperationController
{
    interface IOperationController
    {
        DateTime GetSurgeryDate(int sergeryID);
        void CancelSurgery(int surgeryID, int surgeonID);
        int RegistSurgeon(string name, string surname, DateTime birth, string type);
        int RegistSurgery(string type, DateTime date, string name, double payment);
    }
}
