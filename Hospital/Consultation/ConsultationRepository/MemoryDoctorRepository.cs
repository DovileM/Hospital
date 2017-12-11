using Hospital.Consultation.ConsultationFacadeService;
using Hospital.Consultation.ConsultationDomain;
using System.Collections.Generic;

namespace Hospital.Consultation.ConsultationRepository
{
    class MemoryDoctorRepository : IDoctorRepository
    {
        Dictionary<int, IDoctor> doctor;
        static int number = 0;

        public MemoryDoctorRepository()
        {
            doctor = new Dictionary<int, IDoctor>();

        }

        public void DeleteDoctor(int id)
        {
            doctor.Remove(id);
        }

        public IDoctor getDoctor(int id)
        {
            return doctor[id]; 
        }

        public int SaveDoctor(IDoctor doctor)
        {
            this.doctor.Add(++number, doctor);
            return number; 
        }

        public void UpdateDoctor(int id, IDoctor doctor)
        {
            this.doctor[id] = doctor;
        }
    }
}
