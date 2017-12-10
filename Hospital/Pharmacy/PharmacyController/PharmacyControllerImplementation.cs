using Hospital.Pharmacy.PharmacyFacadeService;
using System;

namespace Hospital.Pharmacy.PharmacyController
{
    class PharmacyControllerImplementation : IPharmacyController
    {
        IPharmacyFacade facade;

        public PharmacyControllerImplementation(IPharmacyFacade facade)
        {
            this.facade = facade;
        }

        public int AddMedicine(string name, string type, DateTime validity, int supplierID)
        {
            return facade.AddMedicine(name, type, validity, supplierID);
        }

        public int AddSupplier(string name, string phone, string address, string country)
        {
            return facade.AddSupplier(name, phone, address, country);
        }

        public string BuyMedicine(int medicineID)
        {
            return facade.BuyMedicine(medicineID);
        }
    }
}
