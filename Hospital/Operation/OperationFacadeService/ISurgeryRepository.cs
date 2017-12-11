using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationFacadeService
{
    interface ISurgeryRepository
    {
        ISurgery GetSurgery(int id);
        void DeleteSurgery(int id);
        int SaveSurgery(ISurgery surgery);
    }
}
