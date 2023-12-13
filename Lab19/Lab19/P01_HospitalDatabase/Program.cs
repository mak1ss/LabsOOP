using Lab19.P01_HospitalDatabase.Data;
using Lab19.P01_HospitalDatabase.Services;

internal class Program
{
    private static IHospitalService hospitalService;
    private static void Main(string[] args)
    {

        using (var context = new HospitalContext())
        {
            hospitalService = new HospitalService(context);

            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Add Visitation");
                Console.WriteLine("4. View Visitations");
                Console.WriteLine("5. Add Diagnose");
                Console.WriteLine("6. View Diagnoses");
                Console.WriteLine("7. Add Medicament");
                Console.WriteLine("8. View Medicaments");
                Console.WriteLine("9. Add Presription to Patient");
                Console.WriteLine("10. View Patient`s Presriptions");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        Console.WriteLine("Patients:");
                        hospitalService.ViewPatients();
                        break;
                    case "3":
                        AddVisitation();
                        break;
                    case "4":
                        ViewVisitations();
                        break;
                    case "5":
                        AddDiagnose();
                        break;
                    case "6":
                        ViewDiagnoses();
                        break;
                    case "7":
                        AddMedicament();
                        break;
                    case "8":
                        Console.WriteLine("Medicaments:");
                        hospitalService.ViewMedicaments();
                        break;
                    case "9":
                        AddPrescription();
                        break;
                    case "10":
                        ViewPrescription();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }


    private static void AddPatient()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Has Insurance (true/false): ");
        bool hasInsurance = bool.Parse(Console.ReadLine());

        hospitalService.AddPatient(firstName, lastName, address, email, hasInsurance);
    }

    private static void AddVisitation()
    {
        Console.Write("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());

        Console.Write("Enter Visitation Date (YYYY-MM-DD): ");
        DateOnly visitationDate = DateOnly.Parse(Console.ReadLine());

        Console.Write("Enter Comments: ");
        string comments = Console.ReadLine();

        hospitalService.AddVisitation(patientId, visitationDate, comments);
    }

    private static void ViewVisitations()
    {
        Console.WriteLine("Visitations:");
        hospitalService.ViewVisitations();
    }

    private static void AddDiagnose()
    {
        Console.Write("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());

        Console.Write("Enter Diagnose Name: ");
        string diagnoseName = Console.ReadLine();

        Console.Write("Enter Comments: ");
        string comments = Console.ReadLine();

        hospitalService.AddDiagnose(patientId, diagnoseName, comments);
    }

    private static void ViewDiagnoses()
    {
        Console.Write("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());
        Console.WriteLine("Diagnoses:");
        hospitalService.ViewDiagnoses(patientId);
    }

    private static void AddMedicament()
    {
        Console.Write("Enter Medicament Name: ");
        string medicamentName = Console.ReadLine();

        hospitalService.AddMedicament(medicamentName);
    }

    private static void AddPrescription()
    {
        Console.WriteLine("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Medicament IDs separated by \" \"");
        int[] medicamentIds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        hospitalService.AddPrescription(patientId, medicamentIds);
    }

    private static void ViewPrescription()
    {
        Console.WriteLine("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());

        hospitalService.ViewPrescriptions(patientId);
    }
}
