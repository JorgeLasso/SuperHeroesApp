using SuperHeroesApp.Interfaces;
using System.Text;

namespace SuperHeroesApp.Models;

internal class SuperHero : Hero, ISuperHero
{
    private string _Name;
    public int Id { get; set; } = 1;

    public override string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value.Trim();
        }
    }

    public string NameAndSecretIdentity
    {
        get
        {
            return $"{Name} ({SecretIdentity})";
        }
    }

    public string SecretIdentity { get; set; }
    public string City;
    public List<Power> Powers;
    public bool CanFly;

    public SuperHero()
    {
        Id = 1;
        Powers = new List<Power>();
        CanFly = false;
    }

    public string UsePower()
    {
        //StringBuilder is used for concatenating strings
        StringBuilder sb = new StringBuilder();
        foreach (var power in Powers)
        {
            sb.AppendLine($"{NameAndSecretIdentity} is using the {power.Name} Power");
        }

        return sb.ToString();
    }

    public override string SaveWorld()
    {
        return $"{NameAndSecretIdentity} is saving the world!";
    }

    public override string SaveEarth()
    {
        //return base.SaveEarth();
        return $"{NameAndSecretIdentity} is saving the Earth!";
    }
}