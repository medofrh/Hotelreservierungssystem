namespace Hotelreservierungssystem;

public class Reservierung
{
    public int ReservierungsNr;
    public Gast Gast;
    public Zimmer Zimmer;
    public DateTime CheckInDatum;
    public DateTime CheckOutDatum;
    
    public Reservierung(int reservierungsNr, Gast gast, Zimmer zimmer, DateTime checkInDatum, DateTime checkOutDatum)
    {
        ReservierungsNr = reservierungsNr;
        Gast = gast;
        Zimmer = zimmer;
        CheckInDatum = checkInDatum;
        CheckOutDatum = checkOutDatum;
    }
    
    public void ueberpruefenReservierung()
    {
        // Überprüfe Reservierung
    }
}