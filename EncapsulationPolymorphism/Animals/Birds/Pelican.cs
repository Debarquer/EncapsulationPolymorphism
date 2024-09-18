namespace EncapsulationPolymorphism.Animals.Birds;

internal class Pelican : Bird
{
    public int NumberOfFishEasten {  get; set; }

    public override string Stats()
    {
        return base.Stats() + $"NumberOfFishEasten:{NumberOfFishEasten};";
    }

    public override string GetAnimalType()
    {
        return "Pelican";
    }
}
