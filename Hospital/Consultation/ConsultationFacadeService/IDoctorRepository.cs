using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationFacadeService
{
    interface IDoctorRepository
    {
        IDoctor getDoctor(int id);
        void DeleteDoctor(int id);
        void UpdateDoctor(IDoctor doctor);
        int SaveDoctor(IDoctor docotor);
    }
}
