using System.Runtime.InteropServices;

namespace Hotelreservierungssystem;

public class Zimmer
{
    public int ZimmerNr;
    public enum ZimmerTyp  
    {
        Einzelzimmer,
        Doppelzimmer,
        Suite
    }
    public ZimmerTyp Typ;

    public decimal PreisProNacht;
    public bool IstBelegt;
    
    public Zimmer(int zimmerNr, ZimmerTyp zimmerTyp, decimal preisProNacht)
    {
        ZimmerNr = zimmerNr;
        PreisProNacht = preisProNacht;
    }
    
    public void Reservieren()
    {
        IstBelegt = true;
    }
    
    public void Stornieren()
    {
        IstBelegt = false;
    }
}