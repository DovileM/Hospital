using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.NaturalPharmacy
{
    class NaturalMedicineSupplierFactory : IPharmacyFactor
    {
        public IMedicine CreateMedicine(string name, string type, DateTime validity, double price)
        {
            return (new NaturalMedicine(name, type, validity, price));
        }

        public ISupplier CreateSupplier(string name, string phone, string fullAdress)
        {
            return (new NaturalSupplier(name, phone, fullAdress));
        }
    }
}
