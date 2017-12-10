using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationFacadeService
{
    interface ISurgeryRepository
    {
        ISurgery GetSurgery(int id);
        void DeleteSurgery(int id);
        void UpdateSurgery(ISurgery Surgery);
        int SaveSurgery(ISurgery Surgery);
    }
}
