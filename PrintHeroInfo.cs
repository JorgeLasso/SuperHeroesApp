using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp;

internal class PrintHeroInfo
{
    public void PrintHero(ISuperHero superHero)
    {
        string info = superHero.GetHeroInfo();
        Console.WriteLine(info);
    }
}