using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.NaturalPharmacy
{
    class NaturalSupplier : ISupplier
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public NaturalSupplier(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
