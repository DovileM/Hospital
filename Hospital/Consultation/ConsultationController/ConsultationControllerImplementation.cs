using Hospital.Consultation.ConsultationFacadeService;
using System;

namespace Hospital.Consultation.ConsultationController
{
    class ConsultationControllerImplementation : IConsultationController
    {
        IConsultationFacade facade;

        public ConsultationControllerImplementation(IConsultationFacade facade)
        {
            this.facade = facade;
        }

        public int AddClient(string name, string surname, string phone, DateTime birth)
        {
            return facade.AddClient(name, surname, phone, birth);
        }

        public int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            return facade.AddDoctor(name, surname, startDate, birth, cabinet);
        }

        public void VisitDocotor(int clientID, int doctorID, DateTime visitDate)
        {
            facade.VisitDocotor(clientID, doctorID, visitDate);
        }
    }
}
