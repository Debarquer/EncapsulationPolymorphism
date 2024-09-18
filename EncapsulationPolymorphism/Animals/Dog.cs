namespace EncapsulationPolymorphism.Animals;

internal class Dog : Animal
{
    public bool IsGoodBoy => true;
    public string Breed { get; set; }

    string[] breeds =
{
        "German Shepherd",
        "Shetland Sheepdog",
        "Golden Retriever"
    };

    public Dog() : base()
    {
        Random random = new Random();
        int i = random.Next(0, breeds.Length);
        Breed = breeds[i];
    }

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

    public override string GetAnimalType()
    {
        return "Dog";
    }
}
