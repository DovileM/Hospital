using System;

namespace Hospital.Pharmacy.PharmacyUI
{
    class PharmacyConsole
    {
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
        }

        public void BuyMedicine()
        {
            Console.Write("Write MEDICINE ID to buy it.");
            int medicineID = Convert.ToInt32(Console.ReadLine());
        }
    }
}
