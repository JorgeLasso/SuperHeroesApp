namespace SuperHeroesApp.Models;

internal class Power
{
    public string Name;
    public string Description;
    public PowerLevel Level;

    public Power()
    {
        Level = PowerLevel.Low;
    }
}