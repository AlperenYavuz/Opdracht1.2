using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Open v1 = new Open()
            {
                Vraag = "Hoeveel fruit eet myriam per dag?",
                Graad = 1,
                Categorie = "Gezondheid",
                Antwoord = "4",
            };

            Open v2 = new Open()
            {
                Vraag = "Hoeveel fruit eet elif per dag?",
                Graad = 2,
                Categorie = "Gezondheid",
                Antwoord = "5",
            };

            Open v3 = new Open()
            {
                Vraag = "Hoe vaak is trabzon kampioen geworden?",
                Graad = 3,
                Categorie = "Sport",
                Antwoord = "7",
            };

            /*
            m1.AddChoice("5", true);
            m1.AddChoice("6", false);
            m1.AddChoice("7", false);
            m1.AddChoice("8", false);
            */

            Quiz q1 = new Quiz();


            q1.Addvraag(v1);
            q1.Addvraag(v2);
            q1.Addvraag(v3);


            string input;

            for (int i = 0; i < q1.GetVragen().Count; i++)
            {
                q1.ToonVraag(q1.GetVragen().ElementAt(i));
                input = Console.ReadLine();

                if (q1.CheckAntwoord(input, q1.GetVragen().ElementAt(i).Antwoord))
                {
                    Console.WriteLine("Goed");
                }

                else
                {
                    Console.WriteLine("fout");
                }
            }


            Console.ReadLine();

        }
    }
}
