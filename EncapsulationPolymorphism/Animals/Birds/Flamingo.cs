namespace EncapsulationPolymorphism.Animals.Birds;

internal class Flamingo : Bird
{
    public double Pinkess { get; set; }

    public override string Stats()
    {
        return base.Stats() + $"Pinkess:{Pinkess};";
    }

    public override string GetAnimalType()
    {
        return "Flamingo";
    }
}
