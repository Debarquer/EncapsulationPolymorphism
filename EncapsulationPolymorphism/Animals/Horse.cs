namespace EncapsulationPolymorphism.Animals;

internal class Horse : Animal
{
    public double HorsePower => 15;
    public DateTime LastReshoe {  get; set; }

    public override void DoSound()
    {
        Console.WriteLine("Neigh");
    }

    public override string Stats()
    {
        return base.Stats() + $"HorsePower:{HorsePower};LastReshoe:{LastReshoe};";
    }

    public override string GetAnimalType()
    {
        return "Horse";
    }
}
