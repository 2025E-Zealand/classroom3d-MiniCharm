// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

List<Studerende> BKlasseListe = new List<Studerende>();
Studerende s1 = new Studerende("Kat", 9, 2);
Studerende s2 = new Studerende("JoJo", 6,23 );
Studerende s3 = new Studerende("Kas", 10, 17);
Studerende s4 = new Studerende("Vic", 1, 30);
Studerende s5 = new Studerende("Nat",3,11);
BKlasseListe.Add(s1);
BKlasseListe.Add(s2);
BKlasseListe.Add(s3);
BKlasseListe.Add(s4);
BKlasseListe.Add(s5);

KlasseRum klasse1 = new KlasseRum("3B", BKlasseListe, new DateTime(2022,9,1));

Console.WriteLine(klasse1.ToString());
foreach(Studerende s in BKlasseListe)
{
    Console.WriteLine(s.ToString());
}

klasse1.Count();