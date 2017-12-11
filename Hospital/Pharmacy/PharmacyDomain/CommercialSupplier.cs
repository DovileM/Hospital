using Hospital.Pharmacy.PharmacyDomain;

namespace Hospital.Pharmacy.CommercialPharmacy
{
    class CommercialSupplier : ISupplier
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public CommercialSupplier(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
