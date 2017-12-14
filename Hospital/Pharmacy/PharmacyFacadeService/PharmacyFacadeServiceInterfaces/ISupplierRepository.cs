using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    interface ISupplierRepository
    {
        ISupplier GetSupplier(int id);
        void DeleteSupplier(int id);
        int SaveSupplier(ISupplier supplier);
    }
}
