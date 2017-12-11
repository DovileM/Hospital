using Hospital.Pharmacy.PharmacyFacadeService;
using Hospital.Pharmacy.PharmacyDomain;
using System.Collections.Generic;

namespace Hospital.Pharmacy.PharmacyRepository
{
    class MemoryMedicineRepository : IMedicineRepository
    {
        Dictionary<int, IMedicine> medicine;
        static int number = 0;

        public MemoryMedicineRepository()
        {
            medicine = new Dictionary<int, IMedicine>();
        }

        public void DeleteMedicine(int id)
        {
            medicine.Remove(id);
        }

        public IMedicine GetMedicine(int id)
        {
            return medicine[id];
        }

        public int SaveMedicine(IMedicine medicine)
        {
            this.medicine.Add(++number, medicine);
            return number;
        }
    }
}
