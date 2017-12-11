using Hospital.Operation.OperationController;
using System;

namespace Hospital.Operation.OperationUI
{
    class OperationConsole
    {
        IOperationController controller;

        public OperationConsole(IOperationController controller)
        {
            this.controller = controller;
        }

        public void CancelSurgery()
        {
            Console.WriteLine("Write information about SURGERY.");
            Console.Write("Surgery's ID: ");
            int surgeryID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Surgeon's ID: ");
            int surgeonID = Convert.ToInt32(Console.ReadLine());
            controller.CancelSurgery(surgeryID, surgeonID);

            Console.WriteLine("Surgery has been canceled.");
        }

        public void GetSurgeryDate()
        {
            Console.WriteLine("Write information about SURGERY to get date.");
            Console.Write("Sugery's ID: ");
            int surgeryID = Convert.ToInt32(Console.ReadLine());

            DateTime date = controller.GetSurgeryDate(surgeryID);
            Console.WriteLine("----Surgery date is " + date.ToShortDateString() + " ----");

        }

        public void RegistOperation()
        {
            Console.WriteLine("Write if you want to add surgeon");
            int add = Convert.ToInt32(Console.ReadLine());
            string type, name;
            if ( add == 1)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Birth date: ");
                DateTime birth = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Surgery type: ");
                type = Console.ReadLine();

                int id1 = controller.RegistSurgeon(name, surname, birth, type);
                Console.WriteLine("----Surgeon id  =  " + id1.ToString() + " ----");

            }
            else
            {
                Console.Write("Doctor's name: ");
                name = Console.ReadLine();
                Console.Write("Surgery type: ");
                type = Console.ReadLine();
            }
            Console.Write("Operation date:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Payment: ");
            double payment = Convert.ToDouble(Console.ReadLine());

            int id = controller.RegistSurgery(type, date, name, payment);
            Console.WriteLine("----Surgery id  =  " + id.ToString() + " ----");


        }
    }
}
