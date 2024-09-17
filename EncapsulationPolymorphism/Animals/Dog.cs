using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPolymorphism.Animals
{
    internal class Dog : Animal
    {
        public bool IsGoodBoy => true;
        public string Breed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
