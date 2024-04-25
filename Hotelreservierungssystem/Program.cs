using Hotelreservierungssystem;

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel("Hotel", "Adresse");
        Zimmer zimmer1 = new Zimmer(1, Zimmer.ZimmerTyp.Einzelzimmer, 50);
        Zimmer zimmer2 = new Zimmer(2, Zimmer.ZimmerTyp.Doppelzimmer, 100);
        hotel.ZimmerHinzufuegen(zimmer1);
        hotel.ZimmerHinzufuegen(zimmer2);
        
        Gast gast = new Gast("Max", "Mustermann");
        Reservierung reservierung = new Reservierung(1, gast, zimmer1, DateTime.Now, DateTime.Now.AddDays(3));
        gast.ReservierungHinzufuegen(zimmer1);
        
        Console.WriteLine("Hotel: " + hotel.Name);
        Console.WriteLine("Adresse: " + hotel.Adresse);
        Console.WriteLine("Zimmerliste:");
        foreach (Zimmer zimmer in hotel.ZimmerListe)
        {
            Console.WriteLine("ZimmerNr: " + zimmer.ZimmerNr);
            Console.WriteLine("ZimmerTyp: " + zimmer.Typ);
            Console.WriteLine("Preis pro Nacht: " + zimmer.PreisProNacht);
            Console.WriteLine("Ist belegt: " + zimmer.IstBelegt);
        }
        
        Console.WriteLine("Gast: " + gast.Vorname + " " + gast.Nachname);
        Console.WriteLine("Reservierung: " + reservierung.ReservierungsNr);
        Console.WriteLine("Check-In: " + reservierung.CheckInDatum);
        Console.WriteLine("Check-Out: " + reservierung.CheckOutDatum);
    }
}