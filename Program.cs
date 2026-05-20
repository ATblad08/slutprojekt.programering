using System;
using System.Collections.Generic;

class program
{
    //Här kollas skadan mot en typ, finns inte typen i "log" blir skadan 1 (neutral).
    static double kolla(Typ anfall, string skydd)
    {
        if (anfall.Log.ContainsKey(skydd))
        {
            return anfall.Log[skydd];
        }
        return 1.0;
    }

    //Här letar man upp vilken typ som användaren vill slås mot.
    static Typ TypSomMatchar(string namn, List<Typ> allaTyper)
    {
        foreach (Typ t in allaTyper)
        {
            if (t.Name == namn) return t;
        }
        return null; //null om man stavat fel eller man inte hittar typen.
    }

    static void Main()
    {
        List<Typ> allaTyper = Listan.getAll(); //Hämta data från listan.

        Console.WriteLine("Vad är din motståndarens första typ?");
        string typ1 = Console.ReadLine().ToLower(); //Om stor bokstav blir den liten för att programet ska hitta rätt

        Console.WriteLine("Vad är din motståndarens andra typ? (om ingen klicka enter)");
        string typ2 = Console.ReadLine().ToLower(); 

            //Om man skriver samma typ 2 gånger blir det bara en och samma typ.
            if(typ1 == typ2)
            {
                typ2 = "";
            }  


    Console.WriteLine("letar efter bästa valet mot " + typ1 + " och " + typ2 + "...");
    Console.WriteLine("______________________________________________________________");

    //Använder sök metoden för att göra om texten till det vi letar efter.
    Typ motTyp1 = TypSomMatchar(typ1, allaTyper);
    Typ motTyp2 = TypSomMatchar(typ2, allaTyper);


    if(motTyp1 != null) //Kör bara om första typen inte är null.
    {
        foreach (Typ t in allaTyper)
        {
        //Räknar ut attack skadan.
        double skada1 = kolla(motTyp1, t.Name);
        double skada2 = 1.0;

        //Räknar med om det finns en andra typ.
        if(motTyp2 != null && typ2 != "")
        { 
        skada2 = kolla(motTyp2, t.Name);
        }

        //Multiplicerar ihop skadorna för att få totala skadan och ser till att det bara finns 3 decimaler.
        double totalSkada = skada1 * skada2;
        totalSkada = Math.Round(totalSkada, 3);

        //kollar om någon av typerna kan vara skadliga mot våra rekomendationer.
        double risk1 = kolla(t, typ1);
        double risk2 = 1.0;

        if(typ2 != "")
        {
            risk2 = kolla(t, typ2);
        }

        //soterar ut de typer som gör mest skada och tar minst skada.
        if(totalSkada > 1.5 && risk1 <= 1.0 && risk2 <= 1.0)
        {
            Console.WriteLine(t.Name + " Gör " + totalSkada + "x skada");
        }

        //skriver ut vilka som gör mest skada men tar mycket skada.
        else if(totalSkada > 1.5)
        {
            Console.WriteLine(t.Name + " funkar också, men är svag mot motståndarens typ");
        }
        }
    }
    else
    {
        //Säger till om man stavat fel eller skrev på svenska
        Console.WriteLine("Hittade inte typen, se till att stava rätt och skriva på engelska");
    }

    }
}


    