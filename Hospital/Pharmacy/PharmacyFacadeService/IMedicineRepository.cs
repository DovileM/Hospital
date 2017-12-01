using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    interface IMedicineRepository
    {
        IMedicine GetMedicine(int id);
        void DeleteMedicine(int id);
        void UpdateMedicine(IMedicine medicine);
        int SaveMedicine(IMedicine medicine);
    }
}
