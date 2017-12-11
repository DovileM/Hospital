using System;
using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationDomainService
{
    class ElectronicClientRegistation : IClientRegistration
    {
        public void RegistClientToDoctor(IClient client, IDoctor doctor, DateTime visitDate)
        {
            Console.WriteLine("\n ELECTRONIC \n");
            doctor.AddVisit(client, visitDate);
        }
    }
}
