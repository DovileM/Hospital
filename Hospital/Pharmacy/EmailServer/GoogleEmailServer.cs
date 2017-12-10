using Hospital.Pharmacy.PharmacyFacadeService;
using System;

namespace Hospital.Pharmacy.EmailServer
{
    class GoogleEmailServer : IEmailSender
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine("-----GOOGLE----");
            Console.WriteLine("Send to: " + to);
            Console.WriteLine("From:    " + "info@gmail.com");
            Console.WriteLine("|-| " + message + " |-|");
            Console.WriteLine("---------------");
        }
    }
}
