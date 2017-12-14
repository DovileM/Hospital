using Hospital.Consultation.ConsultationDomain;
using Hospital.Consultation.ConsultationDomainService;
using Hospital.Consultation.ConsultationFacadeService.ConsultationFacadeServiceInterfaces;
using System;

namespace Hospital.Consultation.ConsultationFacadeService
{
    class ConsultationFacadeImplementation : IConsultationFacade
    {
        IDoctorRepository doctorRepo;
        IClientRepository clientRepo;
        IClientRegistration registation;
        IConsultationFactory factory;
        IEmailSenderConsultation googleEmailSender;
        IEmailSenderConsultation localEmailSender;

        public ConsultationFacadeImplementation(IDoctorRepository doctorRepo, IClientRepository clientRepo, IClientRegistration registation, IConsultationFactory factory, IEmailSenderConsultation googleEmailSender, IEmailSenderConsultation localEmailSender)
        {
            this.doctorRepo = doctorRepo;
            this.clientRepo = clientRepo;
            this.registation = registation;
            this.factory = factory;
            this.googleEmailSender = googleEmailSender;
            this.localEmailSender = localEmailSender;
        }

        public int AddClient(string name, string surname, string phone, DateTime birth)
        {
            IClient client = factory.CreateClient(name, surname, phone, birth);
            return clientRepo.SaveClient(client);
        }

        public int AddDoctor(string name, string surname, DateTime startDate, DateTime birth, string cabinet)
        {
            IDoctor doctor = factory.CreateDoctor(name, surname, startDate, birth, cabinet);
            localEmailSender.SendMail("doctor@registration.lt", "LOCAL, object 2");
            return doctorRepo.SaveDoctor(doctor);
        }

        public void VisitDocotor(int clientID, int doctorID, DateTime visitDate)
        {
            IClient client = clientRepo.GetClient(clientID);
            IDoctor doctor = doctorRepo.getDoctor(doctorID);
            registation.RegistClientToDoctor(client, doctor, visitDate);
            doctorRepo.UpdateDoctor(doctorID, doctor);
            googleEmailSender.SendMail("doctor@doctor.lt", "VISIT DOCTOR in Consultation");
        }
    }
}
