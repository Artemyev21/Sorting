using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PatientService patientService = new PatientService();

            Patient p1 = new Patient("Alex", "Mitchel", 21, "critical");
            Patient p2 = new Patient("Kate", "Pupsvel", 18, "critical");
            Patient p3 = new Patient("Georgy", "Robbinson", 42, "normal");
            Patient p4 = new Patient("LG", "Coompany", 120, "normal");
            Patient p5 = new Patient("Mikky", "Mouse", 30, "critical");

            patientService.AddPatient(p1);
            patientService.AddPatient(p2);
            patientService.AddPatient(p3);
            patientService.AddPatient(p4);
            patientService.AddPatient(p5);


            InteractWithUser(patientService);
        }

        private static void InteractWithUser(PatientService patientService)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "critical":
                        var criticalPatients = patientService.Critical();
                        if (criticalPatients.Length != 0)
                        {
                            foreach (var patient in criticalPatients)
                            {
                                Console.WriteLine($"{patient.name} {patient.surname}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Critical patients no found");
                        }
                        break;
                    case "LessThen":
                        int age;
                        string s_age = Console.ReadLine();
                        if (Int32.TryParse(s_age, out age))
                        {
                            var patientsAge = patientService.LessThan(age);
                            if (patientsAge.Length != 0)
                            {
                                foreach (var patient in patientsAge)
                                {
                                    Console.WriteLine($"{patient.name} {patient.surname}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Patients no found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Patients no found");   
                        }                                                                         
                        break;
                    case "FindByName":
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        var patientsName =  patientService.FindByName(name);
                        if (patientsName.Length != 0)
                        {
                            foreach (var patient in patientsName)
                            {
                                Console.WriteLine($"{patient.name} {patient.surname}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Name not found");
                        }
                        break;
                    case "FindBySurname":
                        Console.WriteLine("Enter Surname:");
                        string surname = Console.ReadLine();
                        var patientsSurname = patientService.FindBySurname(surname);
                        if (patientsSurname.Length != 0)
                        {
                            foreach (var patient in patientsSurname)
                            {
                                Console.WriteLine($"{patient.name} {patient.surname}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Surname not found");
                        }
                        break;
                    case "finish":
                        flag = false;
                        break;
;                    default:
                        Console.WriteLine("Сorrect commands: critical, LessThen, FindByName, FindBySurname, finish");
                        break;
                }
                
            }
            while (flag);
            Console.WriteLine("FINISH!!!");
        }
    }
}
