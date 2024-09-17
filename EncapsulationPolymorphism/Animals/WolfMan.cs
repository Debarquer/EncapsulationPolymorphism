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
        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }

        public void Talk()
        {
            Console.WriteLine("Hello World");
        }
    }
}
