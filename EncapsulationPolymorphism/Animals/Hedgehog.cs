namespace EncapsulationPolymorphism.Animals;

internal class Hedgehog : Animal
{
    int NrOfSpikes { get; set; }

    public override void DoSound()
    {
        Console.WriteLine("...");
    }

    public override string Stats()
    {
        return base.Stats() + $"NrOfSpikes:{NrOfSpikes};";
    }

    public override string GetAnimalType()
    {
        return "Hedgehog";
    }
}
