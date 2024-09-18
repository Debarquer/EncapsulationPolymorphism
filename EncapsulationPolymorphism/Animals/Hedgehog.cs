namespace EncapsulationPolymorphism.Animals;

internal class Hedgehog : Animal
{
    int NrOfSpikes { get; set; }

    public Hedgehog() : base()
    {
        NrOfSpikes = new Random().Next(200, 400);
    }

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
