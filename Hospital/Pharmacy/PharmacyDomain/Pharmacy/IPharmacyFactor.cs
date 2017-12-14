using System;

namespace Hospital.Pharmacy.PharmacyDomain
{
    interface IPharmacyFactor
    {
        IMedicine CreateMedicine(string name, string type, DateTime validity, double price);
        ISupplier CreateSupplier(string name, string phone, string fullAdress);
    }
}
