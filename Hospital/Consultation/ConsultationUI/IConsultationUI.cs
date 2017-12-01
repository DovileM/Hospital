using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Consultation.ConsultationUI
{
    interface IConsultationUI
    {
        void AddDoctor();
        void AddClient();
        void VisitDoctor();
        void CancelVisitation();
    }
}
