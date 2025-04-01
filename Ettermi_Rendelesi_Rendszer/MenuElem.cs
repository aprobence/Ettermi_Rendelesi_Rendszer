namespace Ettermi_Rendelesi_Rendszer;

internal class MenuElem
{
    public string Nev { get; set; }
    public int Ar { get; set; }
    public string Kategoria { get; set; }

    public MenuElem(string nev, int ar, string kategoria)
    {
        Nev = nev;
        Ar = ar;
        Kategoria = kategoria;
    }
}