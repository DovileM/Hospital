using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationDomainService
{
    interface IClientRegistration
    {
        void RegistClientToDoctor(IClient client, IDoctor doctor);
    }
}
