using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static U1W1_OOP1_ConsoleCV.classes.Studies;

namespace U1W1_OOP1_ConsoleCV.classes
{
    internal class Experience
    {
        public List<Job> jobs = new List<Job>();

        public void AddJob(Job job) { jobs.Add(job); }

        public void DisplayExperience()
        {
            foreach (Job job in jobs)
            {
                Console.WriteLine($"-Company: {job.Company}");
                Console.WriteLine($"-Title: {job.JobTitle}");
                Console.WriteLine($"-Da: {job.DateFrom}");
                Console.WriteLine($"-A: {job.DateTo}");
                Console.WriteLine($"-Descrizione: {job.Description}");
                Console.WriteLine($"-Compiti: {job.Duties}");
                Console.WriteLine("\n");

            }
        }
    }
}