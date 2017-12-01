using System;

namespace Hospital.Consultation.ConsultationDomain
{
    interface IClient
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
        DateTime Birth { get; }

        bool ShoudHaveRefferal();
    }
}
