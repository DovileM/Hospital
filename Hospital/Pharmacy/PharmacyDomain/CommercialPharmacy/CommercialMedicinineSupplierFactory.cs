using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.CommercialPharmacy
{
    class CommercialMedicinineSupplierFactory : IPharmacyFactor
    {
        public IMedicine CreateMedicine(string name, string type, DateTime validity, double price)
        {
            return (new CommercialMedicine(name, type, validity, price));
        }

        public ISupplier CreateSupplier(string name, string phone, string fullAdress)
        {
            return (new CommercialSupplier(name, phone, fullAdress));
        }
    }
}
