using System;


namespace Hospital.Consultation.ConsultationController
{
    interface IConsultationController
    {
        int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string Cabinet);
        int AddClient(string name, string surname, string phone, DateTime borth);
        void VisitDocotor(int clientID, int doctorID, DateTime visitDate);
        void CancelVisitation(int clientID, int doctorID, DateTime visitDate);
    }
}
