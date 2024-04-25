namespace Hotelreservierungssystem;

public class Gast
{
    public string Vorname;
    public string Nachname;
    public int GastNr;
    
    public Gast(string vorname, string nachname)
    {
        Vorname = vorname;
        Nachname = nachname;
    }
    
    public void ReservierungHinzufuegen(Zimmer zimmer)
    {
        // Füge Reservierung hinzu
    }
    
    public void ReservierungStornieren(Zimmer zimmer)
    {
        // Storniere Reservierung
    }
}