
string haluttuRuoka = "a";
(ruoka food,lisuke lisukkeet,kastike kastikkeet) ruokaAnnos;
ruokaAnnos.food = ruoka.eiTietoa;
ruokaAnnos.lisukkeet = lisuke.eiTietoa;
ruokaAnnos.kastikkeet = kastike.eiTietoa;

while (haluttuRuoka != "Nautaa"|| haluttuRuoka != "Kanaa" || haluttuRuoka !=  "Kasviksia" || haluttuRuoka == null)
{
    Console.WriteLine("Mitä ruokaa haluat?");
    Console.WriteLine("Nautaa");
    Console.WriteLine("Kanaa");
    Console.WriteLine("Kasviksia");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    haluttuRuoka = Console.ReadLine();
    if (haluttuRuoka == "Nautaa" || haluttuRuoka == "Kanaa" || haluttuRuoka == "Kasviksia")
    {
        break;
    }
}
if (haluttuRuoka == "Nautaa")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.food = ruoka.nautaa;
}
if (haluttuRuoka == "Kanaa")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.food = ruoka.kanaa;
}
if (haluttuRuoka == "Kasviksia")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.food = ruoka.kasviksia;
}

while (haluttuRuoka == "Nautaa" || haluttuRuoka == "Kanaa" || haluttuRuoka == "Kasviksia")
{
    Console.WriteLine("Minkä lisukkeen haluat?");
    Console.WriteLine("Perunaa");
    Console.WriteLine("Riisiä");
    Console.WriteLine("Pastaa");
    haluttuRuoka = Console.ReadLine();
    if (haluttuRuoka == "Perunaa" || haluttuRuoka == "Riisiä" || haluttuRuoka == "Pastaa")
    {
        break;
    }
}
if (haluttuRuoka == "Perunaa")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.lisukkeet = lisuke.perunaa;
}
if (haluttuRuoka == "Riisiä")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.lisukkeet = lisuke.riisiä;
}
if (haluttuRuoka == "Pastaa")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.lisukkeet = lisuke.pastaa;
}

while (haluttuRuoka == "Perunaa" || haluttuRuoka == "Riisiä" || haluttuRuoka == "Pastaa")
{
    Console.WriteLine("Minkä kastikkeen haluat?");
    Console.WriteLine("Curry");
    Console.WriteLine("Hapanimelä");
    Console.WriteLine("Pippuri");
    Console.WriteLine("Chili");
    haluttuRuoka = Console.ReadLine();
    if (haluttuRuoka == "Chili" || haluttuRuoka == "Pippuri" || haluttuRuoka == "Curry" || haluttuRuoka == "Hapanimelä")
    {
        break;
    }
}
if (haluttuRuoka == "Curry")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.kastikkeet = kastike.curry;
}
if (haluttuRuoka == "Hapanimelä")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.kastikkeet = kastike.hapanimelä;
}
if (haluttuRuoka == "Pippuri")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.kastikkeet = kastike.pippuri;
}
if (haluttuRuoka == "Chili")
{
    Console.WriteLine("-----------------------------------------");
    ruokaAnnos.kastikkeet = kastike.chili;
}
Console.WriteLine("Annoksesi on " + ruokaAnnos.food + " ja " + ruokaAnnos.lisukkeet + " " + ruokaAnnos.kastikkeet + " kastikkeessa.");





enum kastike
{
    curry, hapanimelä, pippuri, chili, eiTietoa
};
enum lisuke
{
    perunaa, riisiä, pastaa, eiTietoa
};
enum ruoka
{
    nautaa, kanaa, kasviksia, eiTietoa
};