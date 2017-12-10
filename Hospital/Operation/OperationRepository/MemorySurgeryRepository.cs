using Hospital.Operation.OperationFacadeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationRepository
{
    class MemorySurgeryRepository : ISurgeryRepository
    {
        public void DeleteSurgery(int id)
        {
            
        }

        public ISurgery GetSurgery(int id)
        {
            return null;
        }

        public int SaveSurgery(ISurgery Surgery)
        {
            return 0;
        }

        public void UpdateSurgery(ISurgery Surgery)
        {
            
        }
    }
}
