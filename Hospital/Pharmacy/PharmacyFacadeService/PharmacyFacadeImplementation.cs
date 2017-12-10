using Hospital.Pharmacy.PharmacyDomain;
using Hospital.Pharmacy.PharmacyDomainService;
using System;

namespace Hospital.Pharmacy.PharmacyFacadeService
{
    class PharmacyFacadeImplementation : IPharmacyFacade
    {
        IMedicineRepository medicineRepo;
        ISupplierRepository supplierRepo;
        IMedicinePriceCalculator medicinePriceCalc;
        IPharmacyFactor factor;
        IEmailSender emailSender;

        public PharmacyFacadeImplementation(IMedicineRepository medicineRepo, ISupplierRepository supplierRepo, IMedicinePriceCalculator medicinePriceCalc, IPharmacyFactor factor, IEmailSender emailSender)
        {
            this.medicineRepo = medicineRepo;
            this.supplierRepo = supplierRepo;
            this.medicinePriceCalc = medicinePriceCalc;
            this.factor = factor;
            this.emailSender = emailSender;
        }

        public int AddMedicine(string name, string type, DateTime validity, int supplierID)
        {
            ISupplier supplier = supplierRepo.GetSupplier(supplierID);
            double price = medicinePriceCalc.CalculatePrice(validity, supplier);
            IMedicine medicine = factor.CreateMedicine(name, type, validity, price);
            return medicineRepo.SaveMedicine(medicine);
        }

        public int AddSupplier(string name, string phone, string address, string country)
        {
            ISupplier supplier = factor.CreateSupplier(name, phone, address + ", " + country);
            emailSender.SendEmail(name + "@gmail.com", "You have been registed. Thanks for using! \n HAVE A GOOD DAY");
            return supplierRepo.SaveSupplier(supplier);
        }

        public string BuyMedicine(int medicineID)
        {
            IMedicine medicine = medicineRepo.GetMedicine(medicineID);
            return medicine.Price.ToString();
        }
    }
}
