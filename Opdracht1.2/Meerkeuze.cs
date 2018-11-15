using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    public class Meerkeuze : IVraag
    {

        private Dictionary<string, Boolean> Antwoorden = new Dictionary<string, Boolean>();

        public Meerkeuze(string vraag, Dictionary<string, Boolean> antwoorden, string categorie, int graad)
        {
            Antwoorden = antwoorden;
        }

        public string Vraag { set; get; }

        public int Graad { set; get; }

        public string Categorie { set; get; }

        public string Antwoord { set; get; }

        public void AddChoice(string antwoord, Boolean goed)
        {
            Antwoorden.Add(antwoord, goed);
        } 

        public override string ToString()
        {
            return Vraag;
        }
    }
}
