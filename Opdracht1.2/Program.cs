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
                Categorie = "School",
                Antwoord = "veel",
            };

            /*
            m1.AddChoice("5", true);
            m1.AddChoice("6", false);
            m1.AddChoice("7", false);
            m1.AddChoice("8", false);
            */

            Quiz q1 = new Quiz();
            q1.Addvraag(v1);
            q1.ToonVraag();



            Console.ReadLine();

        }
    }
}
