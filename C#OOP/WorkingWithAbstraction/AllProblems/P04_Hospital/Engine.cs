using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04Hospital
{
    public class Engine
    {
        private Hospital hospital;
        public Engine()
        {
            this.hospital = new Hospital();
        }

        public  void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] arguments = command.Split();

                var departament = arguments[0];

                var firstName = arguments[1];
                var secoundName = arguments[2];

                var patient = arguments[3];
                var fullName = firstName + " " + secoundName;

                this.hospital.AddDoctor(firstName, secoundName);
                this.hospital.AddDepartament(departament);
                this.hospital.AddPatient(departament, fullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command == "End")
            {
                string[] arguments = command.Split();

                if (arguments.Length == 1)
                {
                    string departmentName = arguments[0];
                    var department = this.hospital.Departaments.FirstOrDefault(de => de.Name == departmentName);

                    Console.WriteLine(department);
                }
                else
                {
                    bool isRoom = int.TryParse(arguments[1], out int resultRoom);
                    if (isRoom)
                    {
                        string departmentName = arguments[0];
                        Department departament = this.hospital.Departaments.FirstOrDefault(de => de.Name == departmentName);

                        Room currnetRoom = departament.Rooms[resultRoom - 1];

                        Console.WriteLine(currnetRoom.ToString());
                    }
                    else
                    {
                        string firstname = arguments[0];
                        string lastName = arguments[1];

                        string fullName = firstname + " " + lastName;
                        Doctor doctor = this.hospital.Doctors.FirstOrDefault(d => d.FirstName == fullName);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
