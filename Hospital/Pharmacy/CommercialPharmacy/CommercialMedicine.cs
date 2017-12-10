using Hospital.Pharmacy.PharmacyDomain;
using System;

namespace Hospital.Pharmacy.CommercialPharmacy
{
    class CommercialMedicine : IMedicine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Validity { get; set; }
        public double Price { get;}

        public CommercialMedicine(string name, string type, DateTime validity, double price)
        {
            Name = name;
            Type = type;
            Validity = validity;
            price = price;
        }
    }
}
