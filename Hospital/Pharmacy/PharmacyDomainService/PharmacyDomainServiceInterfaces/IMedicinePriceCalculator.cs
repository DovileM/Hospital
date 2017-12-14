using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.PharmacyDomainService
{
    interface IMedicinePriceCalculator
    {
        double CalculatePrice(DateTime validity, ISupplier supplier);
    }
}
