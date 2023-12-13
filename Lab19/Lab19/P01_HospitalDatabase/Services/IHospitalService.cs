using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19.P01_HospitalDatabase.Services
{
    public interface IHospitalService
    {
        void AddPatient(string firstName, string lastName, string address, string email, bool hasInsurance);
        void ViewPatients();

        void AddVisitation(int patientId, DateOnly visitationDate, string comments);
        void ViewVisitations();

        void AddDiagnose(int patientId, string diagnoseName, string comments);
        void ViewDiagnoses(int patientId);

        void AddMedicament(string medicamentName);
        void ViewMedicaments();

        void AddPrescription(int patientId, int[] medicamentIds);

        void ViewPrescriptions(int patientId);
    }

}
