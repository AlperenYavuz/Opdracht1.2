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

            Meerkeuze m1 = new Meerkeuze()
            {
                Vraag = "Hoeveel fruit eet myriam per dag?",
                Categorie = "School",
                Graad = 1
            };

            m1.AddChoice("5", true);
            m1.AddChoice("6", false);
            m1.AddChoice("7", false);
            m1.AddChoice("8", false);

            Quiz q1 = new Quiz();
            q1.Addvraag(m1);
            Console.WriteLine(q1);

            Console.ReadLine();

        }
    }
}
