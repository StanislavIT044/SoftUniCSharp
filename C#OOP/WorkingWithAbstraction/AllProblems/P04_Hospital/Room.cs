using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04Hospital
{
    public class Room
    {
        public Room()
        {
            this.Patients = new List<Patient>();
        }

        public bool IsFull => this.Patients.Count >= 3;
        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in this.Patients.OrderBy(p => p.Name))
            {
                sb.AppendLine(patient.Name);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
