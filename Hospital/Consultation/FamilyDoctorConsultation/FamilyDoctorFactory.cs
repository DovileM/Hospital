using System;
using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.FamilyDoctorConsultation
{
    class FamilyDoctorFactory : IConsultationFactory
    {
        public IClient CreateClient(string name, string surname, string phone, DateTime birth)
        {
            return (new FamilyDoctorClient(name, surname, phone, birth));
        }

        public IDoctor CreateDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            return (new FamilyDoctor(name, surname, startDate, birth, cabinet));
        }
    }
}
