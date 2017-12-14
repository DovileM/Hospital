using System;
using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.PsychologistConsultation
{
    class PsychologistConsultationFactory : IConsultationFactory
    {
        public IClient CreateClient(string name, string surname, string phone, DateTime birth)
        {
            return (new PsychologistClient(name, surname, phone, birth));
        }

        public IDoctor CreateDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            return (new Psychologist(name, surname, startDate, birth, cabinet));
        }
    }
}
