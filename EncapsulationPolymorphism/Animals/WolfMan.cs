using EncapsulationPolymorphism.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal class WolfMan : Animal, IPerson
    {
        public string HumanName { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }

        public void Talk()
        {
            Console.WriteLine("Hello World");
        }

        public override string Stats()
        {
            return base.Stats() + $"HumanName:{HumanName};";
        }
    }
}
