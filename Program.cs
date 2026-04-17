class Typ{
public string Name;
public Dictionary<string, double> Log = new Dictionary<string, double>();
}

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
Typ electric = new typ();
electric.Name = "dragon";
//effective mot electric
electric.Log.Add("ground", 1.60);
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
flying.log.Add("electric", 1.6);
flying.log.Add("ice", 1.6);
flying.log.Add("rock", 1.6);
//super svag mot flying 
flying.log.Add("ground", 0.391);
//svag mot flying
flying.log.Add("bug",0.625);
flying.log.Add("fighting",0.625);
flying.log.Add("grass",0.625);

//skapar typ ghost
Typ ghost = new Typ();
ghost.Name = "ghost";
//effective mot ghost
ghost.log.Add("dark", 1.6);
ghost.log.Add("ghost", 1.6);
//super svag mot ghost
ghost.log.Add("fighting", 0.391);
ghost.log.Add("normal", 0.391);
//svag mot ghost
ghost.log.Add("bug", 0.625);
ghost.log.Add("poison", 0.625);

//skapar typ grass
Typ grass = new Typ();
grass.Name = "grass";
//effective mot grass
grass.log.Add("bug", 1.6);
grass.log.Add("fire", 1.6);
grass.log.Add("flying", 1.6);
grass.log.Add("ice", 1.6);
grass.log.Add("poison", 1.6);
//svag mot grass
grass.log.Add("electric", 0.625);
grass.log.Add("grass", 0.625);
grass.log.Add("ground", 0.625);
grass.log.Add("water", 0.625);

//skapar typ ground
Typ ground = new Typ();
ground.Name = "ground";
//effective mot ground
ground.log.Add("grass", 1.6);
ground.log.Add("ice", 1.6);
ground.log.Add("water", 1.6);
//super svag mot ground
ground.log.Add("electric", 0.391);
//svag mot ground
ground.log.Add("poison", 0.625);
ground.log.Add("rock", 0.625); 

//skapar typ ice
typ ice = new Typ();
ice.Name = "ice";
//effective mot ice
ice.log.Add("fighting", 1.6);
ice.log.Add("fire", 1.6);
ice.log.Add("rock", 1.6);
ice.log.Add("steel", 1.6);
//svag mot ice
ice.log.Add("ice", 0.625);

//skapar typ normal
Typ normal = new Typ();
normal.Name = "normal";
//effective mot normal
normal.log.Add("fighting", 1.6);
//super svag mot normal
normal.log.Add("ghost", 0.391);

//skapar typ poison
Typ poison = new Typ();
poison.Name = "poison";
//effective mot poison 
poison.log.Add("ground", 1.6);
poison.log.Add("psychic", 1.6);
//svag mot poison 
poison.log.Add("bug", 0.625);
poison.log.Add("fairy", 0.625);
poison.log.Add("fighring", 0.625);
poison.log.Add("grass", 0.625);
poison.log.Add("poison", 0.625);

//skapar typ psychic
Typ psychic = new Typ();
psychic.Name = "psychic";
//effective mot psychic
psychic.log.Add("bug", 1.6);
psychic.log.Add("dark", 1.6);
psychic.log.Add("ghost", 1.6);
//svag mot psychic
psychic.log.Add("fighting", 0.625);
psychic.log.Add("psychic", 0.625);

//skapar typ rock
Typ rock = new Typ();
rock.Name = "rock";
//effective mot rock
rock.log.Add("fighting", 1.6);
rock.log.Add("grass", 1.6);
rock.log.Add("ground", 1.6);
rock.log.Add("steel", 1.6);
rock.log.Add("water", 1.6);
//svag mot rock
rock.log.Add("fire", 0.625);
rock.log.Add("flying", 0.625);
rock.log.Add("normal", 0.625);
rock.log.Add("poison", 0.625);

//skapar typ steel
Typ steel = new Typ();
steel.Name = "steel";
//effective mot steel
steel.log.Add("fighting", 1.6);
steel.log.Add("fire", 1.6);
steel.log.Add("ground", 1.6);
//super svag mot steel
steel.log.Add("poison", 0.391);
//svag mot steel
steel.log.Add("bug", 0.625);
steel.log.Add("dragon", 0.625);
steel.log.Add("fairy", 0.625);
steel.log.Add("flying", 0.625);
steel.log.Add("grass", 0.625);
steel.log.Add("ice", 0.625);
steel.log.Add("normal", 0.625);
steel.log.Add("psychic", 0.625);
steel.log.Add("rock", 0.625);
steel.log.Add("steel", 0.625);

//skapar typ water
Typ water = new Typ();
water.Name = "water";
//effective mot water 
water.log.Add("grass", 1.6);
water.log.Add("electric", 1.6);
//svag mot water
water.log.Add("fire", 0.625);
water.log.Add("ice", 0.625);
water.log.Add("steel", 0.625);
water.log.Add("water", 0.625);
