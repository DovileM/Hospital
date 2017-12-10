using Hospital.Operation.OperationFacadeService;
using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationRepository
{
    class MemorySurgeonRepository : ISurgeonRepository
    {
        public void DeleteSurgeon(int id)
        {
           
        }

        public ISurgeon GetSurgeon(int id)
        {
            return null;
        }

        public int SaveSurgeon(ISurgeon surgeon)
        {
            return 0;
        }

        public void UpdateSurgeon(ISurgeon surgeon)
        {
           
        }
    }
}
