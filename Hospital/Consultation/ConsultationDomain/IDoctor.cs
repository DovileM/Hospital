using System;

namespace Hospital.Consultation.ConsultationDomain
{
    interface IDoctor
    {
        string Name { get; set; }
        string Surname { get; set; }
        DateTime StartDate { get; }
        DateTime Birth { get; }
        string Cabinet { get; set; }

        void AddVisit(IClient client, DateTime visitDate);
        void CancelVisit(IClient client);
    }
}
