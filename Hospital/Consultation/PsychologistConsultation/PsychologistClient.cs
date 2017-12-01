using Hospital.Consultation.ConsultationDomain;
using System;

namespace Hospital.Consultation.PsychologistConsultation
{
    class PsychologistClient : IClient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; }

        public PsychologistClient(string name, string surname, string phone, DateTime birth)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Birth = birth;
        }

        public bool ShoudHaveRefferal()
        {
            return false;
        }
    }
}
