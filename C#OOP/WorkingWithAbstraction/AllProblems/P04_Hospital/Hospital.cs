using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Departaments = new List<Department>();
        }
        public List<Doctor> Doctors { get; set; }
        public List<Department> Departaments { get; set; }

        public void AddDoctor(string firstname, string lastName)
        {
            this.Doctors.Any(d => d.FirstName == firstname && d.LastName == lastName);
            Doctor doctor = new Doctor(firstname, lastName);
            this.Doctors.Add(doctor);

        }

        public void AddDepartament(string name)
        {
            if (this.Departaments.Any(de => de.Name == name))
            {
                var department = new Department(name);
                this.Departaments.Add(department);
            }
        }

        public void AddPatient(string departmentName, string doctorName, string patientName)
        {
            Department department = this.Departaments.FirstOrDefault(de => de.Name == departmentName);
            Doctor doctor = this.Doctors.FirstOrDefault(d => d.FullName == doctorName);

            Patient patient = new Patient(patientName);

            department.AddPatientToRoom(patient);
            doctor.Patients.Add(patient);
        }
    }
}
