using Hospital.Pharmacy.PharmacyFacadeService;
using Hospital.Pharmacy.PharmacyDomain;
using System.Collections.Generic;

namespace Hospital.Pharmacy.PharmacyRepository
{
    class MemorySupplierRepository : ISupplierRepository
    {
        Dictionary<int, ISupplier> supplier;
        static int number;

        public MemorySupplierRepository()
        {
            supplier = new Dictionary<int, ISupplier>();
        }

        public void DeleteSupplier(int id)
        {
            supplier.Remove(id);
        }

        public ISupplier GetSupplier(int id)
        {
            return supplier[id];
        }

        public int SaveSupplier(ISupplier supplier)
        {
            this.supplier.Add(++number, supplier);
            return number;
        }
    }
}
