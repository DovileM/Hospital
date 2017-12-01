using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Consultation.ConsultationFacadeService
{
    interface IConsultationFacade
    {
        int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string Cabinet);
        int AddClient(string name, string surname, string phone, DateTime borth);
        void VisitDocotor(int clientID, int doctorID, DateTime visitDate);
        void CancelVisitation(int clientID, int doctorID, DateTime visitDate);
    }
}
