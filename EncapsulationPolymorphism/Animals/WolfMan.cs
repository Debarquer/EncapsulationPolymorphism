using EncapsulationPolymorphism.Contracts;

namespace EncapsulationPolymorphism.Animals;

internal class WolfMan : Animal, IPerson
{
    public string HumanName { get; set; }

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
}
