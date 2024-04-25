namespace Hotelreservierungssystem;

public class Hotel
{
    public string Name;
    public string Adresse;
    public List<Zimmer> ZimmerListe;
    
    public Hotel(string name, string adresse)
    {
        Name = name;
        Adresse = adresse;
        ZimmerListe = new List<Zimmer>();
    }
    
    public void ZimmerHinzufuegen(Zimmer zimmer)
    {
        ZimmerListe.Add(zimmer);
    }
    
    public void ZimmerEntfernen(Zimmer zimmer)
    {
        ZimmerListe.Remove(zimmer);
    }
}