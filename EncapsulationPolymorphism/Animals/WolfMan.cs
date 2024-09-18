using EncapsulationPolymorphism.Contracts;

namespace EncapsulationPolymorphism.Animals;

internal class WolfMan : Animal, IPerson
{
    public string HumanName { get; set; }

    string[] names =
    {
        "Vernon McCray",
        "Edgar Rose",
        "Jimmie Hawkins",
        "Earnest Moore",
        "Neil Dale",
        "Eddie Calderon",
        "Austin Morris",
        "Joel Roach",
        "Robert Jordan",
        "Alexis Marshall"
    };

    public WolfMan() : base()
    {
        Random random = new Random();
        int i = random.Next(0, names.Length);
        HumanName = names[i];
    }

    public override void DoSound()
    {
        Console.WriteLine("Bark");
    }

    public void Talk()
    {
        Console.WriteLine("Hello World");
    }

    public override string Stats()
    {
        return base.Stats() + $"HumanName:{HumanName};";
    }

    public override string GetAnimalType()
    {
        return "WolfMan";
    }
}
