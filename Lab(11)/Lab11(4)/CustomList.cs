using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4_
{

    public class CustomList : List<Job>
    {
        public void AddJob(Job job)
        {
            job.JobDone += OnJobIsDone;
            base.Add(job);
        }

        public string Status()
        {
            StringBuilder builder = new StringBuilder();
            base.ForEach(job => builder.AppendLine(job.ToString()));
            return builder.ToString();
        }

        public void PassWeek()
        {
            Job[] jobs = new Job[base.Count];
            base.CopyTo(jobs, 0);
            jobs.ToList().ForEach(job => job.Update());
        }

        private void OnJobIsDone(string jobName)
        {      
            Job completedJob = base.ToArray().Cast<Job>().Where(job => job.Name.Equals(jobName)).Single();       
            base.Remove(completedJob);
            completedJob.JobDone -= OnJobIsDone;
        }
    }
}
