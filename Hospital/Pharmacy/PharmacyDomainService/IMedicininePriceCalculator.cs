using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.PharmacyDomainService
{
    interface IMedicininePriceCalculator
    {
        double CalculatePrice(IMedicine medicine);
    }
}
