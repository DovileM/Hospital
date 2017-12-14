using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.PharmacyDomainService
{
    class PVMMedicinePriceCalculator : IMedicinePriceCalculator
    {
        public double CalculatePrice(DateTime validity, ISupplier supplier)
        {
            if (validity.Year < 2019)
                return validity.Day * 3 + (validity.Day * 3) * 0.21;
            else if (validity.Year < 2020)
                return validity.Day + validity.Month + (validity.Day + validity.Month) * 0.21;
            else
                return validity.Day * validity.Month + (validity.Day * validity.Month) * 0.21;
        }
    }
}
