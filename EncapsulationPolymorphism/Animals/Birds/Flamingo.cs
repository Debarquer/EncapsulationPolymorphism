using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals.Birds
{
    internal class Flamingo : Bird
    {
        public double Pinkess { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"Pinkess:{Pinkess};";
        }
    }
}
