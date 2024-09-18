namespace EncapsulationPolymorphism.Animals;

internal class Worm : Animal
{
    public int NrOfHolesDug { get; set; }

    public override void DoSound()
    {
        Console.WriteLine("*Silence*");
    }

    public override string Stats()
    {
        return base.Stats() + $"NrOfHolesDug:{NrOfHolesDug};";
    }

    public override string GetAnimalType()
    {
        return "Worm";
    }
}
