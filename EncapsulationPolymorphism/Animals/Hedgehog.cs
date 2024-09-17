using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal class Hedgehog : Animal
    {
        int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("...");
        }
    }
}
