using Hospital.Pharmacy.PharmacyController;
using System;

namespace Hospital.Pharmacy.PharmacyUI
{
    class PharmacyConsole
    {
        IPharmacyController controller;

        public PharmacyConsole(IPharmacyController controller)
        {
            this.controller = controller;
        }

        public void AddMedicine()
        {
            Console.WriteLine("Complete MEDICINE information");
            Console.Write("Name:          ");
            string name = Console.ReadLine();
            Console.Write("Type:          ");
            string type = Console.ReadLine();
            Console.Write("Validity date: ");
            DateTime validity = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Supplier ID:   ");
            int supplierID = Convert.ToInt32(Console.ReadLine());

            int id = controller.AddMedicine(name, type, validity, supplierID);
            Console.WriteLine("----Medicine id  =  " + id.ToString() + " ----");

        }

        public void AddSupplier()
        {
            Console.WriteLine("Complete SUPPLIER information");
            Console.Write("Name:          ");
            string name = Console.ReadLine();
            Console.Write("Phone:          ");
            string phone = Console.ReadLine();
            Console.Write("Address:          ");
            string address = Console.ReadLine();
            Console.Write("Country:          ");
            string country = Console.ReadLine();

            int id = controller.AddSupplier(name, phone, address, country);
            Console.WriteLine("----Supplier id  =  " + id.ToString() + " ----");
        }

        public void BuyMedicine()
        {
            Console.Write("Write MEDICINE ID to buy it.");
            int medicineID = Convert.ToInt32(Console.ReadLine());

            string id = controller.BuyMedicine(medicineID);
            Console.WriteLine("----Medicine price is  "+id+"$ ----");
        }
    }
}
