using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using U1W1_OOP1_ConsoleCV.classes;

namespace U1W1_OOP1_ConsoleCV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV Curriculum = new CV();

            PersonalInfo p = new PersonalInfo();
            p.Name = "Roberto";
            p.Lastname = "Dabbicco";
            p.Email = "roberto.dabb@gmail.com";
            p.PhoneNum = "340-5398658";

            Studies s = new Studies();

            Studies.Study study = new Studies.Study();
            study.Institute = "Euclide Bari";
            study.Title = "Tecnico Logistica";
            study.Level = "Maturità";
            study.DateTo = new DateTime(2015, 06, 20);

            s.StudiesList.Add(study);

            //ESEMPIO DI AGGIUNTA DI PROPRIETA' DA INPUT.

            //Studies.Study study1 = new Studies.Study();
            //study1.Institute = Console.ReadLine();
            //Console.WriteLine(study1.Institute);
            //Console.ReadLine();


            //s.AddStudy(study);

            Experience exp = new Experience();
            Job job = new Job();
            job.Company = "Webidoo spa";
            job.JobTitle = "Digital Sales Executive";
            job.DateFrom = new DateTime(2020, 07, 15);
            job.DateTo = new DateTime(2022, 08, 20);
            job.Description = "Consulente Digital per le pmi \nnella trasformazione digitale";
            job.Duties = "Business developement e acquisizione clienti, Consulenza.";

            Job job1 = new Job();
            job1.Company = "Decathlon Italia";
            job1.JobTitle = "Sport Counselor";
            job1.DateFrom = new DateTime(2016, 08, 10);
            job1.DateTo = new DateTime(2018, 07, 20);
            job1.Description = "Asssitenza di vendita";
            job1.Duties = "Consiglio di vendita ai clienti e sistemazione corsie";

            exp.AddJob(job);
            exp.AddJob(job1);


            Curriculum.InformazioniPersonali = p;
            Curriculum.StudieEffettuati = s;
            Curriculum.Esperienza = exp;

            Console.WriteLine("* Benvenuto \nClicca -Invio- per visionare il CV di Roberto D.\n\nOppure 'q'+ enter , per terminare in qualunque momento.");
            string input = Console.ReadLine();
            if (input == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                Curriculum.ShowCV();
            }
            Console.WriteLine("\n*** STAY TUNED ***");
            Console.ReadLine();
            
        }
    }
}
