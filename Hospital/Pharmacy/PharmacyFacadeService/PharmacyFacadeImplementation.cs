using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    class PharmacyFacadeImplementation : IPharmacyFacade
    {
        public int AddMedicine(string name, string type, DateTime validity, int supplierID)
        {
            return 0;
        }

        public int AddSupplier(string name, string phone, string address, string country)
        {
            return 0;
        }

        public string BuyMedicine(int medicineID)
        {
            return null;
        }
    }
}
