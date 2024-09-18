namespace EncapsulationPolymorphism.Animals;

internal class Dog : Animal
{
    public bool IsGoodBoy => true;
    public string Breed { get; set; }

    public override void DoSound()
    {
        Console.WriteLine("Bark");
    }

    public override string Stats()
    {
        return base.Stats() + $"IsGoodBoy:{IsGoodBoy};Breed:{Breed};";
    }

    public void Fetch()
    {
        // IsGoodBoy = true; // Is always true
        Console.WriteLine("Dog found something!");
    }
}
