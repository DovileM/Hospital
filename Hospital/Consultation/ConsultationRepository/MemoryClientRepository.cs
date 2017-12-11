using Hospital.Consultation.ConsultationFacadeService;
using Hospital.Consultation.ConsultationDomain;
using System.Collections.Generic;

namespace Hospital.Consultation.ConsultationRepository
{
    class MemoryClientRepository : IClientRepository
    {
        Dictionary<int, IClient> client;
        static int number = 0;

        public MemoryClientRepository()
        {
            client = new Dictionary<int, IClient>();
        }

        public void DeleteClient(int id)
        {
            client.Remove(id);
        }

        public IClient GetClient(int id)
        {
            return client[id];
        }

        public int SaveClient(IClient client)
        {
            this.client.Add(++number, client);
            return number;
        }
    }
}
