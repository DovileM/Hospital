using System;

namespace Hospital.Operation.OperationFacadeService
{
    class OperationFacadeImplementation : IOperationFacade
    {
        public void CancelSurgery(int surgeryID, int surgeonID)
        {
            
        }

        public void ChangeSurgeryDate(int surgeryID, DateTime date)
        {
            
        }

        public DateTime GetSurgeryDate(int sergeryID)
        {
            return DateTime.Now;
        }
    }
}
