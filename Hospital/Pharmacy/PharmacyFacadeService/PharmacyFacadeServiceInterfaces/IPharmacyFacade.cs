using System;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    interface IPharmacyFacade
    {
        int AddMedicine(string name, string type, DateTime validity, int supplierID);
        int AddSupplier(string name, string phone, string address, string country);
        string BuyMedicine(int medicineID);
    }
}
