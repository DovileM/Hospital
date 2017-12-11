using Hospital.Operation.OperationFacadeService;
using System.Collections.Generic;
using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationRepository
{
    class MemorySurgeryRepository : ISurgeryRepository
    {
        Dictionary<int, ISurgery> surgery;
        static int number = 0;

        public MemorySurgeryRepository()
        {
            surgery = new Dictionary<int, ISurgery>();
        }

        public void DeleteSurgery(int id)
        {
            surgery.Remove(id);
        }

        public ISurgery GetSurgery(int id)
        {
            return surgery[id];
        }

        public int SaveSurgery(ISurgery surgery)
        {
            this.surgery.Add(++number, surgery);
            return number;
        }
    }
}
