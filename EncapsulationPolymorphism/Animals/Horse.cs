namespace EncapsulationPolymorphism.Animals;

internal class Horse : Animal
{
    public double HorsePower => 15;
    public DateTime LastReshoe {  get; set; }

    public Horse(): base()
    {
        int year = 2024;
        int month = new Random().Next(0, 12);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int day = new Random().Next(0, daysInMonth);

        LastReshoe = new DateTime(year, month, day);
    }

    public override void DoSound()
    {
        Console.WriteLine("Neigh");
    }

    public override string Stats()
    {
        return base.Stats() + $"HorsePower:{HorsePower};LastReshoe:{LastReshoe.ToShortDateString()};";
    }

    public override string GetAnimalType()
    {
        return "Horse";
    }
}
