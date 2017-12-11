using Hospital.Consultation.ConsultationDomain;
using System;
using System.Collections.Generic;

namespace Hospital.Consultation.PsychologistConsultation
{
    class Psychologist : IDoctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; } 
        public DateTime Birth { get; }
        public string Cabinet { get; set; }

        private Dictionary<IClient, DateTime> visit;

        public Psychologist(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            Name = name;
            Surname = surname;
            StartDate = startDate;
            Birth = birth;
            Cabinet = cabinet;
            visit = new Dictionary<IClient, DateTime>();
        }

        public void AddVisit(IClient client, DateTime visitDate)
        {
            visit.Add(client, visitDate);
        }

        public void CancelVisit(IClient client)
        {
            visit.Remove(client);
        }
    }
}
