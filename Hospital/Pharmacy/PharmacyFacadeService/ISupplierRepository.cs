using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    interface ISupplierRepository
    {
        ISupplier GetSupplier(int id);
        void DeleteSupplier(int id);
        void UpdateSupplier(ISupplier supplier);
        int SaveSupplier(ISupplier supplier);
    }
}
