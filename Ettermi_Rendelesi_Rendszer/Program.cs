namespace Ettermi_Rendelesi_Rendszer;

class Program
{
    static void Main(string[] args)
    {
        Etterem etterem = new Etterem();
        etterem.Menu = FajlKezelo.MenuBetoltese();

        Vendeg vendeg1 = new Vendeg("Kiss Péter");

        MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
        MenuElem cola = new MenuElem("Kóla", 500, "Ital");
   
        etterem.HozzaadMenu(burger);
        etterem.HozzaadMenu(cola);

        etterem.ListazMenut();

        vendeg1.Rendel(burger);
        vendeg1.Rendel(cola);

        etterem.UjRendeles(vendeg1);

        FajlKezelo.MenuMentese(etterem.Menu);
        FajlKezelo.RendelesMentese(etterem.Rendelesek);
    }
}