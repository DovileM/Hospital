using Hospital.Consultation.ConsultationDomain;
using System;
using System.Collections.Generic;

namespace Hospital.Consultation.FamilyDoctorConsultation
{
    class FamilyDoctor : IDoctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; }
        public DateTime Birth { get; }
        public string Cabinet { get; set; }

        private Dictionary<IClient, DateTime> visit;

        public FamilyDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            Name = name;
            Surname = surname;
            StartDate = startDate;
            Birth = birth;
            Cabinet = cabinet;
            visit = new Dictionary<IClient, DateTime>();
        }

        public string SendForTreatment(string sendTo)
        {
            string doctor;
            if (sendTo.Equals("Psychologist"))
                doctor = "Psychologist";
            else if (sendTo.Equals("Dentist"))
                doctor = "Dentist";
            else
                doctor = "FamilyDoctor";
            return doctor;
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
