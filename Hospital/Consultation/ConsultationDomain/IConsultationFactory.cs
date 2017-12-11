using System;

namespace Hospital.Consultation.ConsultationDomain
{
    interface IConsultationFactory
    {
        IClient CreateClient(string name, string surname, string phone, DateTime birth);
        IDoctor CreateDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet);
    }
}
