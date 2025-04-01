namespace Ettermi_Rendelesi_Rendszer;

internal class Rendeles
{
    public string VendegNev { get; set; }
    public List<MenuElem> TetelLista { get; set; }

    public Rendeles(string vendegNev)
    {
        VendegNev = vendegNev;
        TetelLista = new List<MenuElem>();
    }

    public int Vegosszeg()
    {
        int osszeg = 0;
        foreach (var tetel in TetelLista)
        {
            osszeg += tetel.Ar;
        }
        return osszeg;
    }
}