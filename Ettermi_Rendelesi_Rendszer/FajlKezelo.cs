namespace Ettermi_Rendelesi_Rendszer;

internal class FajlKezelo
{
    private static string menuFajl = "menu.txt";
    private static string rendelesFajl = "rendelesek.txt";
    
    public static List<MenuElem> MenuBetoltese()
    {
        List<MenuElem> menu = new List<MenuElem>();
        if (File.Exists(menuFajl))
        {
            string[] sorok = File.ReadAllLines(menuFajl);
            foreach (var sor in sorok)
            {
                var adatok = sor.Split(',');
                menu.Add(new MenuElem(adatok[0], int.Parse(adatok[1]), adatok[2]));
            }
        }
        return menu;
    }
    
    public static void MenuMentese(List<MenuElem> menu)
    {
        using (StreamWriter sw = new StreamWriter(menuFajl))
        {
            foreach (var item in menu)
            {
                sw.WriteLine($"{item.Nev},{item.Ar},{item.Kategoria}");
            }
        }
    }
    
    public static void RendelesMentese(List<Rendeles> rendelesek)
    {
        using (StreamWriter sw = new StreamWriter(rendelesFajl))
        {
            foreach (var rendeles in rendelesek)
            {
                sw.WriteLine($"{rendeles.VendegNev}:{rendeles.TetelLista}");
            }
        }
    }
}