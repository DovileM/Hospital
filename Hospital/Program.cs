using Autofac;
using Autofac.Core;
using Hospital.Common;
using Hospital.Consultation.ConsultationController;
using Hospital.Consultation.ConsultationDomain;
using Hospital.Consultation.ConsultationDomainService;
using Hospital.Consultation.ConsultationFacadeService;
using Hospital.Consultation.ConsultationFacadeService.ConsultationFacadeServiceInterfaces;
using Hospital.Consultation.ConsultationRepository;
using Hospital.Consultation.ConsultationUI;
using Hospital.Consultation.FamilyDoctorConsultation;
using Hospital.Consultation.PsychologistConsultation;
using Hospital.Operation.OperationController;
using Hospital.Operation.OperationDomain;
using Hospital.Operation.OperationDomainService;
using Hospital.Operation.OperationFacadeService;
using Hospital.Operation.OperationRepository;
using Hospital.Operation.OperationUI;
using Hospital.Operation.PlasticOperation;
using Hospital.Operation.TreatmentOperation;
using Hospital.Pharmacy.CommercialPharmacy;
using Hospital.Pharmacy.EmailServer;
using Hospital.Pharmacy.NaturalPharmacy;
using Hospital.Pharmacy.PharmacyController;
using Hospital.Pharmacy.PharmacyDomain;
using Hospital.Pharmacy.PharmacyDomainService;
using Hospital.Pharmacy.PharmacyFacadeService;
using Hospital.Pharmacy.PharmacyRepository;
using Hospital.Pharmacy.PharmacyUI;
using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            IContainer container = FirstConfiguration();
            //IContainer container = SecondConfiguration();

            var consultation = container.Resolve<ConsultationConsole>();
            var operation = container.Resolve<OperationConsole>();
            var pharmacy = container.Resolve<PharmacyConsole>();

            bool exit = false, back = false;
            
            Console.WriteLine("Welcome to HOSPITAL. Choose what You want to do.");
            while (!exit)
            {
                Console.WriteLine("-----------**-----**-----------");
                Console.WriteLine("1  -  Pharmacy.");
                Console.WriteLine("2  -  Consultation.");
                Console.WriteLine("3  -  Operation.");
                Console.WriteLine("-1 -  Exit.");
                Console.WriteLine();

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        back = false;
                        Console.WriteLine("~~~~~~~**~~~~~**~~~~~~~");
                        Console.WriteLine("1  -  Add medicine.");
                        Console.WriteLine("2  -  Add supplier.");
                        Console.WriteLine("3  -  Buy medicine.");
                        Console.WriteLine("-1 -  Back.");
                        Console.WriteLine();
                        while (!back)
                        {
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    pharmacy.AddMedicine();
                                    break;
                                case 2:
                                    pharmacy.AddSupplier();
                                    break;
                                case 3:
                                    pharmacy.BuyMedicine();
                                    break;
                                case -1:
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice.");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        back = false;
                        Console.WriteLine("~~~~~~~**~~~~~**~~~~~~~");
                        Console.WriteLine("1  -  Add doctor.");
                        Console.WriteLine("2  -  Add client.");
                        Console.WriteLine("3  -  Visit doctor.");
                        Console.WriteLine("-1 -  Back.");
                        Console.WriteLine();
                        while (!back)
                        {
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    consultation.AddDoctor();
                                    break;
                                case 2:
                                    consultation.AddClient();
                                    break;
                                case 3:
                                    consultation.VisitDoctor();
                                    break;
                                case -1:
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice.");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        back = false;
                        Console.WriteLine("~~~~~~~**~~~~~**~~~~~~~");
                        Console.WriteLine("1  -  Regist operation.");
                        Console.WriteLine("2  -  Get surgery date.");
                        Console.WriteLine("3  -  Cancel surgery.");
                        Console.WriteLine("-1 -  Back.");
                        Console.WriteLine();
                        while (!back)
                        {
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    operation.RegistOperation();
                                    break;
                                case 2:
                                    operation.GetSurgeryDate();
                                    break;
                                case 3:
                                    operation.CancelSurgery();
                                    break;
                                case -1:
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice.");
                                    break;
                            }
                        }
                        break;
                    case -1:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }
            }


        }

        static IContainer FirstConfiguration()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ConsultationConsole>().AsSelf();
            builder.RegisterType<OperationConsole>().AsSelf();
            builder.RegisterType<PharmacyConsole>().AsSelf();

            builder.RegisterType<ConsultationControllerImplementation>().As<IConsultationController>();
            //builder.RegisterType<ConsultationFacadeImplementation>().As<IConsultationFacade>();
            builder.RegisterType<ElectronicClientRegistation>().As<IClientRegistration>();
            builder.RegisterType<FamilyDoctor>().As<IDoctor>();
            builder.RegisterType<FamilyDoctorClient>().As<IClient>();
            builder.RegisterType<FamilyDoctorFactory>().As<IConsultationFactory>();
            builder.RegisterType<MemoryClientRepository>().As<IClientRepository>();
            builder.RegisterType<MemoryDoctorRepository>().As<IDoctorRepository>();

            builder.RegisterType<OperationControllerImplementation>().As<IOperationController>();
            builder.RegisterType<OperationFacadeImplementation>().As<IOperationFacade>();
            builder.RegisterType<CashPlasticOperationPayment>().As<IPlasticOperationPayment>();
            builder.RegisterType<PlasticSurgeon>().As<ISurgeon>();
            builder.RegisterType<PlasticSurgery>().As<ISurgery>();
            builder.RegisterType<PlasticFactory>().As<IOperationFactory>();
            builder.RegisterType<MemorySurgeonRepository>().As<ISurgeonRepository>();
            builder.RegisterType<MemorySurgeryRepository>().As<ISurgeryRepository>();

            builder.RegisterType<PharmacyControllerImplementation>().As<IPharmacyController>();
            builder.RegisterType<PharmacyFacadeImplementation>().As<IPharmacyFacade>();
            builder.RegisterType<PVMMedicinePriceCalculator>().As<IMedicinePriceCalculator>();
            builder.RegisterType<CommercialMedicine>().As<IMedicine>();
            builder.RegisterType<CommercialSupplier>().As<ISupplier>();
            builder.RegisterType<CommercialMedicinineSupplierFactory>().As<IPharmacyFactor>();
            builder.RegisterType<MemoryMedicineRepository>().As<IMedicineRepository>();
            builder.RegisterType<MemorySupplierRepository>().As<ISupplierRepository>();
            builder.RegisterType<GoogleEmailServer>().As<IEmailSender>();

            builder.RegisterInstance(new MailAdapter(new LocalEmailServer())).Named<IEmailSenderConsultation>("localEmailSender");
            builder.RegisterInstance(new MailAdapter(new GoogleEmailServer())).Named<IEmailSenderConsultation>("googleEmailSender");

            builder.RegisterType<ConsultationFacadeImplementation>().As<IConsultationFacade>().WithParameter(
                (pi, ctx) => pi.ParameterType == typeof(IEmailSenderConsultation),
                (pi, ctx) => ctx.ResolveNamed<IEmailSenderConsultation>(pi.Name));

            return builder.Build();
        }


        static IContainer SecondConfiguration()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ConsultationConsole>().AsSelf();
            builder.RegisterType<OperationConsole>().AsSelf();
            builder.RegisterType<PharmacyConsole>().AsSelf();

            builder.RegisterType<ConsultationControllerImplementation>().As<IConsultationController>();
            builder.RegisterType<ConsultationFacadeImplementation>().As<IConsultationFacade>();
            builder.RegisterType<MailAdapter>().As<IEmailSenderConsultation>().WithParameter(ResolvedParameter.ForNamed<IEmailSender>("local"));
            builder.RegisterType<PhysicalClientRegistration>().As<IClientRegistration>();
            builder.RegisterType<Psychologist>().As<IDoctor>();
            builder.RegisterType<PsychologistClient>().As<IClient>();
            builder.RegisterType<PsychologistConsultationFactory>().As<IConsultationFactory>();
            builder.RegisterType<MemoryClientRepository>().As<IClientRepository>();
            builder.RegisterType<MemoryDoctorRepository>().As<IDoctorRepository>();

            builder.RegisterType<OperationControllerImplementation>().As<IOperationController>();
            builder.RegisterType<OperationFacadeImplementation>().As<IOperationFacade>();
            builder.RegisterType<CardPlasticOperationPayment>().As<IPlasticOperationPayment>();
            builder.RegisterType<TreatmentSurgeon>().As<ISurgeon>();
            builder.RegisterType<TreatmentSurgery>().As<ISurgery>();
            builder.RegisterType<TreatmentFactory>().As<IOperationFactory>();
            builder.RegisterType<MemorySurgeonRepository>().As<ISurgeonRepository>();
            builder.RegisterType<MemorySurgeryRepository>().As<ISurgeryRepository>();

            builder.RegisterType<PharmacyControllerImplementation>().As<IPharmacyController>();
            builder.RegisterType<PharmacyFacadeImplementation>().As<IPharmacyFacade>().WithParameter(ResolvedParameter.ForNamed<IEmailSender>("google"));
            builder.RegisterType<PVMMedicinePriceCalculator>().As<IMedicinePriceCalculator>();
            builder.RegisterType<NaturalMedicine>().As<IMedicine>();
            builder.RegisterType<NaturalSupplier>().As<ISupplier>();
            builder.RegisterType<NaturalMedicineSupplierFactory>().As<IPharmacyFactor>();
            builder.RegisterType<MemoryMedicineRepository>().As<IMedicineRepository>();
            builder.RegisterType<MemorySupplierRepository>().As<ISupplierRepository>();

            builder.RegisterType<LocalEmailServer>().Named<IEmailSender>("local");
            builder.RegisterType<GoogleEmailServer>().Named<IEmailSender>("google");

            return builder.Build();
        }
    }
}
