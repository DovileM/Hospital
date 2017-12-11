using Hospital.Consultation.ConsultationDomain;
using System;

namespace Hospital.Consultation.ConsultationDomainService
{
    interface IClientRegistration
    {
        void RegistClientToDoctor(IClient client, IDoctor doctor, DateTime visitDate);
    }
}
