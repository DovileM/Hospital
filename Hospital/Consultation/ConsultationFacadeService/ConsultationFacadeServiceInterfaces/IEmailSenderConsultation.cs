namespace Hospital.Consultation.ConsultationFacadeService.ConsultationFacadeServiceInterfaces
{
    interface IEmailSenderConsultation
    {
        void SendMail(string to, string message);
    }
}
