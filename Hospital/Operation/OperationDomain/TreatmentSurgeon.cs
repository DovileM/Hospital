using Hospital.Operation.OperationDomain;
using System;

namespace Hospital.Operation.TreatmentOperation
{
    class TreatmentSurgeon : ISurgeon
    {
        public string Name { get; }

        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string SurgeryType { get; set; }

        public TreatmentSurgeon(string name, string surname, DateTime birth, string surgeryType)
        {
            Name = name;
            Surname = surname;
            Birth = birth;
            SurgeryType = surgeryType;
        }
    }
}
