using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals.Birds
{
    internal class Pelican : Bird
    {
        public int NumberOfFishEasten {  get; set; }

        public override string Stats()
        {
            return base.Stats() + $"NumberOfFishEasten:{NumberOfFishEasten};";
        }
    }
}
