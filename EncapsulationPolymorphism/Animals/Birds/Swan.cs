namespace EncapsulationPolymorphism.Animals.Birds;

internal class Swan : Bird
{
    public bool IsUglyDuck { get; set; }

    public Swan() : base()
    {
        IsUglyDuck = new Random().Next(1, 2) < 1;
    }

    public override string Stats()
    {
        return base.Stats() + $"IsUglyDuck:{IsUglyDuck};";
    }

    public override string GetAnimalType()
    {
        return "Swan";
    }
}
