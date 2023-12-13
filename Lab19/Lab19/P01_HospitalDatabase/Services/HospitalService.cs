using Lab19.P01_HospitalDatabase.Data;
using Lab19.P01_HospitalDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19.P01_HospitalDatabase.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly HospitalContext _context;

        public HospitalService(HospitalContext context)
        {
            _context = context;
        }

        public void AddPatient(string firstName, string lastName, string address, string email, bool hasInsurance)
        {
            var newPatient = new Patient
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Email = email,
                HasInsurance = hasInsurance
            };

            _context.Patients.Add(newPatient);
            _context.SaveChanges();
            Console.WriteLine("Patient added successfully!");
        }

        public void ViewPatients()
        {
            var patients = _context.Patients.ToList();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Patient ID: {patient.Id}, Name: {patient.FirstName} {patient.LastName}, Email: {patient.Email}");
            }
        }

        public void AddVisitation(int patientId, DateOnly visitationDate, string comments)
        {
            var patient = _context.Patients.Where(p => p.Id == patientId).FirstOrDefault();
            if (patient == null)
            {
                Console.WriteLine("Invalid patient id");
                return;
            }
            var newVisitation = new Visitation
            {
                Date = visitationDate,
                Comments = comments,
                Patient = patient
            };

            _context.visitations.Add(newVisitation);
            _context.SaveChanges();
            Console.WriteLine("Visitation added successfully!");
        }

        public void ViewVisitations()
        {
            var visitations = _context.visitations.ToList();
            foreach (var visitation in visitations)
            {
                Console.WriteLine($"Visitation ID: {visitation.Id}, Date: {visitation.Date}, Comments: {visitation.Comments}");
            }
        }

        public void AddDiagnose(int patientId, string diagnoseName, string comments)
        {
            var patient = _context.Patients.Where(p => p.Id == patientId).FirstOrDefault();
            if (patient == null)
            {
                Console.WriteLine("Invalid patient id");
                return;
            }
            var newDiagnose = new Diagnose
            {
                Name = diagnoseName,
                Comments = comments,
                Patient = patient
            };
            _context.Diagnose.Add(newDiagnose);
            _context.SaveChanges();
            Console.WriteLine("Diagnose added successfully!");
        }

        public void ViewDiagnoses(int patientId)
        {
            var diagnose = _context.Diagnose.Where(d => d.Patient.Id == patientId).FirstOrDefault();
            if (diagnose != null)
            {
                Console.WriteLine($"Diagnose ID: {diagnose.Id}, Name: {diagnose.Name}, Comments: {diagnose.Comments}");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }

        public void AddMedicament(string medicamentName)
        {
            var newMedicament = new Medicament
            {
                Name = medicamentName
            };

            _context.medicaments.Add(newMedicament);
            _context.SaveChanges();
            Console.WriteLine("Medicament added successfully!");
        }

        public void ViewMedicaments()
        {
            var medicaments = _context.medicaments.ToList();
            foreach (var medicament in medicaments)
            {
                Console.WriteLine($"Medicament ID: {medicament.Id}, Name: {medicament.Name}");
            }
        }

        public void AddPrescription(int patientId, int[] medicamentIds)
        {
            var patient = _context.Patients.Where(p => p.Id == patientId).Include(p => p.medicaments).FirstOrDefault();
            if (patient == null)
            {
                Console.WriteLine("Invalid patient id");
                return;
            }
            var medicaments = _context.medicaments.Where(m => medicamentIds.Contains(m.Id) && !patient.medicaments.Contains(m)).ToList();

            if (medicamentIds == null)
            {
                Console.WriteLine("Ivalid medicamentsId");
                return;
            }

            medicaments.ForEach(patient.medicaments.Add);
            _context.Patients.Update(patient);
            _context.SaveChanges();
            Console.WriteLine("Successfully added prescriptions");
        }

        public void ViewPrescriptions(int patientId)
        {
            var patient = _context.Patients.Where(p => p.Id == patientId).Include(p => p.medicaments).FirstOrDefault();
            if (patient == null)
            {
                Console.WriteLine("Invalid patient id");
                return;
            }

            Console.WriteLine($"{patient.FirstName} {patient.LastName}`s prescriptions: ");
            foreach(var m in patient.medicaments)
            {
                Console.Write($"{m.Name} ");
            }
            Console.WriteLine();
        }
    }
}