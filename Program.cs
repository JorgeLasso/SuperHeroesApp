using SuperHeroesApp;
using SuperHeroesApp.Models;

var printInfo = new PrintHeroInfo();

Power Fly = new Power();
Fly.Name = "Fly";
Fly.Description = "The ability to fly";
Fly.Level = PowerLevel.Medium;

Power SuperStrength = new Power();
SuperStrength.Name = "Super Strength";
SuperStrength.Description = "The ability to lift heavy objects";
SuperStrength.Level = PowerLevel.High;

Power Invisibility = new Power();
Invisibility.Name = "Invisibility";
Invisibility.Description = "The ability to become invisible";
Invisibility.Level = PowerLevel.Low;

Power SuperSpeed = new Power();
SuperSpeed.Name = "Super Speed";
SuperSpeed.Description = "The ability to move at superhuman speeds";
SuperSpeed.Level = PowerLevel.Medium;

Power Telepathy = new Power();
Telepathy.Name = "Telepathy";
Telepathy.Description = "The ability to read minds";
Telepathy.Level = PowerLevel.High;

Power Telekinesis = new Power();
Telekinesis.Name = "Telekinesis";
Telekinesis.Description = "The ability to move objects with the mind";
Telekinesis.Level = PowerLevel.Medium;

Power SuperIntelligence = new Power();
SuperIntelligence.Name = "Super Intelligence";
SuperIntelligence.Description = "The ability to process information at superhuman speeds";
SuperIntelligence.Level = PowerLevel.High;

Power Regeneration = new Power();
Regeneration.Name = "Regeneration";
Regeneration.Description = "The ability to heal rapidly";
Regeneration.Level = PowerLevel.High;

var superman = new SuperHero();
superman.Id = 1;
superman.Name = "Superman    ";
superman.SecretIdentity = "Clark Kent";
superman.City = "Metropolis";
superman.CanFly = true;

printInfo.PrintHero(superman);

List<Power> SupermanPowers = new List<Power>();
SupermanPowers.Add(Fly);
SupermanPowers.Add(SuperStrength);
SupermanPowers.Add(SuperSpeed);
SupermanPowers.Add(SuperIntelligence);

superman.Powers = SupermanPowers;

string usePowers = superman.UsePower();
Console.WriteLine(usePowers);

string supermanSaveWorld = superman.SaveWorld();
Console.WriteLine(supermanSaveWorld);

string supermanSaveEarth = superman.SaveEarth();
Console.WriteLine($"{supermanSaveEarth} \n");

var batman = new SuperHero();
batman.Id = 2;
batman.Name = "Batman";
batman.SecretIdentity = "Bruce Wayne";
batman.City = "Gotham City";
batman.CanFly = false;

List<Power> BatmanPowers = new List<Power>();
BatmanPowers.Add(SuperIntelligence);
BatmanPowers.Add(SuperStrength);

batman.Powers = BatmanPowers;

usePowers = batman.UsePower();
Console.WriteLine(usePowers);

AntiHero wolverine = new AntiHero();
wolverine.Id = 3;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.City = "Unknown";
wolverine.CanFly = false;

printInfo.PrintHero(wolverine);

List<Power> WolverinePowers = new List<Power>();
WolverinePowers.Add(Regeneration);
WolverinePowers.Add(SuperStrength);

wolverine.Powers = WolverinePowers;

usePowers = wolverine.UsePower();
Console.WriteLine(usePowers);

string antiHeroAction = wolverine.doAntiHeroAction("Attacking the police");
Console.WriteLine(antiHeroAction);

internal enum PowerLevel
{
    Low,
    Medium,
    High
}