using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1W1_OOP1_ConsoleCV.classes
{
    internal class Job
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }

        public DateTime DateFrom;
        public DateTime DateTo;
        public string Description { get; set; }
        public string Duties { get; set; }

        public Job() { }
    }
}


//azienda, jobTitle, dal, al, descrizione, compiti