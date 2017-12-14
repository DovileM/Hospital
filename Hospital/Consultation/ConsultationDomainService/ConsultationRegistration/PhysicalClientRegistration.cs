using System;
using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationDomainService
{
    class PhysicalClientRegistration : IClientRegistration
    {
        public void RegistClientToDoctor(IClient client, IDoctor doctor, DateTime visitDate)
        {
            Console.WriteLine("\n Physical \n");
            doctor.AddVisit(client, visitDate.AddDays(2));
        }
    }
}
