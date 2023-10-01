public class Department
{
    private string name;
    public Patient[,] Patients = new Patient[20, 3];

    private int currentRoomRow = 0;
    private int currentRoomColumn = 0;

    public Department(string name)
    {
        this.name = name;
    }

    public void addPatient(Patient patient)
    {
        if (currentRoomColumn == 2 && currentRoomRow == 19)
        {
            throw new Exception("This department is full");
        }
        Patients[currentRoomRow, currentRoomColumn] = patient;
        currentRoomColumn++;
        if (currentRoomColumn > 2)
        {
            currentRoomRow++;
            currentRoomColumn = 0;
        }
    }

    public override string ToString()
    {
        string result = "";
        foreach (Patient patient in Patients)
        {
            if (patient != null)
            {
                result += (patient.ToString() + "\n");
            }
        }
        return result;
    }
    public string ToString(int room)
    {
        string result = "";
        for (int i = 0; i < 3; i++)
        {
            result += (Patients[room - 1, i].ToString() + "\n");
        }
        return result;
    }

    public override int GetHashCode()
    {
        return name.GetHashCode() + Patients.GetHashCode() + base.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}
public class Patient
{
    public string Name { get; }

    public Patient(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}
public class Doctor
{
    public string Name { get; }
    public string Surname { get; }
    private List<Patient> Patients = new List<Patient>();
    public List<Patient> GetPatients()
    {
        return Patients;
    }
    public Doctor(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        string result = "";
        foreach (Patient patient in Patients)
        {
            result += (patient.ToString() + "\n");
        }
        return result;
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        Dictionary<String, Department> departments = new Dictionary<String, Department>();
        Dictionary<String, Doctor> doctors = new Dictionary<String, Doctor>();
        string input = "";
        while (!input.Equals("End"))
        {
            input = Console.ReadLine();
            if (input.Equals("Output"))
            {
                while (!input.Equals("End"))
                {
                    input = Console.ReadLine();
                    string[] command = input.Split(" ");
                    if (departments.ContainsKey(command[0]))
                    {
                        Department outputDepartment = departments[command[0]];
                        if (command.Length > 1)
                        {
                            Console.WriteLine(outputDepartment.ToString(int.Parse(command[1])));
                        }
                        else
                        {
                            Console.WriteLine(outputDepartment.ToString());
                        }
                    }
                    else if (command.Length > 1 && doctors.ContainsKey(command[0] + " " + command[1]))
                    {
                        Console.WriteLine(doctors[command[0] + " " + command[1]].ToString());
                    }


                }
            }
            else
            {
                string[] parameters = input.Split(" ");
                if (parameters.Length != 4)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                Department department;

                if (departments.ContainsKey(parameters[0]))
                {
                    department = departments[parameters[0]];
                }
                else
                {
                    department = new Department(parameters[0]);
                    departments.Add(parameters[0], department);
                }
                Patient patient = new Patient(parameters[3]);
                department.addPatient(patient);
                Doctor doctor;
                if (doctors.ContainsKey(parameters[1] + " " + parameters[2]))
                {
                    doctor = doctors[parameters[1] + " " + parameters[2]];
                }
                else
                {
                    doctor = new Doctor(parameters[1], parameters[2]);
                    doctors.Add(doctor.Name + " " + doctor.Surname, doctor);
                }

                doctor.GetPatients().Add(patient);
            }

        }
    }
}