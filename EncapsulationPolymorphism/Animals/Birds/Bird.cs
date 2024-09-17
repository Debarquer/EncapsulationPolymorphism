using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals.Birds
{
    internal class Bird : Animal
    {
        public double FlightSpeed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }

        public override string Stats()
        {
            return base.Stats() + $"FlightSpeed:{FlightSpeed};";
        }
    }
}
