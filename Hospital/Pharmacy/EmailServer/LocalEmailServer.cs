using Hospital.Pharmacy.PharmacyFacadeService;
using System;

namespace Hospital.Pharmacy.EmailServer
{
    class LocalEmailServer : IEmailSender
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine("\n------LOCAL-----");
            Console.WriteLine("Send to: " + to);
            Console.WriteLine("From:    " + "info@local.com");
            Console.WriteLine("|-|-| " + message + " |-|-|");
            Console.WriteLine("----------------\n");
        }
    }
}
