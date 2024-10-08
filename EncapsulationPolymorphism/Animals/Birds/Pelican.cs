﻿namespace EncapsulationPolymorphism.Animals.Birds;

internal class Pelican : Bird
{
    public int NumberOfFishEasten {  get; set; }

    public Pelican(): base()
    {
        NumberOfFishEasten = new Random().Next(0, 1000);
    }

    public override string Stats()
    {
        return base.Stats() + $"NumberOfFishEasten:{NumberOfFishEasten};";
    }

    public override string GetAnimalType()
    {
        return "Pelican";
    }
}
