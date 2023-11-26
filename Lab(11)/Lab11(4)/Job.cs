using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4_
{
    public delegate void OnJobIsDone(string jobName);
    public class Job
    {
        private IEmployee employee;
        private int hoursRequired;
        private string jobName;
        public string Name { get => jobName; private set => jobName = value; }
        public Job(IEmployee employee, int hoursRequiered, string jobName)
        {
            this.employee = employee;
            this.hoursRequired = hoursRequiered;
            this.jobName = jobName;
        }

        public event OnJobIsDone JobDone;

        public void Update()
        {
            hoursRequired -= employee.HoursPerWeek;
            if (hoursRequired <= 0)
            {
                Done();
            }
        }

        private void Done()
        {
            Console.WriteLine($"Job {jobName} is done!");
            JobDone.Invoke(jobName);
        }

        public override string ToString()
        {
            return $"Job: {jobName} HoursRemaining: {hoursRequired}";
        }
    }
}

