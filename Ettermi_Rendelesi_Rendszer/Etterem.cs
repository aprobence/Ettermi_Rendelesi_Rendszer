namespace Ettermi_Rendelesi_Rendszer;

internal class Etterem
{
    public List<MenuElem> Menu { get; set; }
    public List<Rendeles> Rendelesek { get; set; }

    public Etterem()
    {
        Menu = new List<MenuElem>();
        Rendelesek = new List<Rendeles>();
    }

    public void HozzaadMenu(MenuElem etel)
    {
        Menu.Add(etel);
    }

    public void ListazMenut()
    {
        foreach (var item in Menu)
        {
            Console.WriteLine($"{item.Nev} - {item.Ar} Ft - {item.Kategoria}");
        }
    }

    public void UjRendeles(Vendeg vendeg)
    {
        Rendeles ujRendeles = new Rendeles(vendeg.Nev);
        Rendelesek.Add(ujRendeles);
    }
}