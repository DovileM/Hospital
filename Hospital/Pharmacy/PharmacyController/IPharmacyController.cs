using System;

namespace Hospital.Pharmacy.PharmacyController
{
    interface IPharmacyController
    {
        int AddMedicine(string name, string type, DateTime validity, int supplierID);
        int AddSupplier(string name, string phone, string address, string country);
        string BuyMedicine(int medicineID);
    }
}
