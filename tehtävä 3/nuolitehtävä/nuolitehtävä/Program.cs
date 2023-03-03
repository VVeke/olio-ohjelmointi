string karkitilaus = "a";
string peratilaus = "b";
int pituustilaus = 0;
string haluttupituus;

Console.WriteLine("Minkälainen kärki (puu, teräs, timantti) :");
while (karkitilaus != "puu" || karkitilaus != "teräs" || karkitilaus != "timantti" )
{
    karkitilaus = Console.ReadLine();
    if (karkitilaus == "puu"  || karkitilaus == "timantti" || karkitilaus == "teräs")
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
Nuoli tilattuNuoli = new Nuoli(karkitilaus, peratilaus , pituustilaus);
Console.WriteLine("Nuoli maksaa " + tilattuNuoli.PalautaHinta() + " kultaa");



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
