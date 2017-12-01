using Hospital.Consultation.ConsultationDomain;
using System;

namespace Hospital.Consultation.PsychologistConsultation
{
    class Psychologist : IDoctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; } 
        public DateTime Birth { get; }
        public string Cabinet { get; set; }

        public Psychologist(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            Name = name;
            Surname = surname;
            StartDate = startDate;
            Birth = birth;
            Cabinet = cabinet;
        }

        public string SendForTreatment(string sendTo)
        {
            return sendTo;
        }
    }
}
