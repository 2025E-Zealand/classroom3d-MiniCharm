using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }

        public DateTime SemsterStart { get; set; }

        public KlasseRum( string navn, List<Studerende> klasse, DateTime stemesterStart)
        {
            KlasseNavn = navn;
            Klasseliste = klasse;
            SemsterStart = stemesterStart;
            
        }

        public KlasseRum()
        {
            
        }
        public override string ToString() 
        {
            return $"{KlasseNavn}: {SemsterStart}";
        }

        public void Count() 
        { 
            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict.Add("Vinter", 0);
            dict.Add("Forår", 0);
            dict.Add("Sommer",0);
            dict.Add("Efterår", 0);

            foreach (Studerende s in Klasseliste) 
            {
                //Forhver studerende skal der i ditionary funde den sæson, den studerende har fødselsdag,
                //hertik skal verdien i dictionaryen øges med 1. Dette betyder dictionary virker som en tælle maskine.
                dict[s.GetSeasonForBirthMonth()]++;
            }
            foreach(var kvp  in dict) 
            { 
                Console.WriteLine(kvp); 
            }
        }
    }
}
