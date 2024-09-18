namespace EncapsulationPolymorphism.Animals;

internal class Wolf : Animal
{
    public string PackName { get; set; }

    string[] packNames =
{
        "The Frozen Growlers",
        "The Gloom Claws",
        "The Nightshade Pack",
        "The Valley Pack",
        "The Bitter Hunters",
        "The Grim Claws",
        "The Bittertooth Pack",
        "The Brokencrest Furs",
        "The Silentcrown Pride",
        "The Coldcrest Pack"
    };

    public Wolf(): base()
    {
        Random random = new Random();
        int i = random.Next(0, packNames.Length);
        PackName = packNames[i];
    }

    public override void DoSound()
    {
        Console.WriteLine("Howl");
    }

    public override string Stats()
    {
        return base.Stats() + $"PackName:{PackName};";
    }

    public override string GetAnimalType()
    {
        return "Wolf";
    }
}
