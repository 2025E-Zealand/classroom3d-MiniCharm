using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {

        public string Navn { get; set; }
        public int FødselsdagsMåned { get; set; }
        public int Fødselsdag { get; set; }

        public Studerende(string navn, int fødselsMåned, int fødselsDag)
        {
            Navn = navn;
            if (FødselsdagsMåned < 12) 
            {
                throw new Exception("Ugyldig måned");
            }
            FødselsdagsMåned = fødselsMåned;
            Fødselsdag = fødselsDag;
        }
        public override string ToString()
        {
            return $"{Navn}: Fødselsdag {Fødselsdag}/{FødselsdagsMåned}";
        }

        public string GetSeasonForBirthMonth() 
        {
            switch (FødselsdagsMåned) 
            {
                case 1: return ("Vinter");
                case 2: return ("Vinter");
                case 3: return ("Forår");
                case 4: return ("Forår");
                case 5: return ("Forår");
                case 6: return ("Sommer");
                case 7: return ("Sommer");
                case 8: return ("Sommer");
                case 9: return ("Efterår");
                case 10: return ("Efterår");
                case 11: return ("Efterår");
                case 12: return ("Vinter");
                default: throw new Exception("Ikke godkendt måned:"+Fødselsdag); 
            }
        }
    }
}
