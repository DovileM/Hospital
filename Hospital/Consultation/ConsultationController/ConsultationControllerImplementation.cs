using System;

namespace Hospital.Consultation.ConsultationController
{
    class ConsultationControllerImplementation : IConsultationController
    {
        public int AddClient(string name, string surname, string phone, DateTime borth)
        {
            //TO DO
            return 0;
        }

        public int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string Cabinet)
        {
            //TO DO
            return 0;
        }

        public void CancelVisitation(int clientID, int doctorID, DateTime visitDate)
        {
            //TO DO
        }

        public void VisitDocotor(int clientID, int doctorID, DateTime visitDate)
        {
            //TO DO
        }
    }
}
