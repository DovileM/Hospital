using Hospital.Consultation.ConsultationFacadeService.ConsultationFacadeServiceInterfaces;
using Hospital.Pharmacy.PharmacyFacadeService;

namespace Hospital.Common
{
    class MailAdapter : IEmailSenderConsultation
    {
        private IEmailSender pharmacyEmailSender;

        public MailAdapter(IEmailSender pharmacyEmailSender)
        {
            this.pharmacyEmailSender = pharmacyEmailSender;
        }

        public void SendMail(string to, string message)
        {
            pharmacyEmailSender.SendEmail(to, message);
        }
    }
}
