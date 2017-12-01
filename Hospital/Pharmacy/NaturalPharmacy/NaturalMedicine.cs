using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.NaturalPharmacy
{
    class NaturalMedicine : IMedicine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Validity { get; set; }
        public int SupplierID { get; set; }

        public NaturalMedicine(string name, string type, DateTime validity, int supplierID)
        {
            Name = name;
            Type = type;
            Validity = validity;
            SupplierID = supplierID;
        }
    }
}
