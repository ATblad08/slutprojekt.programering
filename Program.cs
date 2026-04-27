using System;
using System.Collections.Generic;

class program
{
    class Typ
    {
        public string Name;
        public Dictionary<string, double> Log = new Dictionary<string, double>();
    }

    static double kolla(Typ anfall, string skydd)
    {
        if (anfall.Log.ContainsKey(skydd))
        {
            return anfall.Log[skydd];
        }
        return 1.0;
    }

    static Typ TypSomMatchar(string namn, List<Typ> allaTyper)
    {
        foreach (Typ t in allaTyper)
        {
            if (t.Name == namn) return t;
        }
        return null;
    }



        static void Main()
    {
    //skapar typ bug
    Typ bug = new Typ();
    bug.Name = "bug";
    //effectiv mot bug
    bug.Log.Add("flying", 1.6);
    bug.Log.Add("fire", 1.6);
    bug.Log.Add("rock", 1.6);
    //svag mot bug
    bug.Log.Add("fighting", 0.625);
    bug.Log.Add("grass", 0.625);
    bug.Log.Add("ground", 0.625);

    //skapar typ dark
    Typ dark = new Typ();
    dark.Name = "dark";
    //effective mot dark
    dark.Log.Add("bug", 1.6);
    dark.Log.Add("fairy", 1.6);
    dark.Log.Add("fighting", 1.6);
    //super svag mot dark
    dark.Log.Add("psychic", 0.391);
    //svag mot dark
    dark.Log.Add("dark", 0.625);
    dark.Log.Add("ghost", 0.625);

    //skapar typ dragon
    Typ dragon = new Typ();
    dragon.Name = "dragon";
    //effective mot dragon
    dragon.Log.Add("dragon", 1.6);
    dragon.Log.Add("ice", 1.6);
    dragon.Log.Add("fairy", 1.6);
    //svag mot dragon
    dragon.Log.Add("water", 0.625);
    dragon.Log.Add("fire", 0.625);
    dragon.Log.Add("grass", 0.625);
    dragon.Log.Add("electric", 0.625);

    //skapa typ electric
    Typ electric = new Typ();
    electric.Name = "electric";
    //effective mot electric
    electric.Log.Add("ground", 1.6);
    //svag mot electric
    electric.Log.Add("steel", 0.625);
    electric.Log.Add("electric", 0.625);
    electric.Log.Add("flying", 0.625);

    //skapa typ fairy 
    Typ fairy = new Typ();
    fairy.Name = "fairy";
    //effective mot fairy 
    fairy.Log.Add("poison", 1.6);
    fairy.Log.Add("steel", 1.6);
    //super svag mot fairy
    fairy.Log.Add("dragon", 0.391);
    //svag mot fairy
    fairy.Log.Add("bug", 0.625);
    fairy.Log.Add("dark", 0.625);
    fairy.Log.Add("fighting", 0.625);

    //skapa typ fighting
    Typ fighting = new Typ();
    fighting.Name = "fighting";
    //effective mot fighting
    fighting.Log.Add("fairy", 1.6);
    fighting.Log.Add("flying", 1.6);
    fighting.Log.Add("psychic", 1.6);
    //svag mot fighting
    fighting.Log.Add("bug", 0.625);
    fighting.Log.Add("dark", 0.625);
    fighting.Log.Add("rock", 0.625);

    //skapa typ fire 
    Typ fire = new Typ();
    fire.Name = "fire";
    //effective mot fire
    fire.Log.Add("ground", 1.6);
    fire.Log.Add("rock", 1.6);
    fire.Log.Add("water", 1.6);
    //svag mot fire 
    fire.Log.Add("bug", 0.625);
    fire.Log.Add("firy", 0.625);
    fire.Log.Add("fire", 0.625);
    fire.Log.Add("grass", 0.625);
    fire.Log.Add("ice", 0.625);
    fire.Log.Add("steel", 0.625);

    //skapar typ flying
    Typ flying = new Typ();
    flying.Name = "flying";
    //effective mot flying
    flying.Log.Add("electric", 1.6);
    flying.Log.Add("ice", 1.6);
    flying.Log.Add("rock", 1.6);
    //super svag mot flying 
    flying.Log.Add("ground", 0.391);
    //svag mot flying
    flying.Log.Add("bug",0.625);
    flying.Log.Add("fighting",0.625);
    flying.Log.Add("grass",0.625);

    //skapar typ ghost
    Typ ghost = new Typ();
    ghost.Name = "ghost";
    //effective mot ghost
    ghost.Log.Add("dark", 1.6);
    ghost.Log.Add("ghost", 1.6);
    //super svag mot ghost
    ghost.Log.Add("fighting", 0.391);
    ghost.Log.Add("normal", 0.391);
    //svag mot ghost
    ghost.Log.Add("bug", 0.625);
    ghost.Log.Add("poison", 0.625);

    //skapar typ grass
    Typ grass = new Typ();
    grass.Name = "grass";
    //effective mot grass
    grass.Log.Add("bug", 1.6);
    grass.Log.Add("fire", 1.6);
    grass.Log.Add("flying", 1.6);
    grass.Log.Add("ice", 1.6);
    grass.Log.Add("poison", 1.6);
    //svag mot grass
    grass.Log.Add("electric", 0.625);
    grass.Log.Add("grass", 0.625);
    grass.Log.Add("ground", 0.625);
    grass.Log.Add("water", 0.625);

    //skapar typ ground
    Typ ground = new Typ();
    ground.Name = "ground";
    //effective mot ground
    ground.Log.Add("grass", 1.6);
    ground.Log.Add("ice", 1.6);
    ground.Log.Add("water", 1.6);
    //super svag mot ground
    ground.Log.Add("electric", 0.391);
    //svag mot ground
    ground.Log.Add("poison", 0.625);
    ground.Log.Add("rock", 0.625); 

    //skapar typ ice
    Typ ice = new Typ();
    ice.Name = "ice";
    //effective mot ice
    ice.Log.Add("fighting", 1.6);
    ice.Log.Add("fire", 1.6);
    ice.Log.Add("rock", 1.6);
    ice.Log.Add("steel", 1.6);
    //svag mot ice
    ice.Log.Add("ice", 0.625);

    //skapar typ normal
    Typ normal = new Typ();
    normal.Name = "normal";
    //effective mot normal
    normal.Log.Add("fighting", 1.6);
    //super svag mot normal
    normal.Log.Add("ghost", 0.391);

    //skapar typ poison
    Typ poison = new Typ();
    poison.Name = "poison";
    //effective mot poison 
    poison.Log.Add("ground", 1.6);
    poison.Log.Add("psychic", 1.6);
    //svag mot poison 
    poison.Log.Add("bug", 0.625);
    poison.Log.Add("fairy", 0.625);
    poison.Log.Add("fighring", 0.625);
    poison.Log.Add("grass", 0.625);
    poison.Log.Add("poison", 0.625);

    //skapar typ psychic
    Typ psychic = new Typ();
    psychic.Name = "psychic";
    //effective mot psychic
    psychic.Log.Add("bug", 1.6);
    psychic.Log.Add("dark", 1.6);
    psychic.Log.Add("ghost", 1.6);
    //svag mot psychic
    psychic.Log.Add("fighting", 0.625);
    psychic.Log.Add("psychic", 0.625);

    //skapar typ rock
    Typ rock = new Typ();
    rock.Name = "rock";
    //effective mot rock
    rock.Log.Add("fighting", 1.6);
    rock.Log.Add("grass", 1.6);
    rock.Log.Add("ground", 1.6);
    rock.Log.Add("steel", 1.6);
    rock.Log.Add("water", 1.6);
    //svag mot rock
    rock.Log.Add("fire", 0.625);
    rock.Log.Add("flying", 0.625);
    rock.Log.Add("normal", 0.625);
    rock.Log.Add("poison", 0.625);

    //skapar typ steel
    Typ steel = new Typ();
    steel.Name = "steel";
    //effective mot steel
    steel.Log.Add("fighting", 1.6);
    steel.Log.Add("fire", 1.6);
    steel.Log.Add("ground", 1.6);
    //super svag mot steel
    steel.Log.Add("poison", 0.391);
    //svag mot steel
    steel.Log.Add("bug", 0.625);
    steel.Log.Add("dragon", 0.625);
    steel.Log.Add("fairy", 0.625);
    steel.Log.Add("flying", 0.625);
    steel.Log.Add("grass", 0.625);
    steel.Log.Add("ice", 0.625);
    steel.Log.Add("normal", 0.625);
    steel.Log.Add("psychic", 0.625);
    steel.Log.Add("rock", 0.625);
    steel.Log.Add("steel", 0.625);

    //skapar typ water
    Typ water = new Typ();
    water.Name = "water";
    //effective mot water 
    water.Log.Add("grass", 1.6);
    water.Log.Add("electric", 1.6);
    //svag mot water
    water.Log.Add("fire", 0.625);
    water.Log.Add("ice", 0.625);
    water.Log.Add("steel", 0.625);
    water.Log.Add("water", 0.625);

    //skapar lista med alla typer 
    List<Typ> allaTyper = new List<Typ>
    { bug, dark, dragon, electric, fairy, fighting, fire, flying, ghost, 
    grass, ground, ice, normal, poison, psychic, rock, steel, water };
   
    Console.WriteLine("Vad är din motståndarens första typ?");
    string typ1 = Console.ReadLine().ToLower();  

    Console.WriteLine("Vad är din motståndarens andra typ? (om ingen klicka enter)");
    string typ2 = Console.ReadLine().ToLower();   


    Console.WriteLine("letar efter bästa valet mot " + typ1 + " och " + typ2 + "...");
    Console.WriteLine("______________________________________________________________");


    Typ motTyp1 = TypSomMatchar(typ1, allaTyper);
    Typ motTyp2 = TypSomMatchar(typ2, allaTyper);


    if(motTyp1 != null)
    {
        foreach (Typ t in allaTyper)
        {
        double skada1 = kolla(motTyp1, t.Name);
        double skada2 = 1.0;

        if(motTyp2 != null && typ2 != "")
        { 
        skada2 = kolla(motTyp2, t.Name);
        }
    
        double totalSkada = skada1 * skada2;

        double risk1 = kolla(t, typ1);
        double risk2 = 1.0;

        if(typ2 != "")
        {
            risk2 = kolla(t, typ2);
        }

        if(totalSkada > 1.5 && risk1 <= 1.0 && risk2 <= 1.0)
        {
            Console.WriteLine(t.Name + " Gör " + totalSkada + "x skada");
        }

        else if(totalSkada > 1.5)
        {
            Console.WriteLine(t.Name + "Gör bra skada, men är svag mot motståndaren");
        }
        }
    }
    else
    {
        Console.WriteLine("Hittade inte typen, se till att stava rätt och skriva på engelska");
    };

    