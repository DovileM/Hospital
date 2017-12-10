using Hospital.Operation.OperationDomain;
using System;

namespace Hospital.Operation.PlasticOperation
{
    class PlasticSurgeon : ISurgeon
    {
        public string name { get; }

        public string surname { get; set; }
        public DateTime birth { get; set; }
        public string surgeryType { get; set; }

        public PlasticSurgeon(string surname, DateTime birth, string surgeryType)
        {
            this.surname = surname;
            this.birth = birth;
            this.surgeryType = surgeryType;
        }
    }
}
