namespace SuperHeroesApp.Models;

internal abstract class Hero
{
    public abstract string Name { get; set; }

    public abstract string SaveWorld();

    public virtual string SaveEarth()
    {
        return $"{Name} is saving the Earth!";
    }
}