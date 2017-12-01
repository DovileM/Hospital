using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.CommercialPharmacy
{
    class CommercialMedicine : IMedicine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Validity { get; set; }
        public int SupplierID { get; set; }

        public CommercialMedicine(string name, string type, DateTime validity, int supplierID)
        {
            Name = name;
            Type = type;
            Validity = validity;
            SupplierID = supplierID;
        }
    }
}
