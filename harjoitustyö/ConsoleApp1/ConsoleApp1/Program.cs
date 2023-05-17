
Peli.peli();
public class Peli
{
    public static bool wearingHaarniska = false;
    public static void peli()
    {
        string tapahtuma = "a";
        string kauppaTapahtuma = "a";
        bool kaupassa = false;
        bool kotona = false;
        string kotiTapahtuma = "a";
        string taisteluTapahtuma = "a";
        bool taistelu = false;
        string ase = "Pikku Puukko";

        while (true)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1 - Taistelu");
            Console.WriteLine("2 - Kauppa");
            Console.WriteLine("3 - Kotiin");
            tapahtuma = Console.ReadLine();
            if (tapahtuma == "1")
            {
                taistelu = true;
                Console.WriteLine("Ketä vastaan haluat taistella?");
                Console.WriteLine("1 - Muurahainen (" + Enemy.muurahainenReward + " kultaa)");
                Console.WriteLine("2 - Norsu (" + Enemy.NorsuReward + " kultaa)");
                Console.WriteLine("3 - Kärpänen (" + Enemy.KärpänenReward + " kultaa)");
                Console.WriteLine("4 - Takaisin");
                while (taistelu)
                {
                    taisteluTapahtuma = Console.ReadLine();
                    if (taisteluTapahtuma == "1")
                    {
                        Enemy.Muurahainen();
                    }
                    if (taisteluTapahtuma == "2")
                    {
                        Enemy.Norsu();
                    }
                    if (taisteluTapahtuma == "3")
                    {
                        Enemy.Kärpänen();
                    }
                    if (taisteluTapahtuma == "4")
                    {
                        taistelu = false;
                    }
                }
            }
            if (tapahtuma == "2")
            {
                kaupassa = true;
                while (kaupassa)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Mitä haluat ostaa?");
                    Console.WriteLine("Sinulla on " + Kauppa.kulta + " kultaa");
                    Console.WriteLine("1 - Miekka (" + Kauppa.MiekkaHinta + " kultaa)");
                    Console.WriteLine("2 - Isompi miekka (" + Kauppa.IsompiMiekkaHinta + " kultaa)");
                    Console.WriteLine("3 - Vielä isompi miekka (" + Kauppa.VieläIsompiMiekkaHinta + " kultaa)");
                    Console.WriteLine("4 - Karkkipussi (" + Kauppa.KarkkipussiHinta + " kultaa) (" + Kauppa.KarkkipussiMäärä + "/" + Kauppa.KarkkipussiMax + ")");
                    Console.WriteLine("5 - Haarniska (" + Kauppa.haarniskaHinta + " kultaa)");
                    Console.WriteLine("6 - Lähde kaupasta");
                    kauppaTapahtuma = Console.ReadLine();
                    if (kauppaTapahtuma == "1")
                    {
                        Kauppa.Miekka();
                    }
                    if (kauppaTapahtuma == "2")
                    {
                        Kauppa.IsompiMiekka();
                    }
                    if (kauppaTapahtuma == "3")
                    {
                        Kauppa.VieläIsompiMiekka();
                    }
                    if (kauppaTapahtuma == "4")
                    {
                        Kauppa.Karkkipussi();
                    }
                    if (kauppaTapahtuma == "5")
                    {
                        Kauppa.Haarniska();
                    }
                    if (kauppaTapahtuma == "6")
                    {
                        Console.WriteLine("Lähdit kaupasta");
                        kaupassa = false;
                    }
                }

            }
            if (tapahtuma == "3")
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1 - Vaihda varustusta");
                Console.WriteLine("2 - Nukkumaan");
                kotiTapahtuma = Console.ReadLine();
                if (kotiTapahtuma == "1")
                {
                    kotona = true;
                    while (kotona)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sinulla on käytössä " + ase + "            Sinulla on " + Kauppa.KarkkipussiMäärä + "/" + Kauppa.KarkkipussiMax + " Karkkipussia");
                        if(wearingHaarniska == true)
                        {
                            Console.WriteLine("Sinulla on haarniskaa päällä");
                        }
                        if(wearingHaarniska == false)
                            {
                                Console.WriteLine("Sinulla ei ole haarniskaa päällä");
                            }
                        Console.WriteLine("Sinulla on varastossa:");
                        if (Kauppa.OnMiekka == true && ase != "Miekka")
                        {
                            Console.WriteLine("Miekka");
                        }
                        if (Kauppa.OnIsompiMiekka == true && ase != "Isompi Miekka")
                        {
                            Console.WriteLine("Isompi Miekka");
                        }
                        if (Kauppa.OnVieläIsompiMiekka == true && ase != "Vielä Isompi Miekka")
                        {
                            Console.WriteLine("Vielä Isompi Miekka");
                        }
                        if (ase != "Pikku Puukko")
                        {
                            Console.WriteLine("Pikku Puukko");
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Vastaa aseen nimi jos haluat käyttää sitä");
                        Console.WriteLine("1 - Pois");
                        if (Kauppa.OnHaarniska == true)
                        {
                            if(wearingHaarniska == true)
                            {
                                Console.WriteLine("2 - Ota haarniska pois päältä");
                            }
                            if(wearingHaarniska == false)
                            {
                                Console.WriteLine("2 - Laita haarniska päälle");
                            }
                        }
                        kotiTapahtuma = Console.ReadLine();
                        if (kotiTapahtuma == "1")
                        {
                            kotona = false;
                        }
                        if (kotiTapahtuma == "2")
                        {
                            if(wearingHaarniska == true)
                            {
                                wearingHaarniska = false;
                            }
                            else if (wearingHaarniska == false)
                            {
                                wearingHaarniska = true;
                            }
                        }
                        if (kotiTapahtuma == "Miekka" && Kauppa.OnMiekka == true && ase != "Miekka")
                        {
                            ase = "Miekka";
                            Enemy.taisteluAse = "Miekka";
                        }
                        if (kotiTapahtuma == "Isompi Miekka" && Kauppa.OnIsompiMiekka == true && ase != "Isompi Miekka")
                        {
                            ase = "Isompi Miekka";
                            Enemy.taisteluAse = "Isompi Miekka";
                        }
                        if (kotiTapahtuma == "Vielä Isompi Miekka" && Kauppa.OnVieläIsompiMiekka == true && ase != "Vielä Isompi Miekka")
                        {
                            ase = "Vielä Isompi Miekka";
                            Enemy.taisteluAse = "Vielä Isompi Miekka";
                        }
                        if (kotiTapahtuma == "Pikku Puukko" && ase != "Pikku Puukko")
                        {
                            ase = "Pikku Puukko";
                            Enemy.taisteluAse = "Pikku Puukko";
                        }

                    }
                }
            }
        }
    }
}














public class Kauppa
{
    public static bool OnMiekka = false;
    public static bool OnIsompiMiekka = false;
    public static bool OnVieläIsompiMiekka = false;
    public static bool OnHaarniska = false;
    public static int kulta = 500;
    public static int MiekkaHinta = 100;
    public static int IsompiMiekkaHinta = 200;
    public static int VieläIsompiMiekkaHinta = 300;
    public static int haarniskaHinta = 150;
    public static int KarkkipussiHinta = 30;
    public static int KarkkipussiMax = 3;
    public static int KarkkipussiMäärä = 0;

    public static void Miekka()
    {
        if (kulta >= MiekkaHinta && OnMiekka == false)
        {
            kulta -= MiekkaHinta;
            OnMiekka = true;
            Console.WriteLine("Sait hienon miekan hyvään hintaan");
        }
        else if (kulta < MiekkaHinta)
        {
            Console.WriteLine("Nyt on sinulla kyllä rahat loppu. Mene taistelemaan ansaitaksesi lisää.");
        }
        else if (OnMiekka == true)
        {
            Console.WriteLine("Sinulla on jo miekka");
        }
    }

    public static void IsompiMiekka()
    {
        if (kulta >= IsompiMiekkaHinta && OnIsompiMiekka == false)
        {
            kulta -= IsompiMiekkaHinta;
            OnIsompiMiekka = true;
            Console.WriteLine("Sait isomman miekan hyvään hintaan");
        }
        else if (kulta < IsompiMiekkaHinta)
        {
            Console.WriteLine("Nyt on sinulla kyllä rahat loppu. Mene taistelemaan ansaitaksesi lisää.");
        }
        else if (OnIsompiMiekka == true)
        {
            Console.WriteLine("Sinulla on jo isompi miekka");
        }
    }

    public static void VieläIsompiMiekka()
    {
        if (kulta >= VieläIsompiMiekkaHinta && OnVieläIsompiMiekka == false)
        {
            kulta -= VieläIsompiMiekkaHinta;
            OnVieläIsompiMiekka = true;
            Console.WriteLine("Sait isoimman miekan hyvään hintaan");
        }
        else if (kulta < VieläIsompiMiekkaHinta)
        {
            Console.WriteLine("Nyt on sinulla kyllä rahat loppu. Mene taistelemaan ansaitaksesi lisää.");
        }
       else if (OnVieläIsompiMiekka == true)
        {
            Console.WriteLine("Sinulla on jo vielä isompi miekka");
        }
    }

    public static void Haarniska()
    {
        if (kulta >= haarniskaHinta && OnHaarniska == false)
        {
            kulta -= haarniskaHinta;
            OnHaarniska = true;
            Console.WriteLine("Sait huippu haarniskan vielä huipumpaan hintaan");
        }
        else if (kulta < haarniskaHinta)
        {
            Console.WriteLine("Nyt on sinulla kyllä rahat loppu. Mene taistelemaan ansaitaksesi lisää.");
        }
        else if (OnHaarniska == true)
        {
            Console.WriteLine("Sinulla on jo haarniska");
        }
    }

    public static void Karkkipussi()
    {
        if (kulta >= KarkkipussiHinta && KarkkipussiMäärä < KarkkipussiMax)
        {
            Console.WriteLine("Ostit pussin karkkia");
            kulta -= KarkkipussiHinta;
            KarkkipussiMäärä += 1;
        }
       else if (kulta < KarkkipussiHinta)
        {
            Console.WriteLine("Nyt on sinulla kyllä rahat loppu. Mene taistelemaan ansaitaksesi lisää.");
        }
       else if (KarkkipussiMäärä == KarkkipussiMax)
        {
            Console.WriteLine("Sinulla on jo taskut täynnä karkkia");
        }
    }
}


public class Enemy
{
    static bool taistelussa = false;
    public static int muurahainenReward = 30;
    public static int NorsuReward = 100;
    public static int KärpänenReward = 300;
    static float damageMultiplier = 1;
    public static string taisteluAse = "Pikku Puukko";
    static int OsumaTarkkuus = 2;
    static int damage = 1;
    static int PlayerHP = 10;
    static int PlayerHPMax = 10;
    static string taisteluTapahtuma = "a";
    static bool taisteluTapahtuma2 = true;
    static Random IskuTarkkuus = new Random();
    static int OsuikoIsku;
    static int MuurahainenDamage = 1;
    static int NorsuDamage = 2;
    static int KärpänenDamage = 10;
    public static void Muurahainen()
    {
        float MuurahainenHP = 5;
        int MuurahainenHPMax = 5;
        if (taisteluAse == "Pikku Puukko")
        {
            damage = 1;
            damageMultiplier = 1;
            OsumaTarkkuus = 2;
        }
        if (taisteluAse == "Miekka")
        {
            damage = 2;
            damageMultiplier = 10;
            OsumaTarkkuus = 20;

        }
        if (taisteluAse == "Isompi Miekka")
        {
            damage = 3;
            damageMultiplier = 10;
            OsumaTarkkuus = 50;

        }
        if (taisteluAse == "Vielä Isompi Miekka")
        {
            damage = 4;
            damageMultiplier = 10;
            OsumaTarkkuus = 100;
        }
        taistelussa = true;
        PlayerHP = PlayerHPMax;
        while (taistelussa == true)
        {
            taisteluTapahtuma2 = true;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Muurahaisen HP: " + MuurahainenHP + "/" + MuurahainenHPMax + "       Muurahaisen hyökkäys tekee 1 pisteen vahinkoa");
            Console.WriteLine("Sinun HP: " + PlayerHP + "/" + PlayerHPMax);
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1 - Hyökkää");
            if(Kauppa.KarkkipussiMäärä > 0)
            {
                Console.WriteLine("2 - Syö karkkia (+10 HP)");
            }
            while (taisteluTapahtuma2 == true)
            {
                taisteluTapahtuma = Console.ReadLine();
                if(taisteluTapahtuma == "1")
                {
                    OsuikoIsku = IskuTarkkuus.Next(OsumaTarkkuus);
                    if (OsuikoIsku == 1)
                    {
                        MuurahainenHP -= damage * damageMultiplier;
                        Console.WriteLine("Osuit muurahaiseen");
                        if (MuurahainenHP == 0 || MuurahainenHP < 0)
                        {
                            Console.WriteLine("Voitit taistelun");
                            Console.WriteLine("+" + muurahainenReward + " kultaa");
                            Kauppa.kulta += muurahainenReward;
                            taistelussa = false;
                            Peli.peli();
                        }
                        taisteluTapahtuma = "0";
                    }
                    else
                    {
                        Console.WriteLine("Löit huti! Iso miekkasi hidastaa sinua ja Muurahaisen on helppo väistää iskusi");
                    }
                    taisteluTapahtuma2 = false;
                }
                if(taisteluTapahtuma == "2" && Kauppa.KarkkipussiMäärä > 0)
                {
                    Console.WriteLine("Syöt karkkia taisteluun tiimellyksessä (+10 HP)");
                    PlayerHP += 10;
                    if (PlayerHP > PlayerHPMax)
                    {
                        PlayerHP = PlayerHPMax;
                    }
                    Kauppa.KarkkipussiMäärä -= 1;
                    taisteluTapahtuma2 = false;
                }
            }
            if (Peli.wearingHaarniska == true)
            {
                Console.WriteLine("Muurahainen löi sinua ja teki " + MuurahainenDamage / 2 + " pistettä vahinkoa");
                PlayerHP -= MuurahainenDamage / 2;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Kärpäselle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
            else if (Peli.wearingHaarniska == false)
            {
                Console.WriteLine("Muurahainen löi sinua ja teki " + MuurahainenDamage + " pistettä vahinkoa");
                PlayerHP -= MuurahainenDamage;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Muurahaiselle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
        }

    }

    public static void Norsu()
    {
        float NorsuHP = 10;
        int NorsuHPMax = 10;
        if (taisteluAse == "Pikku Puukko")
        {
            damage = 1;
            damageMultiplier = 0.5f;
            OsumaTarkkuus = 1;
        }
        if (taisteluAse == "Miekka")
        {
            damage = 2;
            damageMultiplier = 1;
            OsumaTarkkuus = 1;

        }
        if (taisteluAse == "Isompi Miekka")
        {
            damage = 3;
            damageMultiplier = 1.5f;
            OsumaTarkkuus = 1;

        }
        if (taisteluAse == "Vielä Isompi Miekka")
        {
            damage = 4;
            damageMultiplier = 2;
            OsumaTarkkuus = 1;
        }
        taistelussa = true;
        PlayerHP = PlayerHPMax;
        while (taistelussa == true)
        {
            taisteluTapahtuma2 = true;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Norsun HP: " + NorsuHP + "/" + NorsuHPMax + "       Norsun hyökkäys tekee 2 pisteen vahinkoa");
            Console.WriteLine("Sinun HP: " + PlayerHP + "/" + PlayerHPMax);
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1 - Hyökkää");
            if(Kauppa.KarkkipussiMäärä > 0)
            {
                Console.WriteLine("2 - Syö karkkia (+10 HP)");
            }
            while (taisteluTapahtuma2 == true)
            {
                taisteluTapahtuma = Console.ReadLine();
                if (taisteluTapahtuma == "1")
                {
                    OsuikoIsku = IskuTarkkuus.Next(OsumaTarkkuus);
                    if (OsuikoIsku == 1)
                    {
                        NorsuHP -= damage * damageMultiplier;
                        Console.WriteLine("Osuit Norsuun");
                        if (NorsuHP == 0 || NorsuHP < 0)
                        {
                            Console.WriteLine("Voitit taistelun");
                            Console.WriteLine("+" + NorsuReward + " kultaa");
                            Kauppa.kulta += NorsuReward;
                            taistelussa = false;
                            Peli.peli();
                        }
                        taisteluTapahtuma = "0";
                    }
                    else
                    {
                        Console.WriteLine("Löit huti! Miten voit edes lyödä ohi niin isosta vastustajasta");
                    }
                    taisteluTapahtuma2 = false;
                }
                if (taisteluTapahtuma == "2" && Kauppa.KarkkipussiMäärä > 0)
                {
                    Console.WriteLine("Syöt karkkia taisteluun tiimellyksessä (+10 HP)");
                    PlayerHP += 10;
                    if (PlayerHP > PlayerHPMax)
                    {
                        PlayerHP = PlayerHPMax;
                    }
                    Kauppa.KarkkipussiMäärä -= 1;
                    taisteluTapahtuma2 = false;
                }
            }
            if (Peli.wearingHaarniska == true)
            {
                Console.WriteLine("Norsu löi sinua ja teki " + NorsuDamage / 2 + " pistettä vahinkoa");
                PlayerHP -= NorsuDamage / 2;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Kärpäselle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
            else if (Peli.wearingHaarniska == false)
            {
                Console.WriteLine("Norsu löi sinua ja teki " + NorsuDamage + " pistettä vahinkoa");
                PlayerHP -= NorsuDamage;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Norsulle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
        }

    }

    public static void Kärpänen()
    {
        float KärpänenHP = 3;
        int KärpänenHPMax = 3;
        if (taisteluAse == "Pikku Puukko")
        {
            damage = 1;
            damageMultiplier = 1f;
            OsumaTarkkuus = 20;
        }
        if (taisteluAse == "Miekka")
        {
            damage = 2;
            damageMultiplier = 1;
            OsumaTarkkuus = 10;

        }
        if (taisteluAse == "Isompi Miekka")
        {
            damage = 3;
            damageMultiplier = 1f;
            OsumaTarkkuus = 7;

        }
        if (taisteluAse == "Vielä Isompi Miekka")
        {
            damage = 4;
            damageMultiplier = 1;
            OsumaTarkkuus = 5;
        }
        taistelussa = true;
        PlayerHP = PlayerHPMax;
        while (taistelussa == true)
        {
            taisteluTapahtuma2 = true;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Norsun HP: " + KärpänenHP + "/" + KärpänenHPMax + "       Kärpäsen hyökkäys tekee 10 pisteen vahinkoa");
            Console.WriteLine("Sinun HP: " + PlayerHP + "/" + PlayerHPMax);
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1 - Hyökkää");
            if(Kauppa.KarkkipussiMäärä > 0)
            {
                Console.WriteLine("2 - Syö karkkia (+10 HP)");
            }
            while (taisteluTapahtuma2 == true)
            {
                taisteluTapahtuma = Console.ReadLine();
                if (taisteluTapahtuma == "1")
                {
                    OsuikoIsku = IskuTarkkuus.Next(OsumaTarkkuus);
                    if (OsuikoIsku == 1)
                    {
                        KärpänenHP -= damage * damageMultiplier;
                        Console.WriteLine("Osuit Kärpäseen");
                        if (KärpänenHP == 0 || KärpänenHP < 0)
                        {
                            Console.WriteLine("Voitit taistelun");
                            Console.WriteLine("+" + KärpänenReward + " kultaa");
                            Kauppa.kulta += KärpänenReward;
                            taistelussa = false;
                            Peli.peli();
                        }
                        taisteluTapahtuma = "0";
                    }
                    else
                    {
                        if(taisteluAse != "Vielä Isompi Miekka")
                        {
                            Console.WriteLine("Löit huti! Ehkä isompi ase olisi tarpeen");
                        }
                        else
                        {
                            Console.WriteLine("Löit huti! Ehkä ensikerralle osuu");
                        }

                    }
                    taisteluTapahtuma2 = false;
                }
                if (taisteluTapahtuma == "2" && Kauppa.KarkkipussiMäärä > 0)
                {
                    Console.WriteLine("Syöt karkkia taisteluun tiimellyksessä (+10 HP)");
                    PlayerHP += 10;
                    Kauppa.KarkkipussiMäärä -= 1;
                    taisteluTapahtuma2 = false;
                }
            }
            if (Peli.wearingHaarniska == true)
            {
                Console.WriteLine("Kärpäsen isku teki " + KärpänenDamage / 2 + " pistettä vahinkoa");
                PlayerHP -= KärpänenDamage / 2;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Kärpäselle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
            else if (Peli.wearingHaarniska == false)
            {
                Console.WriteLine("Kärpäsen isku teki " + KärpänenDamage + " pistettä vahinkoa");
                PlayerHP -= KärpänenDamage;
                if (PlayerHP <= 0)
                {
                    Console.WriteLine("Hävisit Kärpäselle");
                    taistelussa = false;
                    Peli.peli();
                }
            }
        }

    }
}


