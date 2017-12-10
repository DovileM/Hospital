using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.NaturalPharmacy
{
    class NaturalMedicine : IMedicine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Validity { get; set; }
        public double Price { get; }

        public NaturalMedicine(string name, string type, DateTime validity, double price)
        {
            Name = name;
            Type = type;
            Validity = validity;
            Price = price;
        }
    }
}
