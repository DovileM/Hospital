using System;


namespace Hospital.Consultation.ConsultationController
{
    interface IConsultationController
    {
        int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet);
        int AddClient(string name, string surname, string phone, DateTime birth);
        void VisitDocotor(int clientID, int doctorID, DateTime visitDate);
    }
}
