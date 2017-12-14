namespace Hospital.Pharmacy.PharmacyFacadeService
{
    interface IEmailSender
    {
        void SendEmail(string to, string message);
    }
}
