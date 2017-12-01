using Hospital.Consultation.ConsultationFacadeService;
using Hospital.Consultation.ConsultationDomain;

namespace Hospital.Consultation.ConsultationRepository
{
    class MemoryDoctorRepository : IDoctorRepository
    {
        public void DeleteDoctor(int id)
        {
           //TO DO
        }

        public IDoctor getDoctor(int id)
        {
            //TO DO
            return null; 
        }

        public int SaveDoctor(IDoctor docotor)
        {
            //TO DO
            return 0; 
        }

        public void UpdateDoctor(IDoctor doctor)
        {
            //TO DO
        }
    }
}
