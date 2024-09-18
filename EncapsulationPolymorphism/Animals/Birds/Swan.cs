namespace EncapsulationPolymorphism.Animals.Birds;

internal class Swan : Bird
{
    public bool IsUglyDuck { get; set; }

    public override string Stats()
    {
        return base.Stats() + $"IsUglyDuck:{IsUglyDuck};";
    }

    public override string GetAnimalType()
    {
        return "Swan";
    }
}
