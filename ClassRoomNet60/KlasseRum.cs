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
    }
}
