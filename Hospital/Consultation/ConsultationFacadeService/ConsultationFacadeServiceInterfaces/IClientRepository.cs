using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationFacadeService
{
    interface IClientRepository
    {
        IClient GetClient(int id);
        void DeleteClient(int id);
        int SaveClient(IClient client);
    }
}
