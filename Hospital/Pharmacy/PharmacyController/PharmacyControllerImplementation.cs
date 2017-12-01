using System;

namespace Hospital.Pharmacy.PharmacyController
{
    class PharmacyControllerImplementation : IPharmacyController
    {
        public int AddMedicine(string name, string type, DateTime validity, int supplierID)
        {
            return 0;
        }

        public int AddSupplier(string name, string phone, string address, string country)
        {
            return 0;
        }

        public string BuyMedicine(int medicineID)
        {
            return null;
        }
    }
}
