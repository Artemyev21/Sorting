using System.Collections.Generic;
using System.Linq;
using System;

namespace Sorting
{
    class PatientService
    {
        private List<Patient> _electronicPatientData;
        
        public PatientService()
        {
            _electronicPatientData = new List<Patient>();
        }

        public void AddPatient(Patient p)
        {
            _electronicPatientData.Add(p);
        }


        public Patient[] FindByName(string name) //Поиск по имени
        {
            var patients = _electronicPatientData.Where(s => s.name == name).ToArray();
            return patients;
        }
        public Patient[] FindBySurname(string surname) //Поиск по фамилии
        {
            var patients = _electronicPatientData.Where(s => s.surname == surname).ToArray();
            return patients;
        }
        public Patient[] Critical() //Поиск критических пациентов
        {
            string search = "critical";            
            var criticalPatients = _electronicPatientData.Where(s => s.status == search).ToArray();
            return criticalPatients;
            
        }
        public Patient[] LessThan(int age) //Поиск с возрастом ниже введенного
        {
            var patients = _electronicPatientData.Where(a => a.age < age).ToArray();
            return patients;
        }
    }
}
