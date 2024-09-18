namespace EncapsulationPolymorphism.Animals;

internal abstract class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Age { get; set; }

    string[] names =
    {
        "Dragozomee",
        "Skupit",
        "Camauveacseo",
        "Spidoollee",
        "Klaarsoth",
        "Coucsatee",
        "Daupipecker",
        "Gleamite",
        "Paubrics",
        "Glecsino",
        "Panamander",
        "Komoduin"
    };

    public Animal()
    {
        Random random = new Random();
        int i = random.Next(0, names.Length);
        Name = names[i];
        Weight = random.Next(10, 100);
        Age = random.Next(1, 100);
    }

    public abstract void DoSound();

    public virtual string Stats()
    {
        return $"Name:{Name};Weight:{Weight};Age:{Age};";
    }

    public virtual string GetAnimalType()
    {
        return "Animal";
    }
}
