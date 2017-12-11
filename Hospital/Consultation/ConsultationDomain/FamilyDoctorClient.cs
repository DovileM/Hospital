using Hospital.Consultation.ConsultationDomain;
using System;


namespace Hospital.Consultation.FamilyDoctorConsultation
{
    class FamilyDoctorClient : IClient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; }

        public FamilyDoctorClient(string name, string surname, string phone, DateTime birth)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Birth = birth;
        }
    }
}
