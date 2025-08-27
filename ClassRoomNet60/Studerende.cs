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
            FødselsdagsMåned = fødselsMåned;
            Fødselsdag = fødselsDag;
        }
        public override string ToString()
        {
            return $"{Navn}: Fødselsdag {Fødselsdag}/{FødselsdagsMåned}";
        }

    }
}
