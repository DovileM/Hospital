using Hospital.Operation.OperationFacadeService;
using Hospital.Operation.OperationDomain;
using System.Collections.Generic;

namespace Hospital.Operation.OperationRepository
{
    class MemorySurgeonRepository : ISurgeonRepository
    {
        Dictionary<int, ISurgeon> surgeon;
        static int number = 0;

        public MemorySurgeonRepository()
        {
            surgeon = new Dictionary<int, ISurgeon>();
        }

        public void DeleteSurgeon(int id)
        {
            surgeon.Remove(id);
        }

        public ISurgeon GetSurgeon(int id)
        {
            return surgeon[id];
        }

        public int SaveSurgeon(ISurgeon surgeon)
        {
            this.surgeon.Add(++number, surgeon);
            return number;
        }
    }
}
