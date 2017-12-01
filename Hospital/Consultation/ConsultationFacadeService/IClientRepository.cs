using Hospital.Consultation.ConsultationDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Consultation.ConsultationFacadeService
{
    interface IClientRepository
    {
        IClient GetClient(int id);
        void DeleteClient(int id);
        void UpdateClient(IClient client);
        int SaveClient(IClient client);
    }
}
