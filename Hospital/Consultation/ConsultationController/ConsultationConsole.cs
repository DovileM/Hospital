using Hospital.Consultation.ConsultationController;
using System;

namespace Hospital.Consultation.ConsultationUI
{
    class ConsultationConsole
    {
        IConsultationController controller;

        public ConsultationConsole(IConsultationController controller)
        {
            this.controller = controller;
        }

        public void AddClient()
        {
            Console.WriteLine("Complete CLIENT information");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Brith: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());

            int id = controller.AddClient(name, surname, phone, birth);
            Console.WriteLine("----Client id  =  " + id.ToString() + " ----");
        }

        public void AddDoctor()
        {
            Console.WriteLine("Complete DOCTOR information");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Start date: ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Brith: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Cabinet: ");
            string cabinet = Console.ReadLine();

            int id = controller.AddDoctor(name, surname, startDate, birth, cabinet);
            Console.WriteLine("----Doctor id  =  " + id.ToString() + " ----");
        }

        public void VisitDoctor()
        {
            Console.WriteLine("Write information to regist your visit");
            Console.Write("Your ID: ");
            int clientID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor's ID: ");
            int doctorID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Visit date: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            controller.VisitDocotor(clientID, doctorID, date);

            Console.WriteLine("Your visit has been registed.");
        }
    }
}
