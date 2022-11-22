using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1W1_OOP1_ConsoleCV.classes
{
    internal class CV
    {
        public PersonalInfo InformazioniPersonali;
        public Studies StudieEffettuati;
        public Experience Esperienza;
        public CV() { }



        public void ShowCV()
        {

            Console.WriteLine($"*** CV di {InformazioniPersonali.Name} {InformazioniPersonali.Lastname} *** \n\nPERSONAL INFO:\n__________");
            Console.WriteLine($"-Name: {InformazioniPersonali.Name}\n-Lastname: {InformazioniPersonali.Lastname}\n-Tel: {InformazioniPersonali.PhoneNum}\n-Mail: {InformazioniPersonali.Email}\n\n");
            Console.WriteLine("STUDI:\n__________");
            StudieEffettuati.DisplayStudies();
            Console.WriteLine("ESPERIENZA LAVORATIVA:\n__________");
            Esperienza.DisplayExperience();
        }
    }
}
