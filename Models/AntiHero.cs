namespace SuperHeroesApp.Models;

internal class AntiHero : SuperHero
{
    public string doAntiHeroAction(string action)
    {
        return $"{NameAndSecretIdentity} is doing an anti-hero action: {action}";
    }
}