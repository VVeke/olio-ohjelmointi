string karkitilaus = "a";
string peratilaus = "b";
int pituustilaus = 0;
string haluttupituus;
string isCustom = "a";
string valmisNuoli = "b";
Nuoli asiakkaanNuoli;


Console.WriteLine("Millainen nuoli (custom, valmis) :");
while (isCustom != "custom" || isCustom != "valmis")
{
    isCustom = Console.ReadLine();
    if (isCustom == "valmis")
    {
        Console.WriteLine("Millainen valmis nuoli (eliitti, aloittelija, perus) :");
        while(valmisNuoli != "eliitti" || valmisNuoli != "aloittelija" || valmisNuoli != "perus")
        {
            valmisNuoli = Console.ReadLine();
            if(valmisNuoli == "eliitti")
            {
               asiakkaanNuoli = Nuoli.LuoEliittiNuoli();
                Console.WriteLine("Nuoli maksaa " + asiakkaanNuoli.PalautaHinta() + " kultaa");
                Environment.Exit(0);
            }
            if(valmisNuoli == "aloittelija")
            {
                asiakkaanNuoli = Nuoli.LuoAloittelijaNuoli();
                Console.WriteLine("Nuoli maksaa " + asiakkaanNuoli.PalautaHinta() + " kultaa");
                Environment.Exit(0);
            }
            if(valmisNuoli == "perus")
            {
                asiakkaanNuoli = Nuoli.LuoPerusNuoli();
                Console.WriteLine("Nuoli maksaa " + asiakkaanNuoli.PalautaHinta() + " kultaa");
                Environment.Exit(0);
            }
        }
    }
    else if (isCustom == "custom")
    {
        break;
    }
}
if(isCustom == "custom")
{
    Console.WriteLine("Minkälainen kärki (puu, teräs, timantti) :");
    while (karkitilaus != "puu" || karkitilaus != "teräs" || karkitilaus != "timantti")
    {
        karkitilaus = Console.ReadLine();
        if (karkitilaus == "puu" || karkitilaus == "timantti" || karkitilaus == "teräs")
        {
            break;
        }
    }
    Console.WriteLine("Minkälainen perä (lehti, kanansulka, kotkansulka) :");
    while (peratilaus != "lehti" || peratilaus != "kanansulka" || peratilaus != "kotkansulka")
    {
        peratilaus = Console.ReadLine();
        if (peratilaus == "lehti" || peratilaus == "kanansulka" || peratilaus == "kotkansulka")
        {
            break;
        }
    }
    Console.WriteLine("Nuolen pituus (60-100cm) :");
    while (pituustilaus < 60 || pituustilaus > 100)
    {
        haluttupituus = Console.ReadLine();
        if (int.TryParse(haluttupituus, out pituustilaus) == true && pituustilaus < 100 && pituustilaus > 60)
        {
            break;
        }
    }
    Nuoli tilattuNuoli = new Nuoli(karkitilaus, peratilaus, pituustilaus);
    Console.WriteLine("Nuoli maksaa " + tilattuNuoli.PalautaHinta() + " kultaa");
}






public class Nuoli
{
    public string _karki { get; set; }
    public string _pera { get; set; }
    public double _pituus { get; set; }
    private double nuolenhinta;

    public Nuoli(string karki, string pera, int pituus)
    {
        _karki = karki;
        _pera = pera;
        _pituus = pituus;
        if (karki == "puu")
        {
            nuolenhinta += 3;
        }
        if (karki == "teräs")
        {
            nuolenhinta += 5;
        }
        if (karki == "timantti")
        {
            nuolenhinta += 50;
        }
        if (pera == "kanansulka")
        {
            nuolenhinta += 1;
        }
        if (pera == "kotkansulka")
        {
            nuolenhinta += 5;
        }
        nuolenhinta = nuolenhinta + _pituus * 0.05;
        return;
    }

    public static Nuoli LuoEliittiNuoli()
    {
        Nuoli tilattuNuoli = new Nuoli("timantti", "kotkansulka", 100);
        return tilattuNuoli;
    }

    public static Nuoli LuoAloittelijaNuoli()
    {
        Nuoli tilattuNuoli = new Nuoli("puu", "kanansulka", 70);
        return tilattuNuoli;
    }

    public static Nuoli LuoPerusNuoli()
    {
        Nuoli tilattuNuoli = new Nuoli("teräs", "kanansulka", 85);
        return tilattuNuoli;
    }

    public double PalautaHinta()
    {
        return nuolenhinta;
    }
    public string Karki()
    {
        return _karki;
    }
    public string Pera()
    {
        return _pera;
    }
    public double Pituus()
    {
        return _pituus;
    }
}
