using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1W1_OOP1_ConsoleCV.classes
{
    internal class Studies
    {
        

        public List<Study> StudiesList = new List<Study>();

        //public void AddStudy(Study study) { StudiesList.Add(study); }


        public class Study
        {
            public string Title;
            public string Institute;
            public string Level;
            public DateTime DateFrom;
            public DateTime DateTo;
        }

        public void DisplayStudies() 
        { 
            foreach(Study study in StudiesList)
            {
                Console.WriteLine($"-Isituto: {study.Institute}");
                Console.WriteLine($"-Titolo: {study.Title}");
                Console.WriteLine($"-Livello: {study.Level}");
                Console.WriteLine($"-Da: {study.DateFrom}");
                Console.WriteLine($"-A: {study.DateTo}\n\n");
            }
        }
    }
}


// qualifica, istituto, tipo, dal, al