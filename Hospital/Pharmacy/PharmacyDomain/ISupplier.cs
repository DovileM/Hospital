namespace Hospital.Pharmacy.PharmacyDomain
{
    interface ISupplier
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        string Country { get; set; }
    }
}
