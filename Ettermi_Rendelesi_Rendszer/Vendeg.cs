namespace Ettermi_Rendelesi_Rendszer;

internal class Vendeg
{
    public string Nev { get; set; }
    public List<MenuElem> Rendelesek { get; set; } = new List<MenuElem>();

    public Vendeg(string nev)
    {
        Nev = nev;
    }

    public void Rendel(MenuElem tetel)
    {
        Rendelesek.Add(tetel);
    }

    public int Fizetes()
    {
        int vegosszeg = 0;
        foreach (var tetel in Rendelesek)
        {
            vegosszeg += tetel.Ar;
        }
        Rendelesek.Clear();
        return vegosszeg;
    }
}